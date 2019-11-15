using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MarketMS.UI
{
    public partial class UFrmLsjyjl : UserControl
    {
        public UFrmLsjyjl()
        {
            InitializeComponent();
        }

        #region 行号
        private void RowTitle()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (!dataGridView1.Rows[i].IsNewRow)
                {
                    dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
            }
        }
        #endregion

        #region 新增行行号事件
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            RowTitle();
        }
        #endregion

        #region 移除行行号事件
        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            RowTitle();
        }
        #endregion

        #region 查询按钮单击事件
        private void btn_Search_Click(object sender, EventArgs e)
        {
            string ordernum;
            if (radbtn_All.Checked)
            {
                ordernum = "";
                string allsql = "select OID as 订单编号, OGID as 商品编号, OGName as 商品名称, OGCID as 类别, OGAmount as 数量, OGPrice as 单价, OGUnit as 单位, OGSum as 总价, OPaymentMethod as 付款方式 from tb_Order order by OID desc";
                dataGridView1.DataSource = dgBindData(allsql).Tables[0];
                dataGridView1.ClearSelection();
                dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                if (cmbox_OrderNum.SelectedItem != null)
                {
                    ordernum = cmbox_OrderNum.Text.ToString().Trim();
                    string onsql = "select OID as 订单编号, OGID as 商品编号, OGName as 商品名称, OGCID as 类别, OGAmount as 数量, OGPrice as 单价, OGUnit as 单位, OGSum as 总价, OPaymentMethod as 付款方式 from tb_Order where OID='" + ordernum + "' order by OID desc";
                    dataGridView1.DataSource = dgBindData(onsql).Tables[0];
                    dataGridView1.ClearSelection();
                    dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    MessageBox.Show("请选择订单编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbox_OrderNum.SelectedIndex = 0;
                    cmbox_OrderNum.Focus();
                }
            }

        }
        #endregion

        #region 刷新datagridview内容
        private DataSet dgBindData(string sql)
        {
            MySqlConnection myconn = BaseClass.DBConn.MyConn();
            myconn.Open();
            MySqlDataAdapter mysda = new MySqlDataAdapter(sql, myconn);
            DataSet ds = new DataSet();
            ds.Clear();
            mysda.Fill(ds);
            return ds;
        }
        #endregion

        #region 窗体加载事件
        private void UFrmLsjyjl_Load(object sender, EventArgs e)
        {
            MySqlConnection myconn = BaseClass.DBConn.MyConn();
            myconn.Open();
            string sql = "select DISTINCT OID from tb_Order order by OID desc";
            MySqlCommand mycmd = new MySqlCommand(sql, myconn);
            MySqlDataAdapter mysda = new MySqlDataAdapter(mycmd);
            DataTable dt = new DataTable();
            mysda.Fill(dt);
            mysda.Dispose();
            mycmd.Dispose();
            myconn.Close();
            cmbox_OrderNum.DataSource = dt;
            cmbox_OrderNum.DisplayMember = "OID";
            cmbox_OrderNum.ValueMember = "OID";
        }
        #endregion

        #region 点击订单编号下拉框选中对应radiobtn
        private void cmbox_OrderNum_Click(object sender, EventArgs e)
        {
            radbtn_cmbox.Checked = true;
        }
        #endregion
    }
}