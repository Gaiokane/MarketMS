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
    public partial class FrmNEGoods : Form
    {
        public bool Active = false;
        public int ne;
        //string gbh = "G" + DateTime.Now.ToString("yyyyMMddHHmmss");
        string gbh = "G" + DateTime.Now.ToString("HHmmssfff");

        public string gid, gname, gcid, gprice, gbid, gunit, gsupplier, gnotes, id;

        public FrmNEGoods()
        {
            InitializeComponent();
        }

        #region 窗体加载事件
        private void FrmNEGoods_Load(object sender, EventArgs e)
        {
            if (ne == 0)//添加
            {
                txtbox_GID.Text = gbh;
                txtbox_GName.Text = "";
                cmbox_GCID.Text = "";
                txtbox_GPrice.Text = "";
                txtbox_GBid.Text = "";
                cmbox_GUnit.Text = "";
                txtbox_GSupplier.Text = "";
                richtxtbox_GNotes.Text = "";
            }
            if (ne == 1)//修改
            {
                txtbox_GID.Text = gid;
                txtbox_GName.Text = gname;
                cmbox_GCID.Text = gcid;
                txtbox_GPrice.Text = gprice.ToString().Trim();
                txtbox_GBid.Text = gbid.ToString().Trim();
                cmbox_GUnit.Text = gunit;
                txtbox_GSupplier.Text = gsupplier;
                richtxtbox_GNotes.Text = gnotes;
            }
        }
        #endregion

        #region 保存按钮单击事件
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txtbox_GName.Text == "")
            {
                MessageBox.Show("请输入商品名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MySqlConnection myconn = BaseClass.DBConn.MyConn();
                myconn.Open();
                string sql = "select count(*) from tb_Goods where GID=@gid";
                MySqlCommand mycmd = new MySqlCommand(sql, myconn);
                mycmd.Parameters.Add("@gid", MySqlDbType.VarChar, 20).Value = txtbox_GID.Text;
                int n = Convert.ToInt32(mycmd.ExecuteScalar());
                mycmd.Dispose();
                if (n > 0)
                {
                    //修改
                    sql = "update tb_Goods set GID=@gid,GName=@gname,GCID=@gcid,GPrice=@gprice,GBid=@gbid,GUnit=@gunit,GSupplier=@gsupplier,GNotes=@gnotes where ID=@ID";
                    mycmd = new MySqlCommand(sql, myconn);
                    mycmd.Parameters.Add("@gid", MySqlDbType.VarChar, 20).Value = txtbox_GID.Text.Trim();
                    mycmd.Parameters.Add("@gname", MySqlDbType.VarChar, 20).Value = txtbox_GName.Text.Trim();

                    string ssql = "select * from tb_GoodsCategory where GCName='" + cmbox_GCID.Text + "'";
                    MySqlCommand smycmd = new MySqlCommand(ssql, myconn);
                    int q = Convert.ToInt32(smycmd.ExecuteScalar());
                    MySqlDataReader mysdr = smycmd.ExecuteReader();
                    mysdr.Read();
                    if (q > 0)
                    {
                        if (mysdr.HasRows)
                        {
                            if (cmbox_GCID.Text == mysdr["GCName"].ToString().Trim())
                            {
                                mycmd.Parameters.Add("@gcid", MySqlDbType.VarChar, 20).Value = mysdr["GCID"].ToString().Trim();
                            }
                        }
                        mysdr.Dispose();
                        smycmd.Dispose();

                        mycmd.Parameters.Add("@gprice", MySqlDbType.Decimal, 18).Value = Convert.ToDecimal(txtbox_GPrice.Text.Trim());
                        mycmd.Parameters.Add("@gbid", MySqlDbType.Decimal, 18).Value = Convert.ToDecimal(txtbox_GBid.Text.Trim());
                        mycmd.Parameters.Add("@gunit", MySqlDbType.VarChar, 20).Value = cmbox_GUnit.Text.Trim();
                        mycmd.Parameters.Add("@gsupplier", MySqlDbType.VarChar, 20).Value = txtbox_GSupplier.Text.Trim();
                        mycmd.Parameters.Add("@gnotes", MySqlDbType.VarChar, 50).Value = richtxtbox_GNotes.Text.Trim();
                        mycmd.Parameters.Add("@id", MySqlDbType.Int32, 11).Value = Convert.ToInt32(id);
                        mycmd.ExecuteNonQuery();
                        myconn.Close();

                        MessageBox.Show("商品'" + txtbox_GName.Text + "'修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        //不能找到分类
                        MessageBox.Show("没有找到类别，请先新建！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    sql = "select count(*) from tb_Goods where GName=@gname";
                    mycmd = new MySqlCommand(sql, myconn);
                    mycmd.Parameters.Add("@gname", MySqlDbType.VarChar, 20).Value = txtbox_GID.Text;
                    n = Convert.ToInt32(mycmd.ExecuteScalar());
                    if (n > 0)
                    {
                        MessageBox.Show("商品'" + txtbox_GName.Text + "'已存在！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtbox_GName.Focus();
                    }
                    else
                    {
                        //添加
                        sql = "insert into tb_Goods(GID,GName,GCID,GPrice,GBid,GAmount,GUnit,GSupplier,GNotes) values(@gid,@gname,@gcid,@gprice,@gbid,@gamount,@gunit,@gsupplier,@gnotes)";
                        mycmd = new MySqlCommand(sql, myconn);
                        mycmd.Parameters.Add("@gid", MySqlDbType.VarChar, 20).Value = txtbox_GID.Text.Trim();
                        mycmd.Parameters.Add("@gname", MySqlDbType.VarChar, 20).Value = txtbox_GName.Text.Trim();

                        MySqlConnection smyconn = BaseClass.DBConn.MyConn();
                        smyconn.Open();
                        string ssql = "select * from tb_GoodsCategory where GCName='" + cmbox_GCID.Text + "'";
                        MySqlCommand smycmd = new MySqlCommand(ssql, smyconn);
                        int q = Convert.ToInt32(smycmd.ExecuteScalar());
                        MySqlDataReader mysdr = smycmd.ExecuteReader();
                        mysdr.Read();
                        if (q > 0)
                        {
                            if (mysdr.HasRows)
                            {
                                if (cmbox_GCID.Text == mysdr["GCName"].ToString().Trim())
                                {
                                    mycmd.Parameters.Add("@gcid", MySqlDbType.VarChar, 20).Value = mysdr["GCID"].ToString().Trim();
                                }
                            }
                            mysdr.Dispose();
                            smycmd.Dispose();
                            smyconn.Close();

                            mycmd.Parameters.Add("@gprice", MySqlDbType.Decimal, 18).Value = Convert.ToDecimal(txtbox_GPrice.Text.Trim());
                            mycmd.Parameters.Add("@gbid", MySqlDbType.Decimal, 18).Value = Convert.ToDecimal(txtbox_GBid.Text.Trim());
                            mycmd.Parameters.Add("@gamount", MySqlDbType.Int32, 20).Value = "0";
                            mycmd.Parameters.Add("@gunit", MySqlDbType.VarChar, 20).Value = cmbox_GUnit.Text.Trim();
                            mycmd.Parameters.Add("@gsupplier", MySqlDbType.VarChar, 20).Value = txtbox_GSupplier.Text.Trim();
                            mycmd.Parameters.Add("@gnotes", MySqlDbType.VarChar, 50).Value = richtxtbox_GNotes.Text.Trim();
                            mycmd.ExecuteNonQuery();
                            myconn.Close();

                            MessageBox.Show("商品'" + txtbox_GName.Text + "'添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            //不能找到分类
                            MessageBox.Show("没有找到类别，请先新建！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
        #endregion

        #region 取消按钮单击事件
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 类别后面+单击事件
        private void btn_AddCategory_Click(object sender, EventArgs e)
        {
            Active = true;
            FrmGoodsCategory fgc = new FrmGoodsCategory();
            fgc.cmb = cmbox_GCID;
            fgc.Show();
        }
        #endregion

        #region 供应商后面...单击事件
        private void btn_MoreSupplier_Click(object sender, EventArgs e)
        {
            FrmGoodsSupplierList fgsl = new FrmGoodsSupplierList();
            fgsl.txt = txtbox_GSupplier;
            fgsl.Show();
        }
        #endregion

        #region 按下ESC键关闭当前窗口
        private void FrmNEGoods_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
        #endregion
    }
}