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
using System.Net;
using System.IO;

namespace MarketMS.UI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        string c;//存放验证码

        #region 登录按钮事件
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txtbox_UserName.Text == "")
            {
                MessageBox.Show("请输入用户名！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbox_UserName.Focus();
            }
            else
            {
                if (txtbox_Passwd.Text == "")
                {
                    MessageBox.Show("请输入密码！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbox_Passwd.Focus();
                }
                else
                {
                    if (txtbox_Captcha.Text == "")
                    {
                        MessageBox.Show("请输入验证码！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtbox_Captcha.Focus();
                    }
                    else
                    {
                        if (txtbox_Captcha.Text.ToLower() == c.ToLower())
                        {
                            MySqlConnection myconn = BaseClass.DBConn.MyConn();
                            myconn.Open();
                            string mysql = "select * from tb_Employee where EID=@username and EPasswd=@passwd";
                            MySqlCommand mycmd = new MySqlCommand(mysql, myconn);
                            mycmd.Parameters.Add("@username", MySqlDbType.VarChar, 50).Value = txtbox_UserName.Text.Trim();
                            mycmd.Parameters.Add("@passwd", MySqlDbType.VarChar, 20).Value = txtbox_Passwd.Text.Trim();
                            MySqlDataReader mysdr = mycmd.ExecuteReader();
                            mysdr.Read();
                            if (mysdr.HasRows)
                            {
                                string qx = mysdr["EPID"].ToString().Trim();
                                mycmd.Dispose();

                                #region 获取登录用户名、登录时间、局域网IP、公网IP并存入数据库
                                //获取局域网ip（2）
                                IPAddress LoginPublicIP = Dns.Resolve(Dns.GetHostName()).AddressList[0];
                                //获取公网ip
                                string tempip = "0.0.0.0";
                                WebRequest wr = WebRequest.Create("http://www.ipip.net/");
                                Stream s = wr.GetResponse().GetResponseStream();
                                if (s != null)
                                {
                                    StreamReader sr = new StreamReader(s, Encoding.UTF8);
                                    string all = sr.ReadToEnd();
                                    int start = all.IndexOf("IP地址", StringComparison.Ordinal) + 11;
                                    int end = all.IndexOf("<", start, StringComparison.Ordinal);
                                    tempip = all.Substring(start, end - start);
                                    sr.Close();
                                    s.Close();
                                }

                                string sql = "INSERT INTO tb_LoginLog(LoginUserName, LoginTime, LoginPublicIP, LoginLocalIP) VALUES (@LoginUserName, @LoginTime, @LoginPublicIP, @LoginLocalIP)";
                                mycmd = new MySqlCommand(sql, myconn);
                                mycmd.Parameters.Add("@LoginUserName", MySqlDbType.VarChar, 20).Value = txtbox_UserName.Text.Trim();
                                mycmd.Parameters.Add("@LoginTime", MySqlDbType.DateTime).Value = System.DateTime.Now;
                                mycmd.Parameters.Add("@LoginPublicIP", MySqlDbType.VarChar, 20).Value = LoginPublicIP.ToString();
                                mycmd.Parameters.Add("@LoginLocalIP", MySqlDbType.VarChar, 20).Value = tempip;
                                mycmd.ExecuteNonQuery();
                                #endregion

                                FrmMain main = new FrmMain();
                                main.UserName = txtbox_UserName.Text;
                                main.Power = qx;
                                main.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("您输入的用户名或密码错误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning); ShowCaptcha();
                                ShowCaptcha();
                                txtbox_UserName.Text = "";
                                txtbox_Passwd.Text = "";
                                txtbox_Captcha.Text = "";
                                txtbox_UserName.Focus();
                            }
                            mysdr.Close();
                            myconn.Close();
                        }
                        else
                        {
                            MessageBox.Show("您输入的验证码错误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            ShowCaptcha();
                            txtbox_UserName.Text = "";
                            txtbox_Passwd.Text = "";
                            txtbox_Captcha.Text = "";
                            txtbox_UserName.Focus();
                        }
                    }
                }
            }
        }
        #endregion

        #region 重置按钮事件
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txtbox_UserName.Text = "";
            txtbox_Passwd.Text = "";
            txtbox_Captcha.Text = "";
            ShowCaptcha();
        }
        #endregion

        #region 忘记密码按钮事件
        private void linklab_Forget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmForget forget = new FrmForget();
            forget.Show();
            this.Hide();
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
                    txtbox_Passwd.Focus();
                }
            }
        }
        #endregion

        #region 密码文本框回车事件
        private void txtbox_Passwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtbox_Passwd.Text == "")
                {
                    MessageBox.Show("请输入密码！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    txtbox_Captcha.Focus();
                }
            }
        }
        #endregion

        #region 验证码文本框回车事件
        private void txtbox_Captcha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtbox_Captcha.Text == "")
                {
                    MessageBox.Show("请输入验证码！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    btn_Login_Click(sender, e);
                }
            }
        }
        #endregion

        #region 窗体加载事件
        private void FormLogin_Load(object sender, EventArgs e)
        {
            ShowCaptcha();
        }
        #endregion

        #region 窗体关闭事件
        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region 生成验证码
        private string GetCaptcha()
        {
            string[] ch = new string[62];//存放数字和字母
            //设置数字
            for (int i = 0; i < 10; i++)
            {
                ch[i] = i.ToString();
            }
            //设置字母
            for (int i = 10; i < 36; i++)
            {
                ch[i] = ((char)(55 + i)).ToString();
            }
            for (int i = 36; i < ch.Length; i++)
            {
                ch[i] = ((char)(61 + i)).ToString();
            }

            Random r = new Random();
            string captcha = "";
            for (int i = 1; i <= 4; i++)
            {
                int n = r.Next(0, ch.Length);//获取数组的随机下标
                captcha += ch[n];
            }
            return captcha;
        }
        #endregion

        #region 验证码点击刷新事件
        private void picbox_Captcha_Click(object sender, EventArgs e)
        {
            ShowCaptcha();
        }
        #endregion

        #region 显示/刷新验证码
        private void ShowCaptcha()
        {
            //创建一个位图对象
            Bitmap b = new Bitmap(picbox_Captcha.Width, picbox_Captcha.Height);
            //得到此图片上的画布对象
            Graphics g = Graphics.FromImage(b);
            //设置图片的背景颜色
            g.Clear(Color.White);
            c = GetCaptcha();
            g.DrawString(c, new Font("宋体", 12), Brushes.Red, new PointF(10, 2));
            picbox_Captcha.Image = b;
        }
        #endregion

        #region 按下ESC键关闭当前窗口
        private void FrmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
        #endregion
    }
}