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
using System.IO;

namespace MarketMS.UI
{
    public partial class UFrmYgxxgl : UserControl
    {
        MySqlConnection myconn = BaseClass.DBConn.MyConn();
        MySqlCommand mycmd;
        MySqlDataReader mysdr;
        string sql;
        public string LN;

        public UFrmYgxxgl()
        {
            InitializeComponent();
        }

        #region 员工信息管理窗体加载事件
        private void UFrmYgxxgl_Load(object sender, EventArgs e)
        {
            cmbox_cxtj.SelectedIndex = 0;

            tsbtn_Save.Enabled = false;
            tsbtn_Cancel.Enabled = false;

            txtbox_LoginName.Enabled = false;
            txtbox_Name.Enabled = false;
            cmbox_Sex.Enabled = false;
            txtbox_Age.Enabled = false;
            cmbox_Position.Enabled = false;
            txtbox_Tel.Enabled = false;
            txtbox_Passwd.Enabled = false;
            txtbox_Address.Enabled = false;
        }
        #endregion

        #region 查询条件-查询按钮事件
        private void btn_Search_Click(object sender, EventArgs e)
        {
            #region 按用户名查找
            if (cmbox_cxtj.Text == "按用户名查找")
            {
                cxtj_ayhmcz();

                /*dataGridView1.Columns.Clear();

                if (txtbox_cxtjLN.Text == "")
                {
                    MessageBox.Show("请输入用户名！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbox_cxtjLN.Focus();
                }
                else
                {
                    myconn.Open();
                    sql = "select * from tb_Employee where EID='" + txtbox_cxtjLN.Text + "'";
                    MySqlCommand mycmd = new MySqlCommand(sql, myconn);
                    int n = Convert.ToInt32(mycmd.ExecuteScalar());
                    if (n > 0)
                    {
                        MySqlDataReader mysdr = mycmd.ExecuteReader();
                        mysdr.Read();
                        if (mysdr.HasRows)
                        {
                            lab_ID.Text = mysdr[0].ToString().Trim();
                            txtbox_LoginName.Text = mysdr[1].ToString().Trim();
                            txtbox_Name.Text = mysdr[2].ToString().Trim();
                            if (mysdr[3].ToString().Trim() == "男")
                            {
                                cmbox_Sex.SelectedIndex = 0;
                            }
                            if (mysdr[3].ToString().Trim() == "女")
                            {
                                cmbox_Sex.SelectedIndex = 1;
                            }
                            txtbox_Age.Text = mysdr[4].ToString().Trim();
                            if (mysdr[5].ToString().Trim() == "1")
                            {
                                cmbox_Position.SelectedIndex = 0;
                            }
                            if (mysdr[5].ToString().Trim() == "2")
                            {
                                cmbox_Position.SelectedIndex = 1;
                            }
                            if (mysdr[5].ToString().Trim() == "3")
                            {
                                cmbox_Position.SelectedIndex = 2;
                            }
                            if (mysdr[5].ToString().Trim() == "4")
                            {
                                cmbox_Position.SelectedIndex = 3;
                            }
                            if (mysdr[5].ToString().Trim() == "5")
                            {
                                cmbox_Position.SelectedIndex = 4;
                            }
                            if (mysdr[5].ToString().Trim() == "6")
                            {
                                cmbox_Position.SelectedIndex = 5;
                            }
                            txtbox_Tel.Text = mysdr[6].ToString().Trim();
                            txtbox_Passwd.Text = mysdr[7].ToString().Trim();
                            txtbox_Address.Text = mysdr[8].ToString().Trim();
                        }
                        mysdr.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("您查询的用户名不存在！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    mycmd.Dispose();
                    myconn.Close();
                }*/
            }
            #endregion

            #region 按姓名查找
            if (cmbox_cxtj.Text == "按姓名查找")
            {
                cxtj_axmcz();

                /*dataGridView1.Columns.Clear();

                if (txtbox_cxtjLN.Text == "")
                {
                    MessageBox.Show("请输入姓名！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbox_cxtjLN.Focus();
                }
                else
                {
                    myconn.Open();
                    sql = "select * from tb_Employee where EName='" + txtbox_cxtjLN.Text + "'";
                    MySqlCommand mycmd = new MySqlCommand(sql, myconn);
                    int n = Convert.ToInt32(mycmd.ExecuteScalar());
                    if (n > 0)
                    {
                        MySqlDataReader mysdr = mycmd.ExecuteReader();
                        mysdr.Read();
                        if (mysdr.HasRows)
                        {
                            lab_ID.Text = mysdr[0].ToString().Trim();
                            txtbox_LoginName.Text = mysdr[1].ToString().Trim();
                            txtbox_Name.Text = mysdr[2].ToString().Trim();
                            if (mysdr[3].ToString().Trim() == "男")
                            {
                                cmbox_Sex.SelectedIndex = 0;
                            }
                            if (mysdr[3].ToString().Trim() == "女")
                            {
                                cmbox_Sex.SelectedIndex = 1;
                            }
                            txtbox_Age.Text = mysdr[4].ToString().Trim();
                            if (mysdr[5].ToString().Trim() == "1")
                            {
                                cmbox_Position.SelectedIndex = 0;
                            }
                            if (mysdr[5].ToString().Trim() == "2")
                            {
                                cmbox_Position.SelectedIndex = 1;
                            }
                            if (mysdr[5].ToString().Trim() == "3")
                            {
                                cmbox_Position.SelectedIndex = 2;
                            }
                            if (mysdr[5].ToString().Trim() == "4")
                            {
                                cmbox_Position.SelectedIndex = 3;
                            }
                            if (mysdr[5].ToString().Trim() == "5")
                            {
                                cmbox_Position.SelectedIndex = 4;
                            }
                            if (mysdr[5].ToString().Trim() == "6")
                            {
                                cmbox_Position.SelectedIndex = 5;
                            }
                            txtbox_Tel.Text = mysdr[6].ToString().Trim();
                            txtbox_Passwd.Text = mysdr[7].ToString().Trim();
                            txtbox_Address.Text = mysdr[8].ToString().Trim();
                        }
                        mysdr.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("您查询的姓名不存在！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    mycmd.Dispose();
                    myconn.Close();
                }*/
            }
            #endregion

            #region 按职位查找old
            /*if (cmbox_cxtj.Text == "按职位查找")
            {
                int p, n;

                #region 按职位查找-系统管理员
                if (cmbox_cxtjPS.Text == "系统管理员")
                {
                    p = 1;
                    n = 0;
                    myconn.Open();
                    sql = "select * from tb_Employee where EPID='" + p + "'";
                    MySqlDataAdapter mysda = new MySqlDataAdapter(sql, myconn);
                    DataSet ds = new DataSet();
                    mysda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    mycmd = new MySqlCommand(sql, myconn);
                    mysdr = mycmd.ExecuteReader();
                    while (mysdr.Read())
                    {
                        n++;
                    }
                    for (int i = 0; i < n; i++)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = "系统管理员";
                    }
                    mysda.Dispose();
                    mycmd.Dispose();
                    mysdr.Dispose();
                    ds.Dispose();
                    myconn.Close();
                }
                #endregion
                #region 按职位查找-店长
                if (cmbox_cxtjPS.Text == "店长")
                {
                    p = 2;
                    n = 0;
                    myconn.Open();
                    sql = "select * from tb_Employee where EPID='" + p + "'";
                    MySqlDataAdapter mysda = new MySqlDataAdapter(sql, myconn);
                    DataSet ds = new DataSet();
                    mysda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    mycmd = new MySqlCommand(sql, myconn);
                    mysdr = mycmd.ExecuteReader();
                    while (mysdr.Read())
                    {
                        n++;
                    }
                    for (int i = 0; i < n; i++)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = "店长";
                    }
                    mysda.Dispose();
                    mycmd.Dispose();
                    mysdr.Dispose();
                    ds.Dispose();
                    myconn.Close();
                }
                #endregion
                #region 按职位查找-人事部
                if (cmbox_cxtjPS.Text == "人事部")
                {
                    p = 3;
                    n = 0;
                    myconn.Open();
                    sql = "select * from tb_Employee where EPID='" + p + "'";
                    MySqlDataAdapter mysda = new MySqlDataAdapter(sql, myconn);
                    DataSet ds = new DataSet();
                    mysda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    mycmd = new MySqlCommand(sql, myconn);
                    mysdr = mycmd.ExecuteReader();
                    while (mysdr.Read())
                    {
                        n++;
                    }
                    for (int i = 0; i < n; i++)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = "人事部";
                    }
                    mysda.Dispose();
                    mycmd.Dispose();
                    mysdr.Dispose();
                    ds.Dispose();
                    myconn.Close();
                }
                #endregion
                #region 按职位查找-销售部
                if (cmbox_cxtjPS.Text == "销售部")
                {
                    p = 4;
                    n = 0;
                    myconn.Open();
                    sql = "select * from tb_Employee where EPID='" + p + "'";
                    MySqlDataAdapter mysda = new MySqlDataAdapter(sql, myconn);
                    DataSet ds = new DataSet();
                    mysda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    mycmd = new MySqlCommand(sql, myconn);
                    mysdr = mycmd.ExecuteReader();
                    while (mysdr.Read())
                    {
                        n++;
                    }
                    for (int i = 0; i < n; i++)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = "销售部";
                    }
                    mysda.Dispose();
                    mycmd.Dispose();
                    mysdr.Dispose();
                    ds.Dispose();
                    myconn.Close();
                }
                #endregion
                #region 按职位查找-库存管理部
                if (cmbox_cxtjPS.Text == "库存管理部")
                {
                    p = 5;
                    n = 0;
                    myconn.Open();
                    sql = "select * from tb_Employee where EPID='" + p + "'";
                    MySqlDataAdapter mysda = new MySqlDataAdapter(sql, myconn);
                    DataSet ds = new DataSet();
                    mysda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    mycmd = new MySqlCommand(sql, myconn);
                    mysdr = mycmd.ExecuteReader();
                    while (mysdr.Read())
                    {
                        n++;
                    }
                    for (int i = 0; i < n; i++)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = "库存管理部";
                    }
                    mysda.Dispose();
                    mycmd.Dispose();
                    mysdr.Dispose();
                    ds.Dispose();
                    myconn.Close();
                }
                #endregion
                #region 按职位查找-销售员
                if (cmbox_cxtjPS.Text == "销售员")
                {//0ID，1姓名，2性别，3年龄，4职位，5年龄，6EPID，7密码，8住址，9ID
                    p = 6;
                    n = 0;
                    myconn.Open();
                    sql = "select * from tb_Employee where EPID='" + p + "'";
                    MySqlDataAdapter mysda = new MySqlDataAdapter(sql, myconn);
                    DataSet ds = new DataSet();
                    mysda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    mycmd = new MySqlCommand(sql, myconn);
                    mysdr = mycmd.ExecuteReader();
                    while (mysdr.Read())
                    {
                        n++;
                    }
                    for (int i = 0; i < n; i++)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = "销售员";
                    }
                    mysda.Dispose();
                    mycmd.Dispose();
                    mysdr.Dispose();
                    ds.Dispose();
                    myconn.Close();
                }
                #endregion
            }*/
            #endregion

            #region 按职位查找
            if (cmbox_cxtj.Text == "按职位查找")
            {
                cxtj_azwcz();

                /*dataGridView1.Columns.Clear();

                int p, n;

                #region 按职位查找-系统管理员
                if (cmbox_cxtjPS.Text == "系统管理员")
                {
                    p = 1;
                    n = 0;
                    myconn.Open();
                    sql = "select EID as 用户名, EName as 姓名, ESex as 性别, EAge as 年龄, EPID as 职位, ETel as 手机, EPasswd as 密码, EAddress as 住址, ID as ID from tb_Employee where EPID='" + p + "'";
                    MySqlDataAdapter mysda = new MySqlDataAdapter(sql, myconn);
                    DataSet ds = new DataSet();
                    ds.Clear();
                    mysda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];

                    dataGridView1.Columns[8].Visible = false;

                    mycmd = new MySqlCommand(sql, myconn);
                    mysdr = mycmd.ExecuteReader();
                    while (mysdr.Read())
                    {
                        n++;
                    }
                    for (int i = 0; i < n; i++)
                    {
                        dataGridView1.Columns[7].Width = 204;
                        dataGridView1.Rows[i].Cells[4].Value = "系统管理员";
                    }
                    mysda.Dispose();
                    mycmd.Dispose();
                    mysdr.Dispose();
                    ds.Dispose();
                    myconn.Close();
                }
                #endregion
                #region 按职位查找-店长
                if (cmbox_cxtjPS.Text == "店长")
                {
                    p = 2;
                    n = 0;
                    myconn.Open();
                    sql = "select EID as 用户名, EName as 姓名, ESex as 性别, EAge as 年龄, EPID as 职位, ETel as 手机, EPasswd as 密码, EAddress as 住址, ID as ID from tb_Employee where EPID='" + p + "'";
                    MySqlDataAdapter mysda = new MySqlDataAdapter(sql, myconn);
                    DataSet ds = new DataSet();
                    ds.Clear();
                    mysda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];

                    dataGridView1.Columns[8].Visible = false;

                    mycmd = new MySqlCommand(sql, myconn);
                    mysdr = mycmd.ExecuteReader();
                    while (mysdr.Read())
                    {
                        n++;
                    }
                    for (int i = 0; i < n; i++)
                    {
                        dataGridView1.Columns[7].Width = 204;
                        dataGridView1.Rows[i].Cells[4].Value = "店长";
                    }
                    mysda.Dispose();
                    mycmd.Dispose();
                    mysdr.Dispose();
                    ds.Dispose();
                    myconn.Close();
                }
                #endregion
                #region 按职位查找-人事部
                if (cmbox_cxtjPS.Text == "人事部")
                {
                    p = 3;
                    n = 0;
                    myconn.Open();
                    sql = "select EID as 用户名, EName as 姓名, ESex as 性别, EAge as 年龄, EPID as 职位, ETel as 手机, EPasswd as 密码, EAddress as 住址, ID as ID from tb_Employee where EPID='" + p + "'";
                    MySqlDataAdapter mysda = new MySqlDataAdapter(sql, myconn);
                    DataSet ds = new DataSet();
                    ds.Clear();
                    mysda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];

                    dataGridView1.Columns[8].Visible = false;

                    mycmd = new MySqlCommand(sql, myconn);
                    mysdr = mycmd.ExecuteReader();
                    while (mysdr.Read())
                    {
                        n++;
                    }
                    for (int i = 0; i < n; i++)
                    {
                        dataGridView1.Columns[7].Width = 204;
                        dataGridView1.Rows[i].Cells[4].Value = "人事部";
                    }
                    mysda.Dispose();
                    mycmd.Dispose();
                    mysdr.Dispose();
                    ds.Dispose();
                    myconn.Close();
                }
                #endregion
                #region 按职位查找-销售部
                if (cmbox_cxtjPS.Text == "销售部")
                {
                    p = 4;
                    n = 0;
                    myconn.Open();
                    sql = "select EID as 用户名, EName as 姓名, ESex as 性别, EAge as 年龄, EPID as 职位, ETel as 手机, EPasswd as 密码, EAddress as 住址, ID as ID from tb_Employee where EPID='" + p + "'";
                    MySqlDataAdapter mysda = new MySqlDataAdapter(sql, myconn);
                    DataSet ds = new DataSet();
                    ds.Clear();
                    mysda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];

                    dataGridView1.Columns[8].Visible = false;

                    mycmd = new MySqlCommand(sql, myconn);
                    mysdr = mycmd.ExecuteReader();
                    while (mysdr.Read())
                    {
                        n++;
                    }
                    for (int i = 0; i < n; i++)
                    {
                        dataGridView1.Columns[7].Width = 204;
                        dataGridView1.Rows[i].Cells[4].Value = "销售部";
                    }
                    mysda.Dispose();
                    mycmd.Dispose();
                    mysdr.Dispose();
                    ds.Dispose();
                    myconn.Close();
                }
                #endregion
                #region 按职位查找-库存管理部
                if (cmbox_cxtjPS.Text == "库存管理部")
                {
                    p = 5;
                    n = 0;
                    myconn.Open();
                    sql = "select EID as 用户名, EName as 姓名, ESex as 性别, EAge as 年龄, EPID as 职位, ETel as 手机, EPasswd as 密码, EAddress as 住址, ID as ID from tb_Employee where EPID='" + p + "'";
                    MySqlDataAdapter mysda = new MySqlDataAdapter(sql, myconn);
                    DataSet ds = new DataSet();
                    ds.Clear();
                    mysda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];

                    dataGridView1.Columns[8].Visible = false;

                    mycmd = new MySqlCommand(sql, myconn);
                    mysdr = mycmd.ExecuteReader();
                    while (mysdr.Read())
                    {
                        n++;
                    }
                    for (int i = 0; i < n; i++)
                    {
                        dataGridView1.Columns[7].Width = 204;
                        dataGridView1.Rows[i].Cells[4].Value = "库存管理部";
                    }
                    mysda.Dispose();
                    mycmd.Dispose();
                    mysdr.Dispose();
                    ds.Dispose();
                    myconn.Close();
                }
                #endregion
                #region 按职位查找-销售员
                if (cmbox_cxtjPS.Text == "销售员")
                {//0ID，1姓名，2性别，3年龄，4职位，5年龄，6EPID，7密码，8住址，9ID
                    p = 6;
                    n = 0;
                    myconn.Open();
                    sql = "select EID as 用户名, EName as 姓名, ESex as 性别, EAge as 年龄, EPID as 职位, ETel as 手机, EPasswd as 密码, EAddress as 住址, ID as ID from tb_Employee where EPID='" + p + "'";
                    MySqlDataAdapter mysda = new MySqlDataAdapter(sql, myconn);
                    DataSet ds = new DataSet();
                    ds.Clear();
                    mysda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];

                    dataGridView1.Columns[8].Visible = false;

                    mycmd = new MySqlCommand(sql, myconn);
                    mysdr = mycmd.ExecuteReader();
                    while (mysdr.Read())
                    {
                        n++;
                    }
                    for (int i = 0; i < n; i++)
                    {
                        dataGridView1.Columns[7].Width = 204;
                        dataGridView1.Rows[i].Cells[4].Value = "销售员";
                    }
                    mysda.Dispose();
                    mycmd.Dispose();
                    mysdr.Dispose();
                    ds.Dispose();
                    myconn.Close();
                }
                #endregion
                */
            }
            #endregion

            #region 按性别查找
            if (cmbox_cxtj.Text == "按性别查找")
            {
                cxtj_axbcz();

                /*dataGridView1.Columns.Clear();

                int n = 0;
                myconn.Open();
                sql = "select EID as 用户名, EName as 姓名, ESex as 性别, EAge as 年龄, EPID as 职位, ETel as 手机, EPasswd as 密码, EAddress as 住址, ID as ID from tb_Employee where ESex='" + cmbox_cxtjPS.Text + "'";
                MySqlDataAdapter mysda = new MySqlDataAdapter(sql, myconn);
                DataSet ds = new DataSet();
                ds.Clear();
                mysda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                dataGridView1.Columns[8].Visible = false;

                mycmd = new MySqlCommand(sql, myconn);
                mysdr = mycmd.ExecuteReader();
                while (mysdr.Read())
                {
                    n++;
                }
                mysdr.Dispose();
                for (int i = 0; i < n; i++)
                {
                    dataGridView1.Columns[7].Width = 204;
                    string ssql = "select * from tb_Employee where ID='" + dataGridView1.Rows[i].Cells[8].Value + "'";
                    MySqlCommand smycmd = new MySqlCommand(ssql, myconn);
                    mysdr = smycmd.ExecuteReader();
                    mysdr.Read();
                    if (mysdr.HasRows)
                    {
                        int epid = Convert.ToInt32(mysdr["EPID"].ToString().Trim());
                        if (epid == 1)
                        {
                            dataGridView1.Rows[i].Cells[4].Value = "系统管理员";
                        }
                        if (epid == 2)
                        {
                            dataGridView1.Rows[i].Cells[4].Value = "店长";
                        }
                        if (epid == 3)
                        {
                            dataGridView1.Rows[i].Cells[4].Value = "人事部";
                        }
                        if (epid == 4)
                        {
                            dataGridView1.Rows[i].Cells[4].Value = "销售部";
                        }
                        if (epid == 5)
                        {
                            dataGridView1.Rows[i].Cells[4].Value = "库存管理部";
                        }
                        if (epid == 6)
                        {
                            dataGridView1.Rows[i].Cells[4].Value = "销售员";
                        }
                    }
                    smycmd.Dispose();
                    mysdr.Dispose();
                }
                mysda.Dispose();
                mycmd.Dispose();
                mysdr.Dispose();
                myconn.Close();*/
            }
            #endregion

            #region 查看所有员工信息
            if (cmbox_cxtj.Text == "查看所有员工信息")
            {
                cxtj_cksyygxx();

                /*int n = 0;
                myconn.Open();
                sql = "select EID as 用户名, EName as 姓名, ESex as 性别, EAge as 年龄, EPID as 职位, ETel as 手机, EPasswd as 密码, EAddress as 住址, ID as ID from tb_Employee";
                MySqlDataAdapter mysda = new MySqlDataAdapter(sql, myconn);
                DataSet ds = new DataSet();
                ds.Clear();
                mysda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                dataGridView1.Columns[8].Visible = false;

                mycmd = new MySqlCommand(sql, myconn);
                mysdr = mycmd.ExecuteReader();
                while (mysdr.Read())
                {
                    n++;
                }
                mysdr.Dispose();
                for (int i = 0; i < n; i++)
                {
                    dataGridView1.Columns[7].Width = 204;
                    string ssql = "select * from tb_Employee where ID='" + dataGridView1.Rows[i].Cells[8].Value + "'";
                    MySqlCommand smycmd = new MySqlCommand(ssql, myconn);
                    mysdr = smycmd.ExecuteReader();
                    mysdr.Read();
                    if (mysdr.HasRows)
                    {
                        int epid = Convert.ToInt32(mysdr["EPID"].ToString().Trim());
                        if (epid == 1)
                        {
                            dataGridView1.Rows[i].Cells[4].Value = "系统管理员";
                        }
                        if (epid == 2)
                        {
                            dataGridView1.Rows[i].Cells[4].Value = "店长";
                        }
                        if (epid == 3)
                        {
                            dataGridView1.Rows[i].Cells[4].Value = "人事部";
                        }
                        if (epid == 4)
                        {
                            dataGridView1.Rows[i].Cells[4].Value = "销售部";
                        }
                        if (epid == 5)
                        {
                            dataGridView1.Rows[i].Cells[4].Value = "库存管理部";
                        }
                        if (epid == 6)
                        {
                            dataGridView1.Rows[i].Cells[4].Value = "销售员";
                        }
                    }
                    smycmd.Dispose();
                    mysdr.Dispose();
                }
                mysda.Dispose();
                mycmd.Dispose();
                mysdr.Dispose();
                myconn.Close();*/
            }
            #endregion

            #region 查看各职位员工数
            if (cmbox_cxtj.Text == "查看各职位员工数")
            {
                cxtj_ckgzwygs();

                /*myconn.Open();
                sql = "select EPName as 职位,EPCount as 人数 from tb_EmployeePosition";
                MySqlDataAdapter mysda = new MySqlDataAdapter(sql, myconn);
                DataSet ds = new DataSet();
                ds.Clear();
                mysda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Width = 452;
                dataGridView1.Columns[1].Width = 452;
                mysda.Dispose();
                ds.Dispose();
                myconn.Close();*/
            }
            #endregion
        }
        #endregion

        #region 窗体顶部查看—查询本人信息按钮事件
        private void 查看本人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            myconn.Open();
            sql = "select * from tb_Employee where EID='" + LN + "'";
            MySqlCommand mycmd = new MySqlCommand(sql, myconn);
            MySqlDataReader mysdr = mycmd.ExecuteReader();
            mysdr.Read();
            if (mysdr.HasRows)
            {
                lab_ID.Text = mysdr[0].ToString().Trim();
                txtbox_LoginName.Text = mysdr[1].ToString().Trim();
                txtbox_Name.Text = mysdr[2].ToString().Trim();
                if (mysdr[3].ToString().Trim() == "男")
                {
                    cmbox_Sex.SelectedIndex = 0;
                }
                if (mysdr[3].ToString().Trim() == "女")
                {
                    cmbox_Sex.SelectedIndex = 1;
                }
                txtbox_Age.Text = mysdr[4].ToString().Trim();
                if (mysdr[5].ToString().Trim() == "1")
                {
                    cmbox_Position.SelectedIndex = 0;
                }
                if (mysdr[5].ToString().Trim() == "2")
                {
                    cmbox_Position.SelectedIndex = 1;
                }
                if (mysdr[5].ToString().Trim() == "3")
                {
                    cmbox_Position.SelectedIndex = 2;
                }
                if (mysdr[5].ToString().Trim() == "4")
                {
                    cmbox_Position.SelectedIndex = 3;
                }
                if (mysdr[5].ToString().Trim() == "5")
                {
                    cmbox_Position.SelectedIndex = 4;
                }
                if (mysdr[5].ToString().Trim() == "6")
                {
                    cmbox_Position.SelectedIndex = 5;
                }
                txtbox_Tel.Text = mysdr[6].ToString().Trim();
                txtbox_Passwd.Text = mysdr[7].ToString().Trim();
                txtbox_Address.Text = mysdr[8].ToString().Trim();
            }
            mysdr.Dispose();
            mycmd.Dispose();
            myconn.Close();
        }
        #endregion

        #region 窗体顶部查看—查看员工总人数按钮事件
        private void 查看员工总人数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myconn.Open();
            sql = "select sum(EPCount) from tb_EmployeePosition";
            mycmd = new MySqlCommand(sql, myconn);
            int n = Convert.ToInt32(mycmd.ExecuteScalar());
            if (n > 0)
            {
                mysdr = mycmd.ExecuteReader();
                mysdr.Read();
                if (mysdr.HasRows)
                {
                    MessageBox.Show("截至" + System.DateTime.Now + "，本超市总员工数为 " + mysdr[0].ToString().Trim() + " 人");
                }
                mysdr.Dispose();
            }
            mycmd.Dispose();
            myconn.Close();
        }
        #endregion

        #region 窗体顶部查看—查看所有员工信息按钮事件
        private void 查看所有员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cxtj_cksyygxx();
        }
        #endregion

        #region 窗体顶部查看—查看各职位员工数按钮事件
        private void 查看各职位员工数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmbox_cxtj.Text = "查看各职位员工数";
            cxtj_ckgzwygs();
        }
        #endregion

        #region 窗体顶部—保存按钮事件
        private void tsbtn_Save_Click(object sender, EventArgs e)
        {
            if (txtbox_LoginName.Text == "")
            {
                MessageBox.Show("请输入用户名！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbox_LoginName.Focus();
            }
            else
            {
                if (txtbox_Name.Text == "")
                {
                    MessageBox.Show("请输入姓名！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbox_Name.Focus();
                }
                else
                {
                    if (cmbox_Sex.Text == "")
                    {
                        MessageBox.Show("请选择性别！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cmbox_Sex.Focus();
                    }
                    else
                    {
                        if (txtbox_Age.Text == "")
                        {
                            MessageBox.Show("请输入年龄！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (cmbox_Position.Text == "")
                            {
                                MessageBox.Show("请选择职位！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                if (txtbox_Tel.Text == "")
                                {
                                    MessageBox.Show("请输入手机！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    if (txtbox_Passwd.Text == "")
                                    {
                                        MessageBox.Show("请输入密码！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    else
                                    {
                                        if (txtbox_Address.Text == "")
                                        {
                                            MessageBox.Show("请输入住址！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                        else
                                        {

                                            if (cmbox_cxtj.Text == "按用户名查找")
                                            {
                                                changeinsert();
                                                cxtj_ayhmcz();
                                            }
                                            if (cmbox_cxtj.Text == "按姓名查找")
                                            {
                                                changeinsert();
                                                cxtj_axmcz();
                                            }
                                            if (cmbox_cxtj.Text == "按职位查找")
                                            {
                                                changeinsert();
                                                cxtj_azwcz();
                                            }
                                            if (cmbox_cxtj.Text == "按性别查找")
                                            {
                                                changeinsert();
                                                cxtj_axbcz();
                                            }
                                            if (cmbox_cxtj.Text == "查看所有员工信息")
                                            {
                                                changeinsert();
                                                cxtj_cksyygxx();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            /*myconn.Open();
            sql = "select * from tb_Employee where EID='" + txtbox_LoginName.Text.Trim() + "'";
            mycmd = new MySqlCommand(sql, myconn);
            int n = Convert.ToInt32(mycmd.ExecuteScalar());
            if (n > 0)
            {
                //修改
                sql = "update tb_Employee set EID=@eid, EName=@ename, ESex=@esex, EAge=@eage, EPID=@epid, ETel=@etel, EPasswd=@epasswd, EAddress=@eaddress where ID=@id";
                mycmd = new MySqlCommand(sql, myconn);
                mycmd.Parameters.Add("@eid", MySqlDbType.VarChar, 50).Value = txtbox_LoginName.Text.Trim();
                mycmd.Parameters.Add("@ename", MySqlDbType.VarChar, 20).Value = txtbox_Name.Text.Trim();
                mycmd.Parameters.Add("@esex", MySqlDbType.VarChar, 20).Value = cmbox_Sex.Text.Trim();
                mycmd.Parameters.Add("@eage", MySqlDbType.Int32, 20).Value = txtbox_Age.Text.Trim();
                if (cmbox_Position.Text == "系统管理员")
                {
                    mycmd.Parameters.Add("@epid", MySqlDbType.VarChar, 20).Value = 1;
                }
                if (cmbox_Position.Text == "店长")
                {
                    mycmd.Parameters.Add("@epid", MySqlDbType.VarChar, 20).Value = 2;
                }
                if (cmbox_Position.Text == "人事部")
                {
                    mycmd.Parameters.Add("@epid", MySqlDbType.VarChar, 20).Value = 3;
                }
                if (cmbox_Position.Text == "销售部")
                {
                    mycmd.Parameters.Add("@epid", MySqlDbType.VarChar, 20).Value = 4;
                }
                if (cmbox_Position.Text == "库存管理部")
                {
                    mycmd.Parameters.Add("@epid", MySqlDbType.VarChar, 20).Value = 5;
                }
                if (cmbox_Position.Text == "销售员")
                {
                    mycmd.Parameters.Add("@epid", MySqlDbType.VarChar, 20).Value = 6;
                }
                mycmd.Parameters.Add("@etel", MySqlDbType.VarChar, 20).Value = txtbox_Tel.Text.Trim();
                mycmd.Parameters.Add("@epasswd", MySqlDbType.VarChar, 20).Value = txtbox_Passwd.Text.Trim();
                mycmd.Parameters.Add("@eaddress", MySqlDbType.VarChar, 50).Value = txtbox_Address.Text.Trim();
                mycmd.Parameters.Add("@id", MySqlDbType.Int32, 11).Value = Convert.ToInt32(lab_ID.Text.Trim());
                mycmd.ExecuteNonQuery();
                mycmd.Dispose();
                myconn.Close();
            }
            else
            {
                //添加
                sql = "insert into tb_Employee(EID, EName, ESex, EAge, EPID, ETel, EPasswd, EAddress) values (@eid, @ename, @esex, @eage, @epid, @etel, @epasswd, @eaddress)";
                mycmd = new MySqlCommand(sql, myconn);
                mycmd.Parameters.Add("@eid", MySqlDbType.VarChar, 50).Value = txtbox_LoginName.Text.Trim();
                mycmd.Parameters.Add("@ename", MySqlDbType.VarChar, 20).Value = txtbox_Name.Text.Trim();
                mycmd.Parameters.Add("@esex", MySqlDbType.VarChar, 20).Value = cmbox_Sex.Text.Trim();
                mycmd.Parameters.Add("@eage", MySqlDbType.Int32, 20).Value = txtbox_Age.Text.Trim();
                if (cmbox_Position.Text == "系统管理员")
                {
                    mycmd.Parameters.Add("@epid", MySqlDbType.VarChar, 20).Value = 1;
                }
                if (cmbox_Position.Text == "店长")
                {
                    mycmd.Parameters.Add("@epid", MySqlDbType.VarChar, 20).Value = 2;
                }
                if (cmbox_Position.Text == "人事部")
                {
                    mycmd.Parameters.Add("@epid", MySqlDbType.VarChar, 20).Value = 3;
                }
                if (cmbox_Position.Text == "销售部")
                {
                    mycmd.Parameters.Add("@epid", MySqlDbType.VarChar, 20).Value = 4;
                }
                if (cmbox_Position.Text == "库存管理部")
                {
                    mycmd.Parameters.Add("@epid", MySqlDbType.VarChar, 20).Value = 5;
                }
                if (cmbox_Position.Text == "销售员")
                {
                    mycmd.Parameters.Add("@epid", MySqlDbType.VarChar, 20).Value = 6;
                }
                mycmd.Parameters.Add("@etel", MySqlDbType.VarChar, 20).Value = txtbox_Tel.Text.Trim();
                mycmd.Parameters.Add("@epasswd", MySqlDbType.VarChar, 20).Value = txtbox_Passwd.Text.Trim();
                mycmd.Parameters.Add("@eaddress", MySqlDbType.VarChar, 50).Value = txtbox_Address.Text.Trim();
                mycmd.ExecuteNonQuery();
                mycmd.Dispose();
                myconn.Close();
            }
            mycmd.Dispose();
            myconn.Close();*/
        }
        #endregion

        #region 窗体顶部—取消按钮事件
        private void tsbtn_Cancel_Click(object sender, EventArgs e)
        {
            topmenu_cancel();

            /*txtbox_LoginName.Text = "";
            txtbox_Name.Text = "";
            cmbox_Sex.SelectedIndex = -1;
            txtbox_Age.Text = "";
            cmbox_Position.SelectedIndex = -1;
            txtbox_Tel.Text = "";
            txtbox_Passwd.Text = "";
            txtbox_Address.Text = "";

            txtbox_LoginName.Enabled = false;
            txtbox_Name.Enabled = false;
            cmbox_Sex.Enabled = false;
            txtbox_Age.Enabled = false;
            cmbox_Position.Enabled = false;
            txtbox_Tel.Enabled = false;
            txtbox_Passwd.Enabled = false;
            txtbox_Address.Enabled = false;
            
            tsbtn_Save.Enabled = false;
            tsbtn_Cancel.Enabled = false;
            tsbtn_Add.Enabled = true;
            tsbtn_Edit.Enabled = true;
            tsbtn_Del.Enabled = true;
            tsbtn_Export.Enabled = true;*/
        }
        #endregion

        #region 窗体顶部—添加按钮事件
        private void tsbtn_Add_Click(object sender, EventArgs e)
        {
            txtbox_LoginName.Enabled = true;
            txtbox_Name.Enabled = true;
            cmbox_Sex.Enabled = true;
            txtbox_Age.Enabled = true;
            cmbox_Position.Enabled = true;
            txtbox_Tel.Enabled = true;
            txtbox_Passwd.Enabled = true;
            txtbox_Address.Enabled = true;

            txtbox_LoginName.Text = "";
            txtbox_Name.Text = "";
            cmbox_Sex.SelectedIndex = 0;
            txtbox_Age.Text = "";
            cmbox_Position.SelectedIndex = 5;
            txtbox_Tel.Text = "";
            txtbox_Passwd.Text = "";
            txtbox_Address.Text = "";

            cmbox_cxtj.SelectedIndex = 4;

            tsbtn_Save.Enabled = true;
            tsbtn_Cancel.Enabled = true;
            tsbtn_Add.Enabled = false;
            tsbtn_Edit.Enabled = false;
            tsbtn_Del.Enabled = false;
            tsbtn_Export.Enabled = false;
        }
        #endregion

        #region 窗体顶部—修改按钮事件
        private void tsbtn_Edit_Click(object sender, EventArgs e)
        {
            if (txtbox_LoginName.Text != "")
            {
                txtbox_LoginName.Enabled = true;
                txtbox_Name.Enabled = true;
                cmbox_Sex.Enabled = true;
                txtbox_Age.Enabled = true;
                cmbox_Position.Enabled = true;
                txtbox_Tel.Enabled = true;
                txtbox_Passwd.Enabled = true;
                txtbox_Address.Enabled = true;

                tsbtn_Save.Enabled = true;
                tsbtn_Cancel.Enabled = true;
                tsbtn_Add.Enabled = false;
                tsbtn_Edit.Enabled = false;
                tsbtn_Del.Enabled = false;
                tsbtn_Export.Enabled = false;
            }
            else
            {
                if (dataGridView1.SelectedRows.Count != 0)
                {
                    txtbox_LoginName.Enabled = true;
                    txtbox_Name.Enabled = true;
                    cmbox_Sex.Enabled = true;
                    txtbox_Age.Enabled = true;
                    cmbox_Position.Enabled = true;
                    txtbox_Tel.Enabled = true;
                    txtbox_Passwd.Enabled = true;
                    txtbox_Address.Enabled = true;

                    tsbtn_Save.Enabled = true;
                    tsbtn_Cancel.Enabled = true;
                    tsbtn_Add.Enabled = false;
                    tsbtn_Edit.Enabled = false;
                    tsbtn_Del.Enabled = false;
                    tsbtn_Export.Enabled = false;
                }
                else
                {
                    MessageBox.Show("请选择要修改的数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion

        #region 窗体顶部—删除按钮事件
        private void tsbtn_Del_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择要删除的数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (cmbox_cxtj.Text == "按用户名查找")
                {
                    delete();
                    cxtj_ayhmcz();
                }
                if (cmbox_cxtj.Text == "按姓名查找")
                {
                    delete();
                    cxtj_axmcz();
                }
                if (cmbox_cxtj.Text == "按职位查找")
                {
                    delete();
                    cxtj_azwcz();
                }
                if (cmbox_cxtj.Text == "按性别查找")
                {
                    delete();
                    cxtj_axbcz();
                }
                if (cmbox_cxtj.Text == "查看所有员工信息")
                {
                    delete();
                    cxtj_cksyygxx();
                }

                /*myconn.Open();
                sql = "delete from tb_Employee where ID='" + Convert.ToInt32(lab_ID.Text.Trim()) + "'";
                mycmd = new MySqlCommand(sql, myconn);
                int n = mycmd.ExecuteNonQuery();
                if (n > 0)
                {
                    string ssql = "select EPName, EPCount from tb_EmployeePosition where EPName='" + cmbox_Position.Text + "'";
                    MySqlCommand smycmd = new MySqlCommand(ssql, myconn);
                    MySqlDataReader smysdr = smycmd.ExecuteReader();
                    smysdr.Read();
                    if (smysdr.HasRows)
                    {
                        MySqlConnection smyconn = BaseClass.DBConn.MyConn();
                        smyconn.Open();
                        string sssql = "update tb_EmployeePosition set EPCount=@epcount where EPName=@epname";
                        MySqlCommand ssmycmd = new MySqlCommand(sssql, smyconn);
                        ssmycmd.Parameters.Add("@epcount", MySqlDbType.Int32, 11).Value = (Convert.ToInt32(smysdr[1].ToString().Trim()) - 1).ToString();
                        ssmycmd.Parameters.Add("@epname", MySqlDbType.VarChar, 20).Value = cmbox_Position.Text;
                        ssmycmd.ExecuteNonQuery();
                        ssmycmd.Dispose();
                        smyconn.Close();
                    }
                    smycmd.Dispose();
                    smysdr.Dispose();
                    MessageBox.Show("删除用户信息成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("删除用户信息失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                mycmd.Dispose();
                myconn.Close();*/
            }
        }
        #endregion

        #region 窗体顶部—导出按钮事件
        private void tsbtn_Export_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null)
            {
                MessageBox.Show("没有要导出的内容！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataGridViewToExcel(dataGridView1);
            }
        }
        #endregion

        #region 窗体顶部—退出按钮事件
        private void tsbtn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        #region 查询条件选中事件
        private void cmbox_cxtj_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbox_cxtj.Text == "按用户名查找")
            {
                txtbox_cxtjLN.Text = "";
                txtbox_cxtjLN.Visible = true;
                cmbox_cxtjPS.Visible = false;
            }
            if (cmbox_cxtj.Text == "按姓名查找")
            {
                txtbox_cxtjLN.Text = "";
                txtbox_cxtjLN.Visible = true;
                cmbox_cxtjPS.Visible = false;
            }
            if (cmbox_cxtj.Text == "按职位查找")
            {
                txtbox_cxtjLN.Visible = false;
                cmbox_cxtjPS.Visible = true;
                cmbox_cxtjPS.Items.Clear();
                cmbox_cxtjPS.Items.Add("系统管理员");
                cmbox_cxtjPS.Items.Add("店长");
                cmbox_cxtjPS.Items.Add("人事部");
                cmbox_cxtjPS.Items.Add("销售部");
                cmbox_cxtjPS.Items.Add("库存管理部");
                cmbox_cxtjPS.Items.Add("销售员");
                cmbox_cxtjPS.SelectedIndex = 0;
            }
            if (cmbox_cxtj.Text == "按性别查找")
            {
                txtbox_cxtjLN.Visible = false;
                cmbox_cxtjPS.Visible = true;
                cmbox_cxtjPS.Items.Clear();
                cmbox_cxtjPS.Items.Add("男");
                cmbox_cxtjPS.Items.Add("女");
                cmbox_cxtjPS.SelectedIndex = 0;
            }
            if (cmbox_cxtj.Text == "查看所有员工信息")
            {
                txtbox_cxtjLN.Visible = false;
                cmbox_cxtjPS.Visible = false;
            }
            if (cmbox_cxtj.Text == "查看各职位员工数")
            {
                txtbox_cxtjLN.Visible = false;
                cmbox_cxtjPS.Visible = false;
            }
        }
        #endregion

        #region 查询条件文本框回车事件
        private void txtbox_cxtjLN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btn_Search_Click(sender, e);
            }
        }
        #endregion

        #region 查询条件-查看所有员工信息
        private void cxtj_cksyygxx()
        {
            dataGridView1.Columns.Clear();

            int n = 0;
            myconn.Open();
            sql = "select EID as 用户名, EName as 姓名, ESex as 性别, EAge as 年龄, EPID as 职位, ETel as 手机, EPasswd as 密码, EAddress as 住址, ID as ID from tb_Employee";
            MySqlDataAdapter mysda = new MySqlDataAdapter(sql, myconn);
            DataSet ds = new DataSet();
            ds.Clear();
            mysda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.ClearSelection();

            dataGridView1.Columns[8].Visible = false;

            mycmd = new MySqlCommand(sql, myconn);
            mysdr = mycmd.ExecuteReader();
            while (mysdr.Read())
            {
                n++;
            }
            mysdr.Dispose();
            for (int i = 0; i < n; i++)
            {
                dataGridView1.Columns[7].Width = 204;
                string ssql = "select * from tb_Employee where ID='" + dataGridView1.Rows[i].Cells[8].Value.ToString().Trim() + "'";
                MySqlCommand smycmd = new MySqlCommand(ssql, myconn);
                mysdr = smycmd.ExecuteReader();
                mysdr.Read();
                if (mysdr.HasRows)
                {
                    int epid = Convert.ToInt32(mysdr["EPID"].ToString().Trim());
                    if (epid == 1)
                    {
                        dataGridView1.Rows[i].Cells[4].Value = "系统管理员";
                    }
                    if (epid == 2)
                    {
                        dataGridView1.Rows[i].Cells[4].Value = "店长";
                    }
                    if (epid == 3)
                    {
                        dataGridView1.Rows[i].Cells[4].Value = "人事部";
                    }
                    if (epid == 4)
                    {
                        dataGridView1.Rows[i].Cells[4].Value = "销售部";
                    }
                    if (epid == 5)
                    {
                        dataGridView1.Rows[i].Cells[4].Value = "库存管理部";
                    }
                    if (epid == 6)
                    {
                        dataGridView1.Rows[i].Cells[4].Value = "销售员";
                    }
                }
                smycmd.Dispose();
                mysdr.Dispose();
            }
            mysda.Dispose();
            mycmd.Dispose();
            mysdr.Dispose();
            myconn.Close();
        }
        #endregion

        #region 查询条件-查看各职位员工数
        private void cxtj_ckgzwygs()
        {
            dataGridView1.Columns.Clear();

            myconn.Open();
            sql = "select EPName as 职位,EPCount as 人数 from tb_EmployeePosition";
            MySqlDataAdapter mysda = new MySqlDataAdapter(sql, myconn);
            DataSet ds = new DataSet();
            ds.Clear();
            mysda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.ClearSelection();
            dataGridView1.Columns[0].Width = 452;
            dataGridView1.Columns[1].Width = 452;
            mysda.Dispose();
            ds.Dispose();
            myconn.Close();
        }
        #endregion

        #region datagridview行点击 信息显示到员工信息中
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cmbox_cxtj.Text != "查看各职位员工数")
            {
                txtbox_LoginName.Text = dataGridView1.SelectedCells[0].Value.ToString().Trim();
                txtbox_Name.Text = dataGridView1.SelectedCells[1].Value.ToString().Trim();
                if (dataGridView1.SelectedCells[2].Value.ToString().Trim() == "男")
                {
                    cmbox_Sex.SelectedIndex = 0;
                }
                if (dataGridView1.SelectedCells[2].Value.ToString().Trim() == "女")
                {
                    cmbox_Sex.SelectedIndex = 1;
                }
                txtbox_Age.Text = dataGridView1.SelectedCells[3].Value.ToString().Trim();
                if (dataGridView1.SelectedCells[4].Value.ToString().Trim() == "系统管理员")
                {
                    cmbox_Position.SelectedIndex = 0;
                }
                if (dataGridView1.SelectedCells[4].Value.ToString().Trim() == "店长")
                {
                    cmbox_Position.SelectedIndex = 1;
                }
                if (dataGridView1.SelectedCells[4].Value.ToString().Trim() == "人事部")
                {
                    cmbox_Position.SelectedIndex = 2;
                }
                if (dataGridView1.SelectedCells[4].Value.ToString().Trim() == "销售部")
                {
                    cmbox_Position.SelectedIndex = 3;
                }
                if (dataGridView1.SelectedCells[4].Value.ToString().Trim() == "库存管理部")
                {
                    cmbox_Position.SelectedIndex = 4;
                }
                if (dataGridView1.SelectedCells[4].Value.ToString().Trim() == "销售员")
                {
                    cmbox_Position.SelectedIndex = 5;
                }
                txtbox_Tel.Text = dataGridView1.SelectedCells[5].Value.ToString().Trim();
                txtbox_Passwd.Text = dataGridView1.SelectedCells[6].Value.ToString().Trim();
                txtbox_Address.Text = dataGridView1.SelectedCells[7].Value.ToString().Trim();
                lab_ID.Text = dataGridView1.SelectedCells[8].Value.ToString().Trim();
            }
        }
        #endregion

        #region DataGridView导出Excel
        private void DataGridViewToExcel(DataGridView dgv)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Execl files (*.xls)|*.xls";
            dlg.FilterIndex = 0;
            dlg.RestoreDirectory = true;
            dlg.CreatePrompt = true;
            dlg.Title = "保存为Excel文件";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Stream myStream;
                myStream = dlg.OpenFile();
                StreamWriter sw = new StreamWriter(myStream, System.Text.Encoding.GetEncoding(-0));
                string columnTitle = "";
                string fileNameString = dlg.FileName;
                try
                {
                    //写入列标题     
                    for (int i = 0; i < dgv.ColumnCount; i++)
                    {
                        if (i > 0)
                        {
                            columnTitle += "\t";
                        }
                        columnTitle += dgv.Columns[i].HeaderText;
                    }
                    sw.WriteLine(columnTitle);

                    //写入列内容     
                    for (int j = 0; j < dgv.Rows.Count; j++)
                    {
                        string columnValue = "";
                        for (int k = 0; k < dgv.Columns.Count; k++)
                        {
                            if (k > 0)
                            {
                                columnValue += "\t";
                            }
                            if (dgv.Rows[j].Cells[k].Value == null)
                                columnValue += "";
                            else
                                columnValue += dgv.Rows[j].Cells[k].Value.ToString().Trim();
                        }
                        sw.WriteLine(columnValue);
                    }
                    sw.Close();
                    myStream.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    sw.Close();
                    myStream.Close();
                }
                MessageBox.Show(fileNameString + "\n导出完毕！", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region 保存按钮-修改添加
        private void changeinsert()
        {
            myconn.Open();
            sql = "select * from tb_Employee where EID='" + txtbox_LoginName.Text.Trim() + "'";
            mycmd = new MySqlCommand(sql, myconn);
            int n = Convert.ToInt32(mycmd.ExecuteScalar());
            if (n > 0)//修改
            {
                sql = "update tb_Employee set EID=@eid, EName=@ename, ESex=@esex, EAge=@eage, EPID=@epid, ETel=@etel, EPasswd=@epasswd, EAddress=@eaddress where ID=@id";
                mycmd = new MySqlCommand(sql, myconn);
                mycmd.Parameters.Add("@eid", MySqlDbType.VarChar, 50).Value = txtbox_LoginName.Text.Trim();
                mycmd.Parameters.Add("@ename", MySqlDbType.VarChar, 20).Value = txtbox_Name.Text.Trim();
                mycmd.Parameters.Add("@esex", MySqlDbType.VarChar, 20).Value = cmbox_Sex.Text.Trim();
                mycmd.Parameters.Add("@eage", MySqlDbType.Int32, 20).Value = txtbox_Age.Text.Trim();
                if (cmbox_Position.Text == "系统管理员")
                {
                    mycmd.Parameters.Add("@epid", MySqlDbType.VarChar, 20).Value = 1;
                }
                if (cmbox_Position.Text == "店长")
                {
                    mycmd.Parameters.Add("@epid", MySqlDbType.VarChar, 20).Value = 2;
                }
                if (cmbox_Position.Text == "人事部")
                {
                    mycmd.Parameters.Add("@epid", MySqlDbType.VarChar, 20).Value = 3;
                }
                if (cmbox_Position.Text == "销售部")
                {
                    mycmd.Parameters.Add("@epid", MySqlDbType.VarChar, 20).Value = 4;
                }
                if (cmbox_Position.Text == "库存管理部")
                {
                    mycmd.Parameters.Add("@epid", MySqlDbType.VarChar, 20).Value = 5;
                }
                if (cmbox_Position.Text == "销售员")
                {
                    mycmd.Parameters.Add("@epid", MySqlDbType.VarChar, 20).Value = 6;
                }
                mycmd.Parameters.Add("@etel", MySqlDbType.VarChar, 20).Value = txtbox_Tel.Text.Trim();
                mycmd.Parameters.Add("@epasswd", MySqlDbType.VarChar, 20).Value = txtbox_Passwd.Text.Trim();
                mycmd.Parameters.Add("@eaddress", MySqlDbType.VarChar, 50).Value = txtbox_Address.Text.Trim();
                mycmd.Parameters.Add("@id", MySqlDbType.Int32, 11).Value = Convert.ToInt32(lab_ID.Text.Trim());
                mycmd.ExecuteNonQuery();
                mycmd.Dispose();
                myconn.Close();
                topmenu_cancel();
                MessageBox.Show("修改用户信息成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else//添加
            {
                sql = "insert into tb_Employee(EID, EName, ESex, EAge, EPID, ETel, EPasswd, EAddress) values (@eid, @ename, @esex, @eage, @epid, @etel, @epasswd, @eaddress)";
                mycmd = new MySqlCommand(sql, myconn);
                mycmd.Parameters.Add("@eid", MySqlDbType.VarChar, 50).Value = txtbox_LoginName.Text.Trim();
                mycmd.Parameters.Add("@ename", MySqlDbType.VarChar, 20).Value = txtbox_Name.Text.Trim();
                mycmd.Parameters.Add("@esex", MySqlDbType.VarChar, 20).Value = cmbox_Sex.Text.Trim();
                mycmd.Parameters.Add("@eage", MySqlDbType.Int32, 20).Value = txtbox_Age.Text.Trim();
                if (cmbox_Position.Text == "系统管理员")
                {
                    mycmd.Parameters.Add("@epid", MySqlDbType.VarChar, 20).Value = 1;
                }
                if (cmbox_Position.Text == "店长")
                {
                    mycmd.Parameters.Add("@epid", MySqlDbType.VarChar, 20).Value = 2;
                }
                if (cmbox_Position.Text == "人事部")
                {
                    mycmd.Parameters.Add("@epid", MySqlDbType.VarChar, 20).Value = 3;
                }
                if (cmbox_Position.Text == "销售部")
                {
                    mycmd.Parameters.Add("@epid", MySqlDbType.VarChar, 20).Value = 4;
                }
                if (cmbox_Position.Text == "库存管理部")
                {
                    mycmd.Parameters.Add("@epid", MySqlDbType.VarChar, 20).Value = 5;
                }
                if (cmbox_Position.Text == "销售员")
                {
                    mycmd.Parameters.Add("@epid", MySqlDbType.VarChar, 20).Value = 6;
                }
                mycmd.Parameters.Add("@etel", MySqlDbType.VarChar, 20).Value = txtbox_Tel.Text.Trim();
                mycmd.Parameters.Add("@epasswd", MySqlDbType.VarChar, 20).Value = txtbox_Passwd.Text.Trim();
                mycmd.Parameters.Add("@eaddress", MySqlDbType.VarChar, 50).Value = txtbox_Address.Text.Trim();
                mycmd.ExecuteNonQuery();

                string ssql = "select EPName, EPCount from tb_EmployeePosition where EPName='" + cmbox_Position.Text + "'";
                MySqlCommand smycmd = new MySqlCommand(ssql, myconn);
                MySqlDataReader smysdr = smycmd.ExecuteReader();
                smysdr.Read();
                if (smysdr.HasRows)
                {
                    MySqlConnection smyconn = BaseClass.DBConn.MyConn();
                    smyconn.Open();
                    string sssql = "update tb_EmployeePosition set EPCount=@epcount where EPName=@epname";
                    MySqlCommand ssmycmd = new MySqlCommand(sssql, smyconn);
                    ssmycmd.Parameters.Add("@epcount", MySqlDbType.Int32, 11).Value = (Convert.ToInt32(smysdr[1].ToString().Trim()) + 1).ToString();
                    ssmycmd.Parameters.Add("@epname", MySqlDbType.VarChar, 20).Value = cmbox_Position.Text;
                    ssmycmd.ExecuteNonQuery();
                    ssmycmd.Dispose();
                    smyconn.Close();
                }
                smycmd.Dispose();
                smysdr.Dispose();
                mycmd.Dispose();
                myconn.Close();
                topmenu_cancel();
                MessageBox.Show("添加用户信息成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region 删除按钮-删除
        private void delete()
        {
            myconn.Open();
            sql = "delete from tb_Employee where ID='" + Convert.ToInt32(lab_ID.Text.Trim()) + "'";
            mycmd = new MySqlCommand(sql, myconn);
            int n = mycmd.ExecuteNonQuery();
            if (n > 0)
            {
                string ssql = "select EPName, EPCount from tb_EmployeePosition where EPName='" + cmbox_Position.Text + "'";
                MySqlCommand smycmd = new MySqlCommand(ssql, myconn);
                MySqlDataReader smysdr = smycmd.ExecuteReader();
                smysdr.Read();
                if (smysdr.HasRows)
                {
                    MySqlConnection smyconn = BaseClass.DBConn.MyConn();
                    smyconn.Open();
                    string sssql = "update tb_EmployeePosition set EPCount=@epcount where EPName=@epname";
                    MySqlCommand ssmycmd = new MySqlCommand(sssql, smyconn);
                    ssmycmd.Parameters.Add("@epcount", MySqlDbType.Int32, 11).Value = (Convert.ToInt32(smysdr[1].ToString().Trim()) - 1).ToString();
                    ssmycmd.Parameters.Add("@epname", MySqlDbType.VarChar, 20).Value = cmbox_Position.Text;
                    ssmycmd.ExecuteNonQuery();
                    ssmycmd.Dispose();
                    smyconn.Close();
                }
                smycmd.Dispose();
                smysdr.Dispose();
                MessageBox.Show("删除用户信息成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("删除用户信息失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            mycmd.Dispose();
            myconn.Close();
        }
        #endregion

        #region 查询条件-按用户名查找
        private void cxtj_ayhmcz()
        {
            if (cmbox_cxtj.Text == "按用户名查找")
            {
                dataGridView1.Columns.Clear();

                if (txtbox_cxtjLN.Text == "")
                {
                    MessageBox.Show("请输入用户名！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbox_cxtjLN.Focus();
                }
                else
                {
                    myconn.Open();
                    sql = "select * from tb_Employee where EID='" + txtbox_cxtjLN.Text + "'";
                    MySqlCommand mycmd = new MySqlCommand(sql, myconn);
                    int n = Convert.ToInt32(mycmd.ExecuteScalar());
                    if (n > 0)
                    {
                        MySqlDataReader mysdr = mycmd.ExecuteReader();
                        mysdr.Read();
                        if (mysdr.HasRows)
                        {
                            lab_ID.Text = mysdr[0].ToString().Trim();
                            txtbox_LoginName.Text = mysdr[1].ToString().Trim();
                            txtbox_Name.Text = mysdr[2].ToString().Trim();
                            if (mysdr[3].ToString().Trim() == "男")
                            {
                                cmbox_Sex.SelectedIndex = 0;
                            }
                            if (mysdr[3].ToString().Trim() == "女")
                            {
                                cmbox_Sex.SelectedIndex = 1;
                            }
                            txtbox_Age.Text = mysdr[4].ToString().Trim();
                            if (mysdr[5].ToString().Trim() == "1")
                            {
                                cmbox_Position.SelectedIndex = 0;
                            }
                            if (mysdr[5].ToString().Trim() == "2")
                            {
                                cmbox_Position.SelectedIndex = 1;
                            }
                            if (mysdr[5].ToString().Trim() == "3")
                            {
                                cmbox_Position.SelectedIndex = 2;
                            }
                            if (mysdr[5].ToString().Trim() == "4")
                            {
                                cmbox_Position.SelectedIndex = 3;
                            }
                            if (mysdr[5].ToString().Trim() == "5")
                            {
                                cmbox_Position.SelectedIndex = 4;
                            }
                            if (mysdr[5].ToString().Trim() == "6")
                            {
                                cmbox_Position.SelectedIndex = 5;
                            }
                            txtbox_Tel.Text = mysdr[6].ToString().Trim();
                            txtbox_Passwd.Text = mysdr[7].ToString().Trim();
                            txtbox_Address.Text = mysdr[8].ToString().Trim();
                        }
                        mysdr.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("您查询的用户名不存在！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    mycmd.Dispose();
                    myconn.Close();
                }
            }
        }
        #endregion

        #region 查询条件-按姓名查找
        private void cxtj_axmcz()
        {
            if (cmbox_cxtj.Text == "按姓名查找")
            {
                dataGridView1.Columns.Clear();

                if (txtbox_cxtjLN.Text == "")
                {
                    MessageBox.Show("请输入姓名！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbox_cxtjLN.Focus();
                }
                else
                {
                    myconn.Open();
                    sql = "select * from tb_Employee where EName='" + txtbox_cxtjLN.Text + "'";
                    MySqlCommand mycmd = new MySqlCommand(sql, myconn);
                    int n = Convert.ToInt32(mycmd.ExecuteScalar());
                    if (n > 0)
                    {
                        MySqlDataReader mysdr = mycmd.ExecuteReader();
                        mysdr.Read();
                        if (mysdr.HasRows)
                        {
                            lab_ID.Text = mysdr[0].ToString().Trim();
                            txtbox_LoginName.Text = mysdr[1].ToString().Trim();
                            txtbox_Name.Text = mysdr[2].ToString().Trim();
                            if (mysdr[3].ToString().Trim() == "男")
                            {
                                cmbox_Sex.SelectedIndex = 0;
                            }
                            if (mysdr[3].ToString().Trim() == "女")
                            {
                                cmbox_Sex.SelectedIndex = 1;
                            }
                            txtbox_Age.Text = mysdr[4].ToString().Trim();
                            if (mysdr[5].ToString().Trim() == "1")
                            {
                                cmbox_Position.SelectedIndex = 0;
                            }
                            if (mysdr[5].ToString().Trim() == "2")
                            {
                                cmbox_Position.SelectedIndex = 1;
                            }
                            if (mysdr[5].ToString().Trim() == "3")
                            {
                                cmbox_Position.SelectedIndex = 2;
                            }
                            if (mysdr[5].ToString().Trim() == "4")
                            {
                                cmbox_Position.SelectedIndex = 3;
                            }
                            if (mysdr[5].ToString().Trim() == "5")
                            {
                                cmbox_Position.SelectedIndex = 4;
                            }
                            if (mysdr[5].ToString().Trim() == "6")
                            {
                                cmbox_Position.SelectedIndex = 5;
                            }
                            txtbox_Tel.Text = mysdr[6].ToString().Trim();
                            txtbox_Passwd.Text = mysdr[7].ToString().Trim();
                            txtbox_Address.Text = mysdr[8].ToString().Trim();
                        }
                        mysdr.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("您查询的姓名不存在！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    mycmd.Dispose();
                    myconn.Close();
                }
            }
        }
        #endregion

        #region 查询条件-按职位查找
        private void cxtj_azwcz()
        {
            if (cmbox_cxtj.Text == "按职位查找")
            {
                dataGridView1.Columns.Clear();

                int p, n;

                #region 按职位查找-系统管理员
                if (cmbox_cxtjPS.Text == "系统管理员")
                {
                    p = 1;
                    n = 0;
                    myconn.Open();
                    sql = "select EID as 用户名, EName as 姓名, ESex as 性别, EAge as 年龄, EPID as 职位, ETel as 手机, EPasswd as 密码, EAddress as 住址, ID as ID from tb_Employee where EPID='" + p + "'";
                    MySqlDataAdapter mysda = new MySqlDataAdapter(sql, myconn);
                    DataSet ds = new DataSet();
                    ds.Clear();
                    mysda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.ClearSelection();

                    dataGridView1.Columns[8].Visible = false;

                    mycmd = new MySqlCommand(sql, myconn);
                    mysdr = mycmd.ExecuteReader();
                    while (mysdr.Read())
                    {
                        n++;
                    }
                    for (int i = 0; i < n; i++)
                    {
                        dataGridView1.Columns[7].Width = 204;
                        dataGridView1.Rows[i].Cells[4].Value = "系统管理员";
                    }
                    mysda.Dispose();
                    mycmd.Dispose();
                    mysdr.Dispose();
                    ds.Dispose();
                    myconn.Close();
                }
                #endregion
                #region 按职位查找-店长
                if (cmbox_cxtjPS.Text == "店长")
                {
                    p = 2;
                    n = 0;
                    myconn.Open();
                    sql = "select EID as 用户名, EName as 姓名, ESex as 性别, EAge as 年龄, EPID as 职位, ETel as 手机, EPasswd as 密码, EAddress as 住址, ID as ID from tb_Employee where EPID='" + p + "'";
                    MySqlDataAdapter mysda = new MySqlDataAdapter(sql, myconn);
                    DataSet ds = new DataSet();
                    ds.Clear();
                    mysda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.ClearSelection();

                    dataGridView1.Columns[8].Visible = false;

                    mycmd = new MySqlCommand(sql, myconn);
                    mysdr = mycmd.ExecuteReader();
                    while (mysdr.Read())
                    {
                        n++;
                    }
                    for (int i = 0; i < n; i++)
                    {
                        dataGridView1.Columns[7].Width = 204;
                        dataGridView1.Rows[i].Cells[4].Value = "店长";
                    }
                    mysda.Dispose();
                    mycmd.Dispose();
                    mysdr.Dispose();
                    ds.Dispose();
                    myconn.Close();
                }
                #endregion
                #region 按职位查找-人事部
                if (cmbox_cxtjPS.Text == "人事部")
                {
                    p = 3;
                    n = 0;
                    myconn.Open();
                    sql = "select EID as 用户名, EName as 姓名, ESex as 性别, EAge as 年龄, EPID as 职位, ETel as 手机, EPasswd as 密码, EAddress as 住址, ID as ID from tb_Employee where EPID='" + p + "'";
                    MySqlDataAdapter mysda = new MySqlDataAdapter(sql, myconn);
                    DataSet ds = new DataSet();
                    ds.Clear();
                    mysda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.ClearSelection();

                    dataGridView1.Columns[8].Visible = false;

                    mycmd = new MySqlCommand(sql, myconn);
                    mysdr = mycmd.ExecuteReader();
                    while (mysdr.Read())
                    {
                        n++;
                    }
                    for (int i = 0; i < n; i++)
                    {
                        dataGridView1.Columns[7].Width = 204;
                        dataGridView1.Rows[i].Cells[4].Value = "人事部";
                    }
                    mysda.Dispose();
                    mycmd.Dispose();
                    mysdr.Dispose();
                    ds.Dispose();
                    myconn.Close();
                }
                #endregion
                #region 按职位查找-销售部
                if (cmbox_cxtjPS.Text == "销售部")
                {
                    p = 4;
                    n = 0;
                    myconn.Open();
                    sql = "select EID as 用户名, EName as 姓名, ESex as 性别, EAge as 年龄, EPID as 职位, ETel as 手机, EPasswd as 密码, EAddress as 住址, ID as ID from tb_Employee where EPID='" + p + "'";
                    MySqlDataAdapter mysda = new MySqlDataAdapter(sql, myconn);
                    DataSet ds = new DataSet();
                    ds.Clear();
                    mysda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.ClearSelection();

                    dataGridView1.Columns[8].Visible = false;

                    mycmd = new MySqlCommand(sql, myconn);
                    mysdr = mycmd.ExecuteReader();
                    while (mysdr.Read())
                    {
                        n++;
                    }
                    for (int i = 0; i < n; i++)
                    {
                        dataGridView1.Columns[7].Width = 204;
                        dataGridView1.Rows[i].Cells[4].Value = "销售部";
                    }
                    mysda.Dispose();
                    mycmd.Dispose();
                    mysdr.Dispose();
                    ds.Dispose();
                    myconn.Close();
                }
                #endregion
                #region 按职位查找-库存管理部
                if (cmbox_cxtjPS.Text == "库存管理部")
                {
                    p = 5;
                    n = 0;
                    myconn.Open();
                    sql = "select EID as 用户名, EName as 姓名, ESex as 性别, EAge as 年龄, EPID as 职位, ETel as 手机, EPasswd as 密码, EAddress as 住址, ID as ID from tb_Employee where EPID='" + p + "'";
                    MySqlDataAdapter mysda = new MySqlDataAdapter(sql, myconn);
                    DataSet ds = new DataSet();
                    ds.Clear();
                    mysda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.ClearSelection();

                    dataGridView1.Columns[8].Visible = false;

                    mycmd = new MySqlCommand(sql, myconn);
                    mysdr = mycmd.ExecuteReader();
                    while (mysdr.Read())
                    {
                        n++;
                    }
                    for (int i = 0; i < n; i++)
                    {
                        dataGridView1.Columns[7].Width = 204;
                        dataGridView1.Rows[i].Cells[4].Value = "库存管理部";
                    }
                    mysda.Dispose();
                    mycmd.Dispose();
                    mysdr.Dispose();
                    ds.Dispose();
                    myconn.Close();
                }
                #endregion
                #region 按职位查找-销售员
                if (cmbox_cxtjPS.Text == "销售员")
                {//0ID，1姓名，2性别，3年龄，4职位，5年龄，6EPID，7密码，8住址，9ID
                    p = 6;
                    n = 0;
                    myconn.Open();
                    sql = "select EID as 用户名, EName as 姓名, ESex as 性别, EAge as 年龄, EPID as 职位, ETel as 手机, EPasswd as 密码, EAddress as 住址, ID as ID from tb_Employee where EPID='" + p + "'";
                    MySqlDataAdapter mysda = new MySqlDataAdapter(sql, myconn);
                    DataSet ds = new DataSet();
                    ds.Clear();
                    mysda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.ClearSelection();

                    dataGridView1.Columns[8].Visible = false;

                    mycmd = new MySqlCommand(sql, myconn);
                    mysdr = mycmd.ExecuteReader();
                    while (mysdr.Read())
                    {
                        n++;
                    }
                    for (int i = 0; i < n; i++)
                    {
                        dataGridView1.Columns[7].Width = 204;
                        dataGridView1.Rows[i].Cells[4].Value = "销售员";
                    }
                    mysda.Dispose();
                    mycmd.Dispose();
                    mysdr.Dispose();
                    ds.Dispose();
                    myconn.Close();
                }
                #endregion
            }
        }
        #endregion

        #region 查询条件-按性别查找
        private void cxtj_axbcz()
        {
            if (cmbox_cxtj.Text == "按性别查找")
            {
                dataGridView1.Columns.Clear();

                int n = 0;
                myconn.Open();
                sql = "select EID as 用户名, EName as 姓名, ESex as 性别, EAge as 年龄, EPID as 职位, ETel as 手机, EPasswd as 密码, EAddress as 住址, ID as ID from tb_Employee where ESex='" + cmbox_cxtjPS.Text + "'";
                MySqlDataAdapter mysda = new MySqlDataAdapter(sql, myconn);
                DataSet ds = new DataSet();
                ds.Clear();
                mysda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.ClearSelection();

                dataGridView1.Columns[8].Visible = false;

                mycmd = new MySqlCommand(sql, myconn);
                mysdr = mycmd.ExecuteReader();
                while (mysdr.Read())
                {
                    n++;
                }
                mysdr.Dispose();
                for (int i = 0; i < n; i++)
                {
                    dataGridView1.Columns[7].Width = 204;
                    string ssql = "select * from tb_Employee where ID='" + dataGridView1.Rows[i].Cells[8].Value + "'";
                    MySqlCommand smycmd = new MySqlCommand(ssql, myconn);
                    mysdr = smycmd.ExecuteReader();
                    mysdr.Read();
                    if (mysdr.HasRows)
                    {
                        int epid = Convert.ToInt32(mysdr["EPID"].ToString().Trim());
                        if (epid == 1)
                        {
                            dataGridView1.Rows[i].Cells[4].Value = "系统管理员";
                        }
                        if (epid == 2)
                        {
                            dataGridView1.Rows[i].Cells[4].Value = "店长";
                        }
                        if (epid == 3)
                        {
                            dataGridView1.Rows[i].Cells[4].Value = "人事部";
                        }
                        if (epid == 4)
                        {
                            dataGridView1.Rows[i].Cells[4].Value = "销售部";
                        }
                        if (epid == 5)
                        {
                            dataGridView1.Rows[i].Cells[4].Value = "库存管理部";
                        }
                        if (epid == 6)
                        {
                            dataGridView1.Rows[i].Cells[4].Value = "销售员";
                        }
                    }
                    smycmd.Dispose();
                    mysdr.Dispose();
                }
                mysda.Dispose();
                mycmd.Dispose();
                mysdr.Dispose();
                myconn.Close();
            }
        }
        #endregion

        #region 顶部菜单-添加、修改、删除、导出亮 保存、取消灭
        private void topmenu_cancel()
        {
            txtbox_LoginName.Text = "";
            txtbox_Name.Text = "";
            cmbox_Sex.SelectedIndex = -1;
            txtbox_Age.Text = "";
            cmbox_Position.SelectedIndex = -1;
            txtbox_Tel.Text = "";
            txtbox_Passwd.Text = "";
            txtbox_Address.Text = "";

            txtbox_LoginName.Enabled = false;
            txtbox_Name.Enabled = false;
            cmbox_Sex.Enabled = false;
            txtbox_Age.Enabled = false;
            cmbox_Position.Enabled = false;
            txtbox_Tel.Enabled = false;
            txtbox_Passwd.Enabled = false;
            txtbox_Address.Enabled = false;

            tsbtn_Save.Enabled = false;
            tsbtn_Cancel.Enabled = false;
            tsbtn_Add.Enabled = true;
            tsbtn_Edit.Enabled = true;
            tsbtn_Del.Enabled = true;
            tsbtn_Export.Enabled = true;
        }
        #endregion
    }
}