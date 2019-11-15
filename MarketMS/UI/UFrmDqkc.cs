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
    public partial class UFrmDqkc : UserControl
    {
        string pobh = "PO" + DateTime.Now.ToString("yyyyMMddhhmmss");

        public UFrmDqkc()
        {
            InitializeComponent();
        }

        #region 刷新datagridview内容
        public void dgBindData()
        {
            int n = 0;
            dataGridView1.Columns.Clear();
            MySqlConnection myconn = BaseClass.DBConn.MyConn();
            myconn.Open();
            string sql = "select GID as 商品编号, GName as 商品名称, GCID as 类别, GPrice as 售价, GBid as 进价, GAmount as 库存数量, GMinimumInventory as 最小库存, GSupplier as 供应商, ID as ID from tb_Goods where GAmount <= GMinimumInventory";

            MySqlDataAdapter mysda = new MySqlDataAdapter(sql, myconn);
            DataSet ds = new DataSet();
            ds.Clear();
            mysda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            //dataGridView1.ClearSelection();

            dataGridView1.Columns[8].Visible = false;

            MySqlCommand mycmd = new MySqlCommand(sql, myconn);
            MySqlDataReader mysdr = mycmd.ExecuteReader();
            while (mysdr.Read())
            {
                n++;
            }
            mysdr.Dispose();
            for (int i = 0; i < n; i++)
            {
                string ssql = "select * from tb_Goods where ID = '" + dataGridView1.Rows[i].Cells[8].Value.ToString().Trim() + "'";
                MySqlCommand smycmd = new MySqlCommand(ssql, myconn);
                mysdr = smycmd.ExecuteReader();
                mysdr.Read();
                if (mysdr.HasRows)
                {
                    int gcid = Convert.ToInt32(mysdr["GCID"].ToString().Trim());
                    mysdr.Dispose();
                    string gcsql = "select GCID, GCName from tb_GoodsCategory where GCID='" + gcid + "'";
                    MySqlCommand gcmycmd = new MySqlCommand(gcsql, myconn);
                    MySqlDataReader gcmysdr = gcmycmd.ExecuteReader();
                    gcmysdr.Read();
                    if (gcmysdr.HasRows)
                    {
                        if (gcid == Convert.ToInt32(gcmysdr["GCID"].ToString().Trim()))
                        {
                            dataGridView1.Rows[i].Cells[2].Value = gcmysdr["GCName"].ToString().Trim();
                        }
                    }
                    gcmysdr.Dispose();
                    gcmycmd.Dispose();
                }
                mysdr.Dispose();
                smycmd.Dispose();
            }
            mycmd.Dispose();
            mysda.Dispose();
            myconn.Close();
        }
        #endregion

        #region 窗体加载事件
        private void UFrmDqkc_Load(object sender, EventArgs e)
        {
            dgBindData();
            timer1.Start();
            timer1.Interval = 10;
        }
        #endregion

        #region 刷新库存按钮单击事件
        private void btn_RefreshStock_Click(object sender, EventArgs e)
        {
            dgBindData();
        }
        #endregion

        #region 补货按钮单击事件
        private void btn_Replenishment_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                FrmNEPurchaseOrder fnepo = new FrmNEPurchaseOrder();
                fnepo.po = 1;
                //fnepo.pogid = pobh;
                fnepo.pogname = dataGridView1.SelectedCells[1].Value.ToString().Trim();
                fnepo.pogcid = dataGridView1.SelectedCells[2].Value.ToString().Trim();
                fnepo.pogprice = dataGridView1.SelectedCells[3].Value.ToString().Trim();
                fnepo.pogbid = dataGridView1.SelectedCells[4].Value.ToString().Trim();
                fnepo.pogminimuminventory = dataGridView1.SelectedCells[6].Value.ToString().Trim();
                fnepo.pogsupplier = dataGridView1.SelectedCells[7].Value.ToString().Trim();

                fnepo.podate = DateTime.Now.ToString();
                fnepo.pogshelflife = "个月";
                fnepo.pogproductiondate = DateTime.Now.ToString();
                fnepo.Show();
            }
            else
            {
                MessageBox.Show("暂时没有缺货商品！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgBindData();
            }
        }
        #endregion

        #region label滚动效果
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Location == new Point(893, label1.Location.Y))
            {
                label1.Location = new Point(-281, label1.Location.Y);
            }
            label1.Location = new Point(label1.Location.X + 1, label1.Location.Y);
        }
        #endregion
    }
}