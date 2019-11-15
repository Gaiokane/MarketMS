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
    public partial class FrmGoodsCategory : Form
    {
        public ComboBox cmb = new ComboBox();

        public FrmGoodsCategory()
        {
            InitializeComponent();
        }

        #region 刷新treeview内容
        public void tvBindData()
        {
            MySqlConnection myconn = BaseClass.DBConn.MyConn();
            myconn.Open();
            string sql = "select GCName from tb_GoodsCategory";
            MySqlCommand mycmd = new MySqlCommand(sql, myconn);
            MySqlDataReader mysdr = mycmd.ExecuteReader();
            treeView1.Nodes.Clear();
            TreeNode tn = new TreeNode("所有类别", 0, 1);
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
        private void FrmCategory_Load(object sender, EventArgs e)
        {
            tvBindData();
        }
        #endregion

        #region 新建类别按钮事件
        private void btn_NewCategory_Click(object sender, EventArgs e)
        {
            FrmNEGoodsCategory nrc = new FrmNEGoodsCategory();
            nrc.nr = 0;
            nrc.Owner = this;//设置父窗体
            nrc.Show();
        }
        #endregion

        #region 修改按钮事件
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            string gcname = treeView1.SelectedNode.Text;
            if (gcname != "所有类别")
            {
                FrmNEGoodsCategory nrc = new FrmNEGoodsCategory();
                nrc.Owner = this;//设置父窗体
                nrc.nr = 1;
                nrc.gcname = gcname;
                nrc.Show();
            }
            else
            {

                MessageBox.Show("请选择类别！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region 删除类别按钮事件
        private void btn_Del_Click(object sender, EventArgs e)
        {
            string gcname = treeView1.SelectedNode.Text;
            if (gcname != "所有类别")
            {
                MessageBox.Show("类别'" + gcname + "'删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MySqlConnection myconn = BaseClass.DBConn.MyConn();
                myconn.Open();
                string sql = "delete from tb_GoodsCategory where GCName='" + gcname + "'";
                MySqlCommand mycmd = new MySqlCommand(sql, myconn);
                int n = mycmd.ExecuteNonQuery();
                myconn.Close();
                tvBindData();
            }
            else
            {

                MessageBox.Show("请选择类别！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region 节点双击事件
        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            cmb.Text = e.Node.Text;
            this.Close();
        }
        #endregion

        #region 按下ESC键关闭当前窗口
        private void FrmGoodsCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
        #endregion
    }
}