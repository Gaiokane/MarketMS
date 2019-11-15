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
    public partial class UFrmXsph : UserControl
    {
        public UFrmXsph()
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

        #region 窗体加载事件
        private void UFrmXsph_Load(object sender, EventArgs e)
        {
            MySqlConnection myconn = BaseClass.DBConn.MyConn();
            myconn.Open();
            string sql = "select EID from tb_Employee where EPID=6";
            MySqlCommand mycmd = new MySqlCommand(sql, myconn);
            MySqlDataAdapter mysda = new MySqlDataAdapter(mycmd);
            DataTable dt = new DataTable();
            mysda.Fill(dt);
            mysda.Dispose();
            mycmd.Dispose();
            myconn.Close();
            cmbox_EID.DataSource = dt;
            cmbox_EID.DisplayMember = "EID";
            cmbox_EID.ValueMember = "EID";
        }
        #endregion

        #region 查询按钮单击事件
        private void btn_Search_Click(object sender, EventArgs e)
        {
            MySqlConnection myconn = BaseClass.DBConn.MyConn();
            myconn.Open();
            string sql = "select OGID as 商品编号, OGName as 商品名称, OGCID as 类别, OGAmount as 数量, OGPrice as 单价, OGUnit as 单位, OGSum as 总价 from tb_Order where OEID='" + cmbox_EID.Text + "'";
            MySqlDataAdapter mysda = new MySqlDataAdapter(sql, myconn);
            DataSet ds = new DataSet();
            ds.Clear();
            mysda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.ClearSelection();
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        #endregion
    }
}