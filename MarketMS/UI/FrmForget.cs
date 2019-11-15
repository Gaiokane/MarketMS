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
    public partial class FrmForget : Form
    {
        public FrmForget()
        {
            InitializeComponent();
        }

        #region 窗口关闭事件
        private void FormForget_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region 窗体加载事件
        private void FrmForget_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage2);

            tabPage1.Text = "找回方式";
            tabPage2.Text = "通过手机号找回";
        }
        #endregion

        #region 找回密码窗口确定按钮事件
        private void btn_WSubmit_Click(object sender, EventArgs e)
        {
            if (radbtn_Tel.Checked)
            {
                tabControl1.TabPages.Add(tabPage2);
                tabControl1.TabPages.Remove(tabPage1);
            }
            else
            {
                MessageBox.Show("请选择找回密码方式！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region 找回密码窗口取消按钮事件
        private void btn_WBack_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }
        #endregion

        #region 通过手机号找回密码窗口确定按钮事件
        private void btn_CSubmit_Click(object sender, EventArgs e)
        {
            if (txtbox_UserName.Text == "")
            {
                MessageBox.Show("请输入用户名！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbox_UserName.Focus();
            }
            else
            {
                if (txtbox_Tel.Text == "")
                {
                    MessageBox.Show("请输入手机号！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbox_Tel.Focus();
                }
                else
                {
                    if (txtbox_NewPasswd.Text == "")
                    {
                        MessageBox.Show("请输入新密码！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtbox_NewPasswd.Focus();
                    }
                    else
                    {
                        if (txtbox_CheckNewPasswd.Text == "")
                        {
                            MessageBox.Show("请输入确认新密码！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtbox_CheckNewPasswd.Focus();
                        }
                        else
                        {
                            if (txtbox_NewPasswd.Text == txtbox_CheckNewPasswd.Text)
                            {
                                if (MessageBox.Show("您确定要找回密码吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                                {
                                    MySqlConnection myconn = BaseClass.DBConn.MyConn();
                                    myconn.Open();
                                    string sql = "select count(*) from tb_Employee where EID=@username";
                                    MySqlCommand mycmd = new MySqlCommand(sql, myconn);
                                    mycmd.Parameters.Add("@username", MySqlDbType.VarChar, 50).Value = txtbox_UserName.Text.Trim();
                                    int n = Convert.ToInt32(mycmd.ExecuteScalar());
                                    if (n == 1)
                                    {
                                        string esql = "select ETel from tb_Employee where ETel='" + txtbox_Tel.Text.Trim() + "'";
                                        DataSet ds = MySqlHelper.ExecuteDataset(myconn, esql);
                                        if (ds.Tables[0].Rows.Count > 0)
                                        {
                                            //修改密码
                                            string csql = "update tb_Employee set EPasswd=@passwd where EID=@username and ETel=@tel";
                                            mycmd = new MySqlCommand(csql, myconn);
                                            mycmd.Parameters.Add("@passwd", MySqlDbType.VarChar, 20).Value = txtbox_NewPasswd.Text.Trim();
                                            mycmd.Parameters.Add("@username", MySqlDbType.VarChar, 50).Value = txtbox_UserName.Text.Trim();
                                            mycmd.Parameters.Add("@tel", MySqlDbType.VarChar, 20).Value = txtbox_Tel.Text.Trim();
                                            int x = mycmd.ExecuteNonQuery();
                                            if (x > 0)
                                            {
                                                MessageBox.Show("密码重置成功！新密码为：'" + txtbox_NewPasswd.Text.Trim() + "'", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                FrmLogin login = new FrmLogin();
                                                login.Show();
                                                this.Hide();
                                            }
                                            else
                                            {
                                                MessageBox.Show("您输入的用户名、手机号不匹配！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                txtbox_UserName.Text = "";
                                                txtbox_Tel.Text = "";
                                                txtbox_NewPasswd.Text = "";
                                                txtbox_CheckNewPasswd.Text = "";
                                                txtbox_UserName.Focus();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("您输入的手机号有误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            txtbox_UserName.Text = "";
                                            txtbox_Tel.Text = "";
                                            txtbox_NewPasswd.Text = "";
                                            txtbox_CheckNewPasswd.Text = "";
                                            txtbox_UserName.Focus();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("该用户不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        txtbox_UserName.Text = "";
                                        txtbox_Tel.Text = "";
                                        txtbox_NewPasswd.Text = "";
                                        txtbox_CheckNewPasswd.Text = "";
                                        txtbox_UserName.Focus();
                                    }
                                    myconn.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("两次新密码输入不一致！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region 通过手机号找回密码窗口取消按钮事件
        private void btn_CBack_Click(object sender, EventArgs e)
        {
            txtbox_UserName.Text = "";
            txtbox_Tel.Text = "";
            txtbox_NewPasswd.Text = "";
            txtbox_CheckNewPasswd.Text = "";
            txtbox_UserName.Focus();

            tabControl1.TabPages.Add(tabPage1);
            tabControl1.TabPages.Remove(tabPage2);
        }
        #endregion

        #region 用户名文本框回车事件
        private void txtbox_UserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtbox_UserName.Text == "")
                {
                    MessageBox.Show("请输入用户名！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    txtbox_Tel.Focus();
                }
            }
        }
        #endregion

        #region 手机号文本框回车事件
        private void txtbox_Tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtbox_Tel.Text == "")
                {
                    MessageBox.Show("请输入手机号！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    txtbox_NewPasswd.Focus();
                }
            }
        }
        #endregion

        #region 新密码文本框回车事件
        private void txtbox_NewPasswd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtbox_NewPasswd.Text == "")
                {
                    MessageBox.Show("请输入新密码！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    txtbox_CheckNewPasswd.Focus();
                }
            }
        }
        #endregion

        #region 确认新密码文本框回车事件
        private void txtbox_CheckNewPasswd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtbox_CheckNewPasswd.Text == "")
                {
                    MessageBox.Show("请输入确认新密码！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    btn_CSubmit_Click(sender, e);
                }
            }
        }
        #endregion
    }
}