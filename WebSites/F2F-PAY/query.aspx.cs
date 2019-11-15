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
using Com.Alipay.Business;
using Com.Alipay.Model;




namespace F2FPay
{

    /// <summary>
    /// 功能：收单查询接口接入页
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
    public partial class query : System.Web.UI.Page
    {

        IAlipayTradeService serviceClient = F2FBiz.CreateClientInstance(Config.serverUrl, Config.appId, Config.merchant_private_key, Config.version,
                             Config.sign_type, Config.alipay_public_key, Config.charset);

        string result = "";
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void BtnAlipay_Click(object sender, EventArgs e)
        {
            ////////////////////////////////////////////请求参数////////////////////////////////////////////

            //商户订单号
            string out_trade_no = WIDout_trade_no.Text.Trim();

            //商户网站订单系统中唯一订单号，必填

            AlipayF2FQueryResult queryResult = serviceClient.tradeQuery(out_trade_no);

            //请在这里加上商户的业务逻辑程序代码
            //——请根据您的业务逻辑来编写程序（以下代码仅作参考）——
            switch (queryResult.Status)
            {
                case ResultEnum.SUCCESS:
                    DoSuccessProcess(queryResult);
                    break;
                case ResultEnum.FAILED:
                    DoFailedProcess(queryResult);
                    break;
                case ResultEnum.UNKNOWN:
                    if (queryResult.response == null)
                    {
                        //result = "网络异常，请检查网络配置";
                        result = "配置或网络异常，请检查";
                    }
                    else
                    {
                        result = "系统异常，请重试";
                    }

                    break;
            }
            Response.Redirect("result.aspx?Text=" + result);

        }

        private void DoSuccessProcess(AlipayF2FQueryResult queryResult)
        {

            //请添加支付成功后的处理
            result = queryResult.response.Body;
        }


        private void DoFailedProcess(AlipayF2FQueryResult queryResult)
        {

            //请添加查询支付失败的处理
            result = queryResult.response.Body;
        }
    }
}