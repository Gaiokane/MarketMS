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
using Com.Alipay.Model;
using Com.Alipay.Business;




namespace F2FPay
{
    /// <summary>
    /// 功能：云监控接口接入页
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
    public partial class Monitor : System.Web.UI.Page
    {

        private LogHelper log = new LogHelper(AppDomain.CurrentDomain.BaseDirectory + "/log/log.txt");

        //心跳接口返回没有签名,不需要传递alipay_rsa_public_key,设置为null,接口不会进行验证签名
        IAlipayMonitor monitorClient = F2FMonitor.CreateClientInstance(Config.monitorUrl, Config.appId, Config.merchant_private_key, Config.version,
                             Config.sign_type, null, Config.charset);

        string result = "";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 提交心跳请求
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Alipay_RSA_Submit(object sender, EventArgs e)
        {

            AlipayMonitorContentBuilder builder = BuildPayContent();

            AlipayF2FMonitorResult monitorResult = monitorClient.mcloudMonitor(builder);

            switch (monitorResult.Status)
            {
                case ResultEnum.SUCCESS:
                    DoSuccessProcess(monitorResult);
                    break;
                case ResultEnum.FAILED:
                    DoFailedProcess(monitorResult);
                    break;
                case ResultEnum.UNKNOWN:
                    result = "配置或网络异常，请检查";
                    break;
            }
            //log.WriteLine(result);
            Response.Redirect("result.aspx?Text=" + result);
        }

        private AlipayMonitorContentBuilder BuildPayContent()
        {

            AlipayMonitorContentBuilder builder = new AlipayMonitorContentBuilder();

            builder.product = "FP";
            builder.type = "CR";
            builder.equipment_id = "1234467";
            //builder.time = "2016-02-15 16:46:02";
            builder.time = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            builder.store_id = "test store id";
            builder.network_type = "LAN";
            builder.equipment_status = "30";
            builder.sys_service_provider_id = "2088511833207846";
            builder.mac = "23-37-47-AF-E8-E3";
            //builer.exception_info = "";
            //builder.discountable_amount = WIDtotal_fee.Text.Trim();
    
            
            //传入交易信息详情
            List<TradeInfo> gList = new List<TradeInfo>();

            TradeInfo trade = new TradeInfo();
            //trade.OTN = "201508011234";
            trade.OTN = WIDout_request_no.Text.Trim();
            trade.TC = "0.123";
            trade.STAT = "S";

            gList.Add(trade);
            builder.trade_info = gList;

            return builder;
            
        }


        /// <summary>
        /// 请添加支付成功后的处理
        /// </summary>
        private void DoSuccessProcess(AlipayF2FMonitorResult payResult)
        {

            //请添加支付成功后的处理
            System.Console.WriteLine("支付成功");
            result = payResult.response.Body;
        }

        private void DoFailedProcess(AlipayF2FMonitorResult payResult)
        {
            //请添加支付失败后的处理
            System.Console.WriteLine("支付失败");
            result = payResult.response.Body;
        }

    }

}
