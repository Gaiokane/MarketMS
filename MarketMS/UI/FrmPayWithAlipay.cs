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
    public partial class FrmPayWithAlipay : Form
    {
        public string oid;
        public string price;

        public FrmPayWithAlipay()
        {
            InitializeComponent();
        }

        #region 窗体加载事件
        private void FrmPayWithAlipay_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://localhost:14689/precreate.aspx" + "?oid=" + oid + "&price=" + price);
        }
        #endregion
    }
}