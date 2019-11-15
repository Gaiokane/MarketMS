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
    public partial class FrmGoodsSupplierList : Form
    {
        public TextBox txt = new TextBox();

        public FrmGoodsSupplierList()
        {
            InitializeComponent();
        }

        #region 刷新treeview
        private void tvBindData()
        {
            MySqlConnection myconn = BaseClass.DBConn.MyConn();
            myconn.Open();
            string sql = "select GSName from tb_GoodsSupplier";
            MySqlCommand mycmd = new MySqlCommand(sql, myconn);
            MySqlDataReader mysdr = mycmd.ExecuteReader();
            treeView1.Nodes.Clear();
            TreeNode tn = new TreeNode("供应商名称", 0, 1);
            while (mysdr.Read())
            {
                tn.Nodes.Add("", mysdr[0].ToString(), 0, 1);
            }
            treeView1.Nodes.Add(tn);
            treeView1.ExpandAll();
            mysdr.Dispose();
            mycmd.Dispose();
            myconn.Close();
        }
        #endregion

        #region 窗体加载事件
        private void FrmGoodsSupplierList_Load(object sender, EventArgs e)
        {
            tvBindData();
        }
        #endregion

        #region 添加按钮单击事件
        private void button3_Click(object sender, EventArgs e)
        {
            FrmGoodsSupplier fgs = new FrmGoodsSupplier();
            fgs.Show();
        }
        #endregion

        #region 确定按钮单击事件
        private void button1_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Text != "" || treeView1.SelectedNode.Text != "供应商名称")
            {
                txt.Text = treeView1.SelectedNode.Text;
                this.Close();
            }
            else
            {

                MessageBox.Show("请选择供应商！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region 取消按钮单击事件
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 按下ESC键关闭当前窗口
        private void FrmGoodsSupplierList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
        #endregion
    }
}