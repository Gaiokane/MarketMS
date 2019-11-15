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
    public partial class FrmMain : Form
    {
        public System.Windows.Forms.Panel ActivePanel = new Panel();

        public string UserName;
        public string Power;

        public FrmMain()
        {
            InitializeComponent();

            ActivePanel = panel1;
        }

        #region 时间计时器控件
        private void timer1_Tick(object sender, EventArgs e)
        {
            tslab_time.Text = "当前时间：" + System.DateTime.Now.ToString();
        }
        #endregion

        #region 当前库存不足计时器控件
        private void timer2_Tick(object sender, EventArgs e)
        {
            int amount;
            lock (this)
            {
                amount = isqh();
                if (amount == 0)
                {
                    tslab_kucunbuzu.Visible = false;
                }
                else
                {
                    tslab_kucunbuzu.Visible = true;
                }
            }
        }
        #endregion

        #region 判断库存是否充足
        private int isqh()
        {
            MySqlConnection myconn = BaseClass.DBConn.MyConn();
            myconn.Open();
            string sql = "select count(*) from tb_Goods where GAmount <= GMinimumInventory";
            MySqlCommand mycmd = new MySqlCommand(sql, myconn);
            object o = mycmd.ExecuteScalar();
            mycmd.Dispose();
            myconn.Close();
            return Convert.ToInt32(o);
        }
        #endregion

        #region 窗体加载事件
        private void FrmMain_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();

            statusStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            tslab_user.Text = UserName;

            MySqlConnection myconn = BaseClass.DBConn.MyConn();
            myconn.Open();
            string sql = "select * from tb_EmployeePosition where EPID=@epid";
            MySqlCommand mycmd = new MySqlCommand(sql, myconn);
            mycmd.Parameters.Add("@epid", MySqlDbType.Int32, 20).Value = Power;
            MySqlDataReader mysdr = mycmd.ExecuteReader();
            mysdr.Read();
            if (mysdr.HasRows)
            {
                tslab_power.Text = mysdr[1].ToString().Trim();
            }
            myconn.Close();

            /*switch (Power)
            {
                case "0001": tslab_power.Text = "系统管理员"; break;
                case "0002": tslab_power.Text = "店长"; break;
                case "0003": tslab_power.Text = "人事部"; break;
                case "0004": tslab_power.Text = "库存"; break;
                case "0005": tslab_power.Text = "售货员"; break;
            }*/

            tslab_kucunbuzu.Alignment = ToolStripItemAlignment.Right;
            toolStripStatusLabel4.Alignment = ToolStripItemAlignment.Right;
            tslab_time.Alignment = ToolStripItemAlignment.Right;

            tslab_time.Text = "";
            //toolStripStatusLabel4.Visible = false;
            //tslab_kucunbuzu.Visible = false;
        }
        #endregion

        #region 窗体关闭事件
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region 右侧菜单调整大小
        private void splitContainer1_Panel2_Resize(object sender, EventArgs e)
        {
            for (int i = 0; i < ActivePanel.Controls.Count; i++)
            {
                ActivePanel.Controls[i].Left = (ActivePanel.Width - ActivePanel.Controls[i].Width) / 2;
            }
        }
        #endregion

        #region 右侧 销售管理 按钮单击事件
        private void btn_xsgl_Click(object sender, EventArgs e)
        {
            if (ActivePanel.Name == panel1.Name)
                return;
            ActivePanel = panel1;

            btn_xsgl.SendToBack();
            btn_xsgl.Dock = DockStyle.Top;

            btn_spgl.SendToBack();
            btn_spgl.Dock = DockStyle.Bottom;
            btn_tjcx.SendToBack();
            btn_tjcx.Dock = DockStyle.Bottom;
            btn_rsgl.SendToBack();
            btn_rsgl.Dock = DockStyle.Bottom;
            btn_xtgl.SendToBack();
            btn_xtgl.Dock = DockStyle.Bottom;

            panel2.SendToBack();
            panel3.SendToBack();
            panel4.SendToBack();
            panel5.SendToBack();
            panel1.BringToFront();
            panel1.Dock = DockStyle.Fill;

            splitContainer1_Panel2_Resize(this, e);
        }
        #endregion

        #region 右侧 商品管理 按钮单击事件
        private void btn_spgl_Click(object sender, EventArgs e)
        {
            if (ActivePanel.Name == panel2.Name)
                return;
            ActivePanel = panel2;

            btn_spgl.Dock = DockStyle.Top;
            btn_xsgl.SendToBack();
            btn_xsgl.Dock = DockStyle.Top;

            btn_tjcx.SendToBack();
            btn_tjcx.Dock = DockStyle.Bottom;
            btn_rsgl.SendToBack();
            btn_rsgl.Dock = DockStyle.Bottom;
            btn_xtgl.SendToBack();
            btn_xtgl.Dock = DockStyle.Bottom;

            panel1.SendToBack();
            panel3.SendToBack();
            panel4.SendToBack();
            panel5.SendToBack();
            panel2.BringToFront();
            panel2.Dock = DockStyle.Fill;

            splitContainer1_Panel2_Resize(this, e);
        }
        #endregion

        #region 右侧 统计查询 按钮单击事件
        private void btn_tjcx_Click(object sender, EventArgs e)
        {
            if (ActivePanel.Name == panel3.Name)
                return;
            ActivePanel = panel3;

            btn_tjcx.Dock = DockStyle.Top;
            btn_spgl.SendToBack();
            btn_spgl.Dock = DockStyle.Top;
            btn_xsgl.SendToBack();
            btn_xsgl.Dock = DockStyle.Top;

            btn_rsgl.SendToBack();
            btn_rsgl.Dock = DockStyle.Bottom;
            btn_xtgl.SendToBack();
            btn_xtgl.Dock = DockStyle.Bottom;

            panel1.SendToBack();
            panel2.SendToBack();
            panel4.SendToBack();
            panel5.SendToBack();
            panel3.BringToFront();
            panel3.Dock = DockStyle.Fill;

            splitContainer1_Panel2_Resize(this, e);
        }
        #endregion

        #region 右侧 人事管理 按钮单击事件
        private void btn_rsgl_Click(object sender, EventArgs e)
        {
            if (ActivePanel.Name == panel4.Name)
                return;
            ActivePanel = panel4;

            btn_rsgl.Dock = DockStyle.Top;
            btn_tjcx.SendToBack();
            btn_tjcx.Dock = DockStyle.Top;
            btn_spgl.SendToBack();
            btn_spgl.Dock = DockStyle.Top;
            btn_xsgl.SendToBack();
            btn_xsgl.Dock = DockStyle.Top;

            btn_xtgl.Dock = DockStyle.Bottom;

            panel1.SendToBack();
            panel2.SendToBack();
            panel3.SendToBack();
            panel5.SendToBack();
            panel4.BringToFront();
            panel4.Dock = DockStyle.Fill;

            splitContainer1_Panel2_Resize(this, e);
        }
        #endregion

        #region 右侧 系统管理 按钮单击事件
        private void btn_xtgl_Click(object sender, EventArgs e)
        {
            if (ActivePanel.Name == panel5.Name)
                return;
            ActivePanel = panel5;

            btn_xtgl.Dock = DockStyle.Top;
            btn_rsgl.SendToBack();
            btn_rsgl.Dock = DockStyle.Top;
            btn_tjcx.SendToBack();
            btn_tjcx.Dock = DockStyle.Top;
            btn_spgl.SendToBack();
            btn_spgl.Dock = DockStyle.Top;
            btn_xsgl.SendToBack();
            btn_xsgl.Dock = DockStyle.Top;

            panel1.SendToBack();
            panel2.SendToBack();
            panel3.SendToBack();
            panel4.SendToBack();
            panel5.BringToFront();
            panel5.Dock = DockStyle.Fill;

            splitContainer1_Panel2_Resize(this, e);
        }
        #endregion

        #region 右侧 销售管理-收银台 按钮单击事件
        public void btn_syt_Click(object sender, EventArgs e)
        {
            if (Power == "1" || Power == "2" || Power == "6")
            {
                UFrmSyt syt = new UFrmSyt();
                syt.oeid = UserName;
                syt.Size = new System.Drawing.Size(splitContainer1.Panel1.Width, splitContainer1.Panel1.Height);
                splitContainer1.Panel1.Controls.Clear();
                splitContainer1.Panel1.Controls.Add(syt);
            }
            else
            {
                MessageBox.Show("您没有权限访问！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region 右侧 销售管理-顾客退货 按钮单击事件
        private void btn_gkth_Click(object sender, EventArgs e)
        {
            if (Power == "1" || Power == "2" || Power == "6")
            {
                UFrmGkth ufg = new UFrmGkth();
                ufg.Size = new System.Drawing.Size(splitContainer1.Panel1.Width, splitContainer1.Panel1.Height);
                splitContainer1.Panel1.Controls.Clear();
                splitContainer1.Panel1.Controls.Add(ufg);
            }
            else
            {
                MessageBox.Show("您没有权限访问！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region 右侧 销售管理-历史交易记录 按钮单击事件
        private void btn_lsjyjl_Click(object sender, EventArgs e)
        {
            if (Power == "1" || Power == "2" || Power == "6")
            {
                UFrmLsjyjl lsjyjl = new UFrmLsjyjl();
                lsjyjl.Size = new System.Drawing.Size(splitContainer1.Panel1.Width, splitContainer1.Panel1.Height);
                splitContainer1.Panel1.Controls.Clear();
                splitContainer1.Panel1.Controls.Add(lsjyjl);
            }
            else
            {
                MessageBox.Show("您没有权限访问！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region 右侧 商品管理-商品信息 按钮单击事件
        private void btn_spxx_Click(object sender, EventArgs e)
        {
            if (Power == "1" || Power == "2" || Power == "5")
            {
                UFrmSpxx ufs = new UFrmSpxx();
                splitContainer1.Panel1.Controls.Clear();
                splitContainer1.Panel1.Controls.Add(ufs);
            }
            else
            {
                MessageBox.Show("您没有权限访问！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region 右侧 人事管理-员工信息管理 按钮单击事件
        private void btn_ygxxgl_Click(object sender, EventArgs e)
        {
            if (Power == "1" || Power == "2" || Power == "3")
            {
                UFrmYgxxgl ygxxgl = new UFrmYgxxgl();
                ygxxgl.LN = UserName;
                splitContainer1.Panel1.Controls.Clear();
                splitContainer1.Panel1.Controls.Add(ygxxgl);
            }
            else
            {
                MessageBox.Show("您没有权限访问！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region 右侧 系统管理-重新登录 按钮单击事件
        private void btn_cxdl_Click(object sender, EventArgs e)
        {
            FrmLogin fl = new FrmLogin();
            fl.Show();
            this.Hide();
        }
        #endregion

        #region 右侧 系统管理-返回主界面 按钮单击事件
        private void btn_fhzjm_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1.Controls.Clear();
        }
        #endregion

        #region 右侧 系统管理-退出系统 按钮单击事件
        private void btn_tcxt_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("您确定要退出系统吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        #endregion

        #region 右侧 商品管理-采购进货 按钮单击事件
        private void btn_cgjh_Click(object sender, EventArgs e)
        {
            if (Power == "1" || Power == "2" || Power == "5")
            {
                UFrmCgjh cgjh = new UFrmCgjh();
                splitContainer1.Panel1.Controls.Clear();
                splitContainer1.Panel1.Controls.Add(cgjh);
            }
            else
            {
                MessageBox.Show("您没有权限访问！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region 右侧 商品管理-当前库存 按钮单击事件
        private void btn_dqkc_Click(object sender, EventArgs e)
        {
            if (Power == "1" || Power == "2" || Power == "5")
            {
                UFrmDqkc dqkc = new UFrmDqkc();
                splitContainer1.Panel1.Controls.Clear();
                splitContainer1.Panel1.Controls.Add(dqkc);
            }
            else
            {
                MessageBox.Show("您没有权限访问！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region 右侧 统计查询-销售排行 按钮单击事件
        private void btn_xsph_Click(object sender, EventArgs e)
        {
            if (Power == "1" || Power == "2" || Power == "4")
            {
                UFrmXsph xsph = new UFrmXsph();
                xsph.Size = new System.Drawing.Size(splitContainer1.Panel1.Width, splitContainer1.Panel1.Height);
                splitContainer1.Panel1.Controls.Clear();
                splitContainer1.Panel1.Controls.Add(xsph);
            }
            else
            {
                MessageBox.Show("您没有权限访问！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region 当前库存不足单击事件
        private void tslab_kucunbuzu_Click(object sender, EventArgs e)
        {
            if (Power == "1" || Power == "2" || Power == "5")
            {
                UFrmDqkc dqkc = new UFrmDqkc();
                splitContainer1.Panel1.Controls.Clear();
                splitContainer1.Panel1.Controls.Add(dqkc);
            }
            else
            {
                MessageBox.Show("您没有权限访问！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}