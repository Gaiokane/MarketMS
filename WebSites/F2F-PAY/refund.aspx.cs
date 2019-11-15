using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;
using Com.Alipay;
using System.Threading;
using Aop.Api;
using Aop.Api.Request;
using Aop.Api.Response;
using Com.Alipay.Domain;
using Com.Alipay.Business;
using Com.Alipay.Model;

namespace F2FPay
{
    /// <summary>
    /// 功能：收单退款接口接入页
    /// 日期：2016-12-27
    /// 说明：
    /// 以下代码只是为了方便商户测试而提供的样例代码，商户可以根据自己网站的需要，按照技术文档编写,并非一定要使用该代码。
    /// 该代码仅供学习和研究支付宝接口使用，只是提供一个参考。
    /// 
    /// /////////////////注意///////////////////////////////////////////////////////////////
    /// 如果您在接口集成过程中遇到问题，可以按照下面的途径来解决
    /// 1、支持中心（https://support.open.alipay.com/alipay/support/index.htm），提交申请集成协助，我们会有专业的技术工程师主动联系您协助解决
    /// 2、开发者论坛（https://openclub.alipay.com/）
    /// </summary>
    public partial class refund : System.Web.UI.Page
    {


        string result = "";

        IAlipayTradeService serviceClient = F2FBiz.CreateClientInstance(Config.serverUrl, Config.appId, Config.merchant_private_key,Config.version,
                             Config.sign_type, Config.alipay_public_key, Config.charset);

        public string oid;
        public string roid;
        public string price;

        protected void Page_Load(object sender, EventArgs e)
        {
            oid = Request.QueryString["oid"].ToString().Trim();
            roid = Request.QueryString["roid"].ToString().Trim();
            price = Request.QueryString["price"].ToString().Trim();

            this.WIDout_trade_no.Text = oid;//商户订单号
            this.WIDout_trade_no.Enabled = false;

            this.WIDout_request_no.Text = roid;//商户退款请求单号
            this.WIDout_request_no.Enabled = false;

            this.WIDrefund_amount.Text = price;//退款金额
            this.WIDrefund_amount.Enabled = false;
        }

        protected void BtnAlipay_Click(object sender, EventArgs e)
        {
            ////////////////////////////////////////////请求参数////////////////////////////////////////////


            AlipayTradeRefundContentBuilder builder = BuildContent();

            
            AlipayF2FRefundResult refundResult  = serviceClient.tradeRefund(builder);

            //请在这里加上商户的业务逻辑程序代码
            //——请根据您的业务逻辑来编写程序（以下代码仅作参考）——
            switch (refundResult.Status)
            {
                case ResultEnum.SUCCESS:
                    DoSuccessProcess(refundResult);
                    break;
                case ResultEnum.FAILED:
                    DoFailedProcess(refundResult);
                    break;
                case ResultEnum.UNKNOWN:
                    if (refundResult.response == null)
                    {
                        result = "配置或网络异常，请检查";
                    }
                    else
                    {
                        result = "系统异常，请走人工退款流程";
                    }
                    break;
            }
            Response.Redirect("result.aspx?Text=" + result);

        }


        /// <summary>
        /// 构造退款请求数据
        /// </summary>
        /// <returns>请求数据集</returns>
        private AlipayTradeRefundContentBuilder BuildContent()
        {
            AlipayTradeRefundContentBuilder builder = new AlipayTradeRefundContentBuilder();

            //支付宝交易号与商户网站订单号不能同时为空
            builder.out_trade_no =WIDout_trade_no.Text.Trim();

            //退款请求单号保持唯一性。
            builder.out_request_no = WIDout_request_no.Text.Trim();
           
            //退款金额
            builder.refund_amount = WIDrefund_amount.Text.Trim();

            builder.refund_reason = "refund reason";

            return builder;
            
        }

        /// <summary>
        /// 请添加支付成功后的处理
        /// </summary>
        private void DoSuccessProcess(AlipayF2FRefundResult refundResult)
        {

            //请添加退款成功后的处理
            result = refundResult.response.Body;
        }

        /// <summary>
        /// 请添加支付失败后的处理
        /// </summary>
        private void DoFailedProcess(AlipayF2FRefundResult refundResult)
        {

            //请添加退款失败后的处理
            result = refundResult.response.Body;
        }

    
    }
}