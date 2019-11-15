using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MarketMS.UI
{
    public partial class FrmGoodsSupplier : Form
    {

        public FrmGoodsSupplier()
        {
            InitializeComponent();
        }

        #region datagridview刷新数据
        public void BindData()
        {
            MySqlConnection myconn = BaseClass.DBConn.MyConn();
            myconn.Open();
            string sql = "select GSName as 供应商,GSPName as 负责人, GSTel as 联系电话, GSAddress as 地址, GSNotes as 备注,GSID as GSID from tb_GoodsSupplier order by GSID asc";
            MySqlDataAdapter mysda = new MySqlDataAdapter(sql, myconn);
            DataSet ds = new DataSet();
            mysda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Visible = false;

            myconn.Close();
        }
        #endregion

        #region 窗体加载事件
        private void FrmSupplier_Load(object sender, EventArgs e)
        {
            BindData();
        }
        #endregion

        #region 添加按钮事件
        private void btn_Add_Click(object sender, EventArgs e)
        {
            FrmNEGoodsSupplier nes = new FrmNEGoodsSupplier();
            nes.Owner = this;//设置父窗体
            nes.Show();
        }
        #endregion

        #region 修改按钮事件
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            FrmNEGoodsSupplier nes = new FrmNEGoodsSupplier();
            nes.Owner = this;//设置父窗体
            nes.a = 1;
            nes.gsname = dataGridView1.SelectedCells[0].Value.ToString().Trim();
            nes.gspname = dataGridView1.SelectedCells[1].Value.ToString().Trim();
            nes.gstel = dataGridView1.SelectedCells[2].Value.ToString().Trim();
            nes.gsaddress = dataGridView1.SelectedCells[3].Value.ToString().Trim();
            nes.gsnotes = dataGridView1.SelectedCells[4].Value.ToString().Trim();
            nes.gsid = dataGridView1.SelectedCells[5].Value.ToString().Trim();
            nes.Show();
        }
        #endregion

        #region 删除按钮事件
        private void btn_Del_Click(object sender, EventArgs e)
        {
            MySqlConnection myconn = BaseClass.DBConn.MyConn();
            myconn.Open();
            string sql = "delete from tb_GoodsSupplier where GSID=@gsid";
            MySqlCommand mycmd = new MySqlCommand(sql, myconn);
            mycmd.Parameters.Add("@gsid", MySqlDbType.Int32, 20).Value = dataGridView1.SelectedCells[5].Value.ToString().Trim();

            int n = mycmd.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("供应商'" + dataGridView1.SelectedCells[0].Value.ToString().Trim() + "'删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindData();
            }
        }
        #endregion

        #region datagridview整行双击打开供应商修改窗口事件
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmNEGoodsSupplier nes = new FrmNEGoodsSupplier();
            nes.a = 1;
            nes.gsname = dataGridView1.SelectedCells[0].Value.ToString().Trim();
            nes.gspname = dataGridView1.SelectedCells[1].Value.ToString().Trim();
            nes.gstel = dataGridView1.SelectedCells[2].Value.ToString().Trim();
            nes.gsaddress = dataGridView1.SelectedCells[3].Value.ToString().Trim();
            nes.gsnotes = dataGridView1.SelectedCells[4].Value.ToString().Trim();
            nes.gsid = dataGridView1.SelectedCells[5].Value.ToString().Trim();
            nes.Show();
        }
        #endregion

        #region 按下ESC键关闭当前窗口
        private void FrmGoodsSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
        #endregion
    }
}