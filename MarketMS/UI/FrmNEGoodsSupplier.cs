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
    public partial class FrmNEGoodsSupplier : Form
    {
        public int a;
        public string gsname, gspname, gstel, gsaddress, gsnotes, gsid;

        public FrmNEGoodsSupplier()
        {
            InitializeComponent();
        }

        #region 窗体加载事件
        private void FrmNESupplier_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            if (a == 1)
            {
                txtbox_GSName.Text = gsname;
                txtbox_GSPName.Text = gspname;
                txtbox_GSTel.Text = gstel;
                txtbox_GSAddress.Text = gsaddress;
                richtxtbox_GSNotes.Text = gsnotes;
            }
            else
            {
                txtbox_GSName.Text = "";
                txtbox_GSPName.Text = "";
                txtbox_GSTel.Text = "";
                txtbox_GSAddress.Text = "";
                richtxtbox_GSNotes.Text = "";
            }
        }
        #endregion

        #region 确定按钮单击事件
        private void btn_SSubmit_Click(object sender, EventArgs e)
        {
            MySqlConnection myconn = BaseClass.DBConn.MyConn();
            myconn.Open();
            string sql = "select count(*) from tb_GoodsSupplier where GSName=@gsname";
            MySqlCommand mycmd = new MySqlCommand(sql, myconn);
            mycmd.Parameters.Add("@gsname", MySqlDbType.VarChar, 20).Value = gsname;
            int n = Convert.ToInt32(mycmd.ExecuteScalar());
            if (n > 0)
            {
                //修改
                sql = "update tb_GoodsSupplier set GSName=@gsname,GSPName=@gspname,GSTel=@gstel,GSAddress=@gsaddress,GSNotes=@gsnotes where GSID=@gsid";
                mycmd = new MySqlCommand(sql, myconn);
                mycmd.Parameters.Add("@gsname", MySqlDbType.VarChar, 20).Value = txtbox_GSName.Text.Trim();
                mycmd.Parameters.Add("@gspname", MySqlDbType.VarChar, 20).Value = txtbox_GSPName.Text.Trim();
                mycmd.Parameters.Add("@gstel", MySqlDbType.VarChar, 20).Value = txtbox_GSTel.Text.Trim();
                mycmd.Parameters.Add("@gsaddress", MySqlDbType.VarChar, 50).Value = txtbox_GSAddress.Text.Trim();
                mycmd.Parameters.Add("@gsnotes", MySqlDbType.VarChar, 50).Value = richtxtbox_GSNotes.Text.Trim();
                mycmd.Parameters.Add("@gsid", MySqlDbType.Int32, 20).Value = gsid;
                mycmd.ExecuteNonQuery();
                myconn.Close();

                FrmGoodsSupplier s = (FrmGoodsSupplier)this.Owner;//委托父窗体
                s.BindData();
                MessageBox.Show("供应商'" + gsname + "'修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                sql = "select count(*) from tb_GoodsSupplier where GSName=@gsname";
                mycmd = new MySqlCommand(sql, myconn);
                mycmd.Parameters.Add("@gsname", MySqlDbType.VarChar, 20).Value = txtbox_GSName.Text;
                n = Convert.ToInt32(mycmd.ExecuteScalar());
                if (n > 0)
                {
                    MessageBox.Show("供应商'" + txtbox_GSName.Text + "'已存在！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbox_GSName.Focus();
                }
                else
                {
                    //添加
                    sql = "insert into tb_GoodsSupplier(GSName,GSPName,GSTel,GSAddress,GSNotes) values(@gsname,@gspname,@gstel,@gsaddress,@gsnotes)";
                    mycmd = new MySqlCommand(sql, myconn);
                    mycmd.Parameters.Add("@gsname", MySqlDbType.VarChar, 20).Value = txtbox_GSName.Text.Trim();
                    mycmd.Parameters.Add("@gspname", MySqlDbType.VarChar, 20).Value = txtbox_GSPName.Text.Trim();
                    mycmd.Parameters.Add("@gstel", MySqlDbType.VarChar, 20).Value = txtbox_GSTel.Text.Trim();
                    mycmd.Parameters.Add("@gsaddress", MySqlDbType.VarChar, 50).Value = txtbox_GSAddress.Text.Trim();
                    mycmd.Parameters.Add("@gsnotes", MySqlDbType.VarChar, 50).Value = richtxtbox_GSNotes.Text.Trim();
                    mycmd.ExecuteNonQuery();
                    myconn.Close();

                    FrmGoodsSupplier s = (FrmGoodsSupplier)this.Owner;//委托父窗体
                    s.BindData();
                    MessageBox.Show("供应商'" + txtbox_GSName.Text + "'添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
        #endregion

        #region 取消按钮单击事件
        private void btn_SCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 按下ESC键关闭当前窗口
        private void FrmNESupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
        #endregion
    }
}