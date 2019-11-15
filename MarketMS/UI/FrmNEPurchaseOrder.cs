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
    public partial class FrmNEPurchaseOrder : Form
    {
        public int po;
        public string id, poid, pogsupplier, podate, pogid, pogname, pogcid, pogunit, pogbid, pogprice, poamount, pogminimuminventory, pogshelflife, pogshelflife_month, pogshelflife_day, pogproductiondate, pognotes;

        string pobh = "PO" + DateTime.Now.ToString("yyyyMMddhhmmss");

        #region 按下ESC键关闭当前窗口
        private void FrmNEPurchaseOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
        #endregion

        #region 商品编号后面...单击事件
        private void btn_MorePOGID_Click(object sender, EventArgs e)
        {
            FrmGoods fg = new FrmGoods();
            fg.pogid = txtbox_POGID;
            fg.pogname = txtbox_POGName;
            fg.pogcid = cmbox_POGCID;
            fg.pogunit = cmbox_POGUnit;
            fg.pogbid = txtbox_POGBid;
            fg.pogprice = txtbox_POGPrice;
            fg.pogminimuminventory = txtbox_POGMinimumInventory;
            fg.Show();
        }
        #endregion

        #region 供应商后面...单击事件
        private void btn_MorePOGSupplier_Click(object sender, EventArgs e)
        {
            FrmGoodsSupplierList fgsl = new FrmGoodsSupplierList();
            fgsl.txt = txtbox_POGSupplier;
            fgsl.Show();
        }
        #endregion

        #region 类别后面+单击事件
        private void btn_AddPOGCID_Click(object sender, EventArgs e)
        {
            FrmGoodsCategory fgc = new FrmGoodsCategory();
            fgc.cmb = cmbox_POGCID;
            fgc.Show();
        }
        #endregion

        public FrmNEPurchaseOrder()
        {
            InitializeComponent();
        }

        #region 窗体加载事件
        private void FrmNEPurchaseOrder_Load(object sender, EventArgs e)
        {
            if (po == 0)
            {
                txtbox_POGID.Enabled = false;
                txtbox_POGName.Enabled = false;
                cmbox_POGCID.Enabled = false;
                cmbox_POGUnit.Enabled = false;

                txtbox_POID.Text = pobh;
                txtbox_POGSupplier.Text = "";
                dtp_PODate.Value = DateTime.Now;
                txtbox_POGID.Text = "";
                txtbox_POGName.Text = "";
                cmbox_POGCID.Text = "";
                cmbox_POGUnit.Text = "";
                txtbox_POGBid.Text = "";
                txtbox_POGPrice.Text = "";
                txtbox_POAmount.Text = "";
                txtbox_POGMinimumInventory.Text = "";
                txtbox_POGShelfLife_MonthDay.Text = "";
                cmbox_POGShelfLife_MonthDay.SelectedIndex = 0;
                dtp_POGProductionDate.Value = DateTime.Now;
                richtxtbox_POGNotes.Text = "";
            }
            if (po == 1)
            {
                txtbox_POGID.Enabled = false;
                txtbox_POGName.Enabled = false;
                cmbox_POGCID.Enabled = false;
                cmbox_POGUnit.Enabled = false;

                txtbox_POID.Text = pobh;//进货编号
                txtbox_POGSupplier.Text = pogsupplier;//供应商
                dtp_PODate.Value = Convert.ToDateTime(podate);//进货日期
                txtbox_POGID.Text = pogid;//商品编号
                txtbox_POGName.Text = pogname;//商品名称
                cmbox_POGCID.Text = pogcid;//类别
                cmbox_POGUnit.Text = pogunit;//单位
                txtbox_POGBid.Text = pogbid;//进价
                txtbox_POGPrice.Text = pogprice;//售价
                txtbox_POAmount.Text = poamount;//进货数量
                txtbox_POGMinimumInventory.Text = pogminimuminventory;//最小库存
                if (pogshelflife.Contains("个") && !pogshelflife.Contains("天"))
                {
                    int n = pogshelflife.IndexOf("个");
                    pogshelflife_month = pogshelflife.Substring(0, n);
                    txtbox_POGShelfLife_MonthDay.Text = pogshelflife_month;//保质期月份
                    cmbox_POGShelfLife_MonthDay.SelectedIndex = 0;//保质期下拉菜单
                }
                if (!pogshelflife.Contains("个") && pogshelflife.Contains("天"))
                {
                    int n = pogshelflife.IndexOf("天");
                    pogshelflife_day = pogshelflife.Substring(0, n);
                    txtbox_POGShelfLife_MonthDay.Text = pogshelflife_day;//保质期天数
                    cmbox_POGShelfLife_MonthDay.SelectedIndex = 1;//保质期下拉菜单
                }
                dtp_POGProductionDate.Value = Convert.ToDateTime(pogproductiondate);//生产日期
                richtxtbox_POGNotes.Text = pognotes;//备注
            }
        }
        #endregion

        #region 确定按钮单击事件
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (txtbox_POID.Text == "")
            {
                MessageBox.Show("请输入进货编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                if (txtbox_POGID.Text == "")
                {
                    MessageBox.Show("请输入商品编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (txtbox_POGName.Text == "")
                    {
                        MessageBox.Show("请输入商品名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MySqlConnection myconn = BaseClass.DBConn.MyConn();
                        myconn.Open();
                        string sql = "select count(*) from tb_PurchaseOrder where POID=@poid";
                        MySqlCommand mycmd = new MySqlCommand(sql, myconn);
                        mycmd.Parameters.Add("@poid", MySqlDbType.VarChar, 20).Value = poid;
                        int n = Convert.ToInt32(mycmd.ExecuteScalar());
                        mycmd.Dispose();
                        if (n > 0)
                        {
                            //修改
                            sql = "update tb_PurchaseOrder set PODate=@podate,POGID=@pogid,POGName=@pogname,POGCID=@pogcid,POGPrice=@pogprice,POGBid=@pogbid,POAmount=@poamount,POGMinimumInventory=@pogminimuminventory,POGUnit=@pogunit,POGShelfLife=@pogshelflife,POGProductionDate=@pogproductiondate,POGSupplier=@pogsupplier,POGNotes=@pognotes where ID=@id";
                            mycmd = new MySqlCommand(sql, myconn);
                            mycmd.Parameters.Add("@podate", MySqlDbType.Date).Value = dtp_PODate.Value;
                            mycmd.Parameters.Add("@pogid", MySqlDbType.VarChar, 20).Value = txtbox_POGID.Text.Trim();
                            mycmd.Parameters.Add("@pogname", MySqlDbType.VarChar, 20).Value = txtbox_POGName.Text.Trim();

                            string ssql = "select * from tb_GoodsCategory where GCName='" + cmbox_POGCID.Text + "'";
                            MySqlCommand smycmd = new MySqlCommand(ssql, myconn);
                            int q = Convert.ToInt32(smycmd.ExecuteScalar());
                            if (q > 0)
                            {
                                MySqlDataReader mysdr = smycmd.ExecuteReader();
                                mysdr.Read();
                                if (mysdr.HasRows)
                                {
                                    if (cmbox_POGCID.Text == mysdr["GCName"].ToString().Trim())
                                    {
                                        mycmd.Parameters.Add("@pogcid", MySqlDbType.VarChar, 20).Value = mysdr["GCID"].ToString().Trim();
                                    }
                                }
                                mysdr.Dispose();
                                smycmd.Dispose();

                                mycmd.Parameters.Add("@pogprice", MySqlDbType.Decimal, 18).Value = txtbox_POGPrice.Text.Trim();
                                mycmd.Parameters.Add("@pogbid", MySqlDbType.Decimal, 18).Value = txtbox_POGBid.Text.Trim();
                                mycmd.Parameters.Add("@poamount", MySqlDbType.Int32, 20).Value = txtbox_POAmount.Text.Trim();

                                #region 库存数量变化
                                string gssql = "select * from tb_Goods where GName='" + txtbox_POGName.Text + "'";
                                MySqlCommand gsmycmd = new MySqlCommand(gssql, myconn);
                                int gs = Convert.ToInt32(gsmycmd.ExecuteScalar());
                                MySqlDataReader gsmysdr = gsmycmd.ExecuteReader();
                                if (gsmysdr.HasRows)
                                {
                                    if (gs > 0)
                                    {
                                        gsmysdr.Read();
                                        string gsql = "update tb_Goods set GID=@pogid,GCID=@pogcid,GPrice=@pogprice,GBid=@pogbid,GAmount=@poamount,GMinimumInventory=@pogminimuminventory,GUnit=@pogunit,GShelfLife=@pogshelflife,GProductionDate=@pogproductiondate,GSupplier=@pogsupplier,GNotes=@pognotes where GName=@pogname";
                                        MySqlCommand gmycmd = new MySqlCommand(gsql, myconn);

                                        //int amount = Convert.ToInt32(txtbox_POAmount.Text.Trim()) + Convert.ToInt32(gsmysdr[6].ToString().Trim());

                                        int amount;
                                        if (Convert.ToInt32(txtbox_POAmount.Text.Trim()) == Convert.ToInt32(poamount.ToString().Trim()))
                                        {
                                            amount = Convert.ToInt32(gsmysdr[6].ToString().Trim());
                                        }
                                        else if (Convert.ToInt32(txtbox_POAmount.Text.Trim()) > Convert.ToInt32(poamount.ToString().Trim()))
                                        {
                                            amount = Convert.ToInt32(txtbox_POAmount.Text.Trim()) - Convert.ToInt32(poamount.ToString().Trim()) + Convert.ToInt32(gsmysdr[6].ToString().Trim());
                                        }
                                        else if (Convert.ToInt32(txtbox_POAmount.Text.Trim()) < Convert.ToInt32(poamount.ToString().Trim()))
                                        {
                                            amount = Convert.ToInt32(gsmysdr[6].ToString().Trim()) - (Convert.ToInt32(poamount.ToString().Trim()) - Convert.ToInt32(txtbox_POAmount.Text.Trim()));
                                        }
                                        else
                                        {
                                            amount = 0;
                                            MessageBox.Show("库存数量变化出现异常，请联系系统开发者！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }

                                        gsmysdr.Dispose();
                                        gmycmd.Parameters.Add("@pogid", MySqlDbType.VarChar, 20).Value = txtbox_POGID.Text.Trim();

                                        string gcidsql = "select * from tb_GoodsCategory where GCName='" + cmbox_POGCID.Text + "'";
                                        MySqlCommand gcidmycmd = new MySqlCommand(gcidsql, myconn);
                                        int id = Convert.ToInt32(gcidmycmd.ExecuteScalar());
                                        MySqlDataReader gcidmysdr = gcidmycmd.ExecuteReader();
                                        gcidmysdr.Read();
                                        if (id > 0)
                                        {
                                            if (gcidmysdr.HasRows)
                                            {
                                                if (cmbox_POGCID.Text == gcidmysdr["GCName"].ToString().Trim())
                                                {
                                                    gmycmd.Parameters.Add("@pogcid", MySqlDbType.VarChar, 20).Value = gcidmysdr["GCID"].ToString().Trim();
                                                }
                                            }
                                            gcidmysdr.Dispose();
                                            gcidmycmd.Dispose();

                                            gmycmd.Parameters.Add("@pogprice", MySqlDbType.VarChar, 20).Value = txtbox_POGPrice.Text.Trim();
                                            gmycmd.Parameters.Add("@pogbid", MySqlDbType.VarChar, 20).Value = txtbox_POGBid.Text.Trim();
                                            gmycmd.Parameters.Add("@poamount", MySqlDbType.VarChar, 20).Value = amount;
                                            gmycmd.Parameters.Add("@pogminimuminventory", MySqlDbType.VarChar, 20).Value = txtbox_POGMinimumInventory.Text.Trim();
                                            gmycmd.Parameters.Add("@pogunit", MySqlDbType.VarChar, 20).Value = cmbox_POGUnit.Text.Trim();
                                            gmycmd.Parameters.Add("@pogshelflife", MySqlDbType.VarChar, 20).Value = txtbox_POGShelfLife_MonthDay.Text.Trim() + cmbox_POGShelfLife_MonthDay.Text;
                                            gmycmd.Parameters.Add("@pogproductiondate", MySqlDbType.VarChar, 20).Value = dtp_POGProductionDate.Value;
                                            gmycmd.Parameters.Add("@pogsupplier", MySqlDbType.VarChar, 20).Value = txtbox_POGSupplier.Text.Trim();
                                            gmycmd.Parameters.Add("@pognotes", MySqlDbType.VarChar, 20).Value = richtxtbox_POGNotes.Text.Trim();
                                            gmycmd.Parameters.Add("@pogname", MySqlDbType.VarChar, 20).Value = txtbox_POGName.Text.Trim();
                                            gmycmd.ExecuteNonQuery();
                                        }
                                        else
                                        {
                                            //不能找到分类
                                            MessageBox.Show("没有找到类别，请先新建！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        gmycmd.Dispose();
                                        gsmycmd.Dispose();
                                    }
                                }
                                #endregion

                                mycmd.Parameters.Add("@pogminimuminventory", MySqlDbType.Int32, 20).Value = txtbox_POGMinimumInventory.Text.Trim();
                                mycmd.Parameters.Add("@pogunit", MySqlDbType.VarChar, 20).Value = cmbox_POGUnit.Text.Trim();
                                mycmd.Parameters.Add("@pogshelflife", MySqlDbType.VarChar, 20).Value = txtbox_POGShelfLife_MonthDay.Text.Trim() + cmbox_POGShelfLife_MonthDay.Text;
                                mycmd.Parameters.Add("@pogproductiondate", MySqlDbType.Date).Value = dtp_POGProductionDate.Value;
                                mycmd.Parameters.Add("@pogsupplier", MySqlDbType.VarChar, 20).Value = txtbox_POGSupplier.Text.Trim();
                                mycmd.Parameters.Add("@pognotes", MySqlDbType.VarChar, 50).Value = richtxtbox_POGNotes.Text.Trim();
                                mycmd.Parameters.Add("@id", MySqlDbType.Int32, 11).Value = id;
                                mycmd.ExecuteNonQuery();
                                myconn.Close();

                                MessageBox.Show("进货单修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            sql = "select count(*) from tb_PurchaseOrder where POID=@poid";
                            mycmd = new MySqlCommand(sql, myconn);
                            mycmd.Parameters.Add("@poid", MySqlDbType.VarChar, 20).Value = txtbox_POID.Text;
                            n = Convert.ToInt32(mycmd.ExecuteScalar());
                            if (n > 0)
                            {
                                MessageBox.Show("进货单'" + txtbox_POID.Text + "'已存在！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtbox_POID.Focus();
                            }
                            else
                            {
                                //添加
                                sql = "insert into tb_PurchaseOrder(POID,PODate,POGID,POGName,POGCID,POGPrice,POGBid,POAmount,POGMinimumInventory,POGUnit,POGShelfLife,POGProductionDate,POGSupplier,POGNotes) values(@poid, @podate, @pogid, @pogname, @pogcid, @pogprice, @pogbid, @poamount, @pogminimuminventory, @pogunit, @pogshelflife, @pogproductiondate, @pogsupplier, @pognotes)";
                                mycmd = new MySqlCommand(sql, myconn);
                                mycmd.Parameters.Add("@poid", MySqlDbType.VarChar, 20).Value = pobh;
                                mycmd.Parameters.Add("@podate", MySqlDbType.Date).Value = dtp_PODate.Value;
                                mycmd.Parameters.Add("@pogid", MySqlDbType.VarChar, 20).Value = txtbox_POGID.Text.Trim();
                                mycmd.Parameters.Add("@pogname", MySqlDbType.VarChar, 20).Value = txtbox_POGName.Text.Trim();

                                MySqlConnection smyconn = BaseClass.DBConn.MyConn();
                                smyconn.Open();
                                string ssql = "select * from tb_GoodsCategory where GCName='" + cmbox_POGCID.Text + "'";
                                MySqlCommand smycmd = new MySqlCommand(ssql, smyconn);
                                int q = Convert.ToInt32(smycmd.ExecuteScalar());
                                MySqlDataReader mysdr = smycmd.ExecuteReader();
                                mysdr.Read();
                                if (q > 0)
                                {
                                    if (mysdr.HasRows)
                                    {
                                        if (cmbox_POGCID.Text == mysdr["GCName"].ToString().Trim())
                                        {
                                            mycmd.Parameters.Add("@pogcid", MySqlDbType.VarChar, 20).Value = mysdr["GCID"].ToString().Trim();
                                        }
                                    }
                                    mysdr.Dispose();
                                    smycmd.Dispose();
                                    smyconn.Close();

                                    mycmd.Parameters.Add("@pogprice", MySqlDbType.Decimal, 18).Value = txtbox_POGPrice.Text.Trim();
                                    mycmd.Parameters.Add("@pogbid", MySqlDbType.Decimal, 18).Value = txtbox_POGBid.Text.Trim();
                                    mycmd.Parameters.Add("@poamount", MySqlDbType.Int32, 20).Value = txtbox_POAmount.Text.Trim();

                                    #region 库存数量变化
                                    string gssql = "select * from tb_Goods where GName='" + txtbox_POGName.Text + "'";
                                    MySqlCommand gsmycmd = new MySqlCommand(gssql, myconn);
                                    int gs = Convert.ToInt32(gsmycmd.ExecuteScalar());
                                    MySqlDataReader gsmysdr = gsmycmd.ExecuteReader();
                                    if (gsmysdr.HasRows)
                                    {
                                        if (gs > 0)
                                        {
                                            gsmysdr.Read();
                                            string gsql = "update tb_Goods set GID=@pogid,GCID=@pogcid,GPrice=@pogprice,GBid=@pogbid,GAmount=@poamount,GMinimumInventory=@pogminimuminventory,GUnit=@pogunit,GShelfLife=@pogshelflife,GProductionDate=@pogproductiondate,GSupplier=@pogsupplier,GNotes=@pognotes where GName=@pogname";
                                            MySqlCommand gmycmd = new MySqlCommand(gsql, myconn);
                                            int amount = Convert.ToInt32(txtbox_POAmount.Text.Trim()) + Convert.ToInt32(gsmysdr[6].ToString().Trim());
                                            gsmysdr.Dispose();
                                            gmycmd.Parameters.Add("@pogid", MySqlDbType.VarChar, 20).Value = txtbox_POGID.Text.Trim();

                                            string gcidsql = "select * from tb_GoodsCategory where GCName='" + cmbox_POGCID.Text + "'";
                                            MySqlCommand gcidmycmd = new MySqlCommand(gcidsql, myconn);
                                            int id = Convert.ToInt32(gcidmycmd.ExecuteScalar());
                                            MySqlDataReader gcidmysdr = gcidmycmd.ExecuteReader();
                                            gcidmysdr.Read();
                                            if (id > 0)
                                            {
                                                if (gcidmysdr.HasRows)
                                                {
                                                    if (cmbox_POGCID.Text == gcidmysdr["GCName"].ToString().Trim())
                                                    {
                                                        gmycmd.Parameters.Add("@pogcid", MySqlDbType.VarChar, 20).Value = gcidmysdr["GCID"].ToString().Trim();
                                                    }
                                                }
                                                gcidmysdr.Dispose();
                                                gcidmycmd.Dispose();

                                                gmycmd.Parameters.Add("@pogprice", MySqlDbType.VarChar, 20).Value = txtbox_POGPrice.Text.Trim();
                                                gmycmd.Parameters.Add("@pogbid", MySqlDbType.VarChar, 20).Value = txtbox_POGBid.Text.Trim();
                                                gmycmd.Parameters.Add("@poamount", MySqlDbType.VarChar, 20).Value = amount;
                                                gmycmd.Parameters.Add("@pogminimuminventory", MySqlDbType.VarChar, 20).Value = txtbox_POGMinimumInventory.Text.Trim();
                                                gmycmd.Parameters.Add("@pogunit", MySqlDbType.VarChar, 20).Value = cmbox_POGUnit.Text.Trim();
                                                gmycmd.Parameters.Add("@pogshelflife", MySqlDbType.VarChar, 20).Value = txtbox_POGShelfLife_MonthDay.Text.Trim() + cmbox_POGShelfLife_MonthDay.Text;
                                                gmycmd.Parameters.Add("@pogproductiondate", MySqlDbType.VarChar, 20).Value = dtp_POGProductionDate.Value;
                                                gmycmd.Parameters.Add("@pogsupplier", MySqlDbType.VarChar, 20).Value = txtbox_POGSupplier.Text.Trim();
                                                gmycmd.Parameters.Add("@pognotes", MySqlDbType.VarChar, 20).Value = richtxtbox_POGNotes.Text.Trim();
                                                gmycmd.Parameters.Add("@pogname", MySqlDbType.VarChar, 20).Value = txtbox_POGName.Text.Trim();
                                                gmycmd.ExecuteNonQuery();
                                            }
                                            else
                                            {
                                                //不能找到分类
                                                MessageBox.Show("没有找到类别，请先新建！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                            gmycmd.Dispose();
                                            gsmycmd.Dispose();
                                        }
                                    }
                                    #endregion

                                    mycmd.Parameters.Add("@pogminimuminventory", MySqlDbType.Int32, 20).Value = txtbox_POGMinimumInventory.Text.Trim();
                                    mycmd.Parameters.Add("@pogunit", MySqlDbType.VarChar, 20).Value = cmbox_POGUnit.Text.Trim();
                                    mycmd.Parameters.Add("@pogshelflife", MySqlDbType.VarChar, 20).Value = txtbox_POGShelfLife_MonthDay.Text.Trim() + cmbox_POGShelfLife_MonthDay.Text;
                                    mycmd.Parameters.Add("@pogproductiondate", MySqlDbType.Date).Value = dtp_POGProductionDate.Value;
                                    mycmd.Parameters.Add("@pogsupplier", MySqlDbType.VarChar, 20).Value = txtbox_POGSupplier.Text.Trim();
                                    mycmd.Parameters.Add("@pognotes", MySqlDbType.VarChar, 50).Value = richtxtbox_POGNotes.Text.Trim();
                                    mycmd.ExecuteNonQuery();
                                    myconn.Close();

                                    MessageBox.Show("进货单'" + txtbox_POID.Text + "'添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }
        }
        #endregion

        #region 取消按钮单击事件
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}