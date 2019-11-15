using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketMS.UI
{
    public partial class FrmRefundWithAlipay : Form
    {
        public string oid;
        public string roid;
        public string price;

        public FrmRefundWithAlipay()
        {
            InitializeComponent();
        }

        private void FrmRefundWithAlipay_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://localhost:14689/refund.aspx" + "?oid=" + oid + "&roid=" + roid + "&price=" + price);
        }
    }
}