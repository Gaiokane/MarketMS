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
    public partial class FrmNEGoodsCategory : Form
    {
        public int nr;
        public string gcid;
        public string gcname;

        public FrmNEGoodsCategory()
        {
            InitializeComponent();
        }

        #region 窗体加载事件
        private void FrmNRCategory_Load(object sender, EventArgs e)
        {
            if (nr == 0)
            {
                //txtbox_CID.Text = "";
                txtbox_GCName.Text = "";
            }
            else if (nr == 1)
            {
                //txtbox_CID.Enabled = false;

                MySqlConnection myconn = BaseClass.DBConn.MyConn();
                myconn.Open();
                string sql = "select * from tb_GoodsCategory where GCName='" + gcname + "'";
                MySqlCommand mycmd = new MySqlCommand(sql, myconn);
                MySqlDataReader mysdr = mycmd.ExecuteReader();
                if (mysdr.Read())
                {
                    gcid = mysdr[0].ToString().Trim();
                }

                myconn.Close();

                txtbox_GCName.Text = gcname;
            }
        }
        #endregion

        #region 确定按钮点击事件
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection myconn = BaseClass.DBConn.MyConn();
            myconn.Open();
            string sql = "select count(*) from tb_GoodsCategory where GCName=@gcname";
            MySqlCommand mycmd = new MySqlCommand(sql, myconn);
            mycmd.Parameters.Add("@gcname", MySqlDbType.VarChar, 20).Value = gcname;
            int n = Convert.ToInt32(mycmd.ExecuteScalar());
            if (n > 0)
            {
                //修改
                sql = "update tb_GoodsCategory set GCName=@gcname where GCID=@gcid";
                mycmd = new MySqlCommand(sql, myconn);
                mycmd.Parameters.Add("@gcname", MySqlDbType.VarChar, 20).Value = txtbox_GCName.Text.Trim();
                mycmd.Parameters.Add("@gcid", MySqlDbType.Int32, 20).Value = Convert.ToInt32(gcid);
                mycmd.ExecuteNonQuery();
                myconn.Close();

                FrmGoodsCategory fgc = (FrmGoodsCategory)this.Owner;//委托父窗体
                fgc.tvBindData();

                MessageBox.Show("类别'" + txtbox_GCName.Text + "'修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                sql = "select count(*) from tb_GoodsCategory where GCName=@gcname";
                mycmd = new MySqlCommand(sql, myconn);
                mycmd.Parameters.Add("@gcname", MySqlDbType.VarChar, 20).Value = txtbox_GCName.Text;
                n = Convert.ToInt32(mycmd.ExecuteScalar());
                if (n > 0)
                {
                    MessageBox.Show("类别'" + txtbox_GCName.Text + "'已存在！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbox_GCName.Focus();
                }
                else
                {
                    //添加
                    sql = "insert into tb_GoodsCategory(GCName) values(@gcname)";
                    mycmd = new MySqlCommand(sql, myconn);
                    mycmd.Parameters.Add("@gcname", MySqlDbType.VarChar, 20).Value = txtbox_GCName.Text.Trim();
                    mycmd.ExecuteNonQuery();
                    myconn.Close();

                    FrmGoodsCategory fgc = (FrmGoodsCategory)this.Owner;//委托父窗体
                    fgc.tvBindData();

                    MessageBox.Show("类别'" + txtbox_GCName.Text + "'添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
        #endregion

        #region 取消按钮点击事件
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 按下ESC键关闭当前窗口
        private void FrmNEGoodsCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
        #endregion
    }
}