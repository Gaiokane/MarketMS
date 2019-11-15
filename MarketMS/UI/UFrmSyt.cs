using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using ZXing;
using ZXing.QrCode;

namespace MarketMS.UI
{
    public partial class UFrmSyt : UserControl
    {
        DataTable dtgoods;
        DataTable dtprintorder = new DataTable();
        public string oeid;
        int xj = 0, alipay = 0;
        string opm;

        public UFrmSyt()
        {
            InitializeComponent();
        }

        #region 实时更新总价
        private void timer1_Tick(object sender, EventArgs e)
        {
            double sumprice = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                sumprice += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
            }
            lab_price_yf.Text = sumprice.ToString();
            zljs();
        }
        #endregion

        #region 找零计算
        private void zljs()
        {
            if (lab_price_yf.Text != "0")
            {
                btn_jzfs_Alipay.Enabled = true;
                lab_price_zl.Text = "0";
                Regex s = new Regex(@"^[0-9]{1,}([.]{1}[0-9]{1,2})?$");
                if (s.IsMatch(txtbox_price_sf.Text.Trim()))
                {
                    if (Convert.ToDouble(txtbox_price_sf.Text.Trim()) != 0)
                    {
                        if (Convert.ToDouble(txtbox_price_sf.Text.Trim()) - Convert.ToDouble(lab_price_yf.Text.Trim()) >= 0)
                        {
                            lab_price_zl.Text = (Convert.ToDouble(txtbox_price_sf.Text.Trim()) - Convert.ToDouble(lab_price_yf.Text.Trim())).ToString();
                            btn_jzfs_cash.Enabled = true;
                            lab_warning.Text = "";
                        }
                        else
                        {
                            lab_warning.Text = "付款金额不够！";
                            btn_jzfs_cash.Enabled = false;
                        }
                    }
                    else
                    {
                        btn_jzfs_cash.Enabled = false;
                    }
                }
                else if (txtbox_price_sf.Text.Trim() == "")
                {
                    btn_jzfs_cash.Enabled = false;
                }
                else
                {
                    lab_warning.Text = "输入为非金额数目！";
                    btn_jzfs_cash.Enabled = false;
                }
            }
            else
            {
                lab_warning.Text = "";
                btn_jzfs_cash.Enabled = false;
                btn_jzfs_Alipay.Enabled = false;
            }
        }
        #endregion

        #region 初始化
        private void initialize()
        {
            timer1.Start();
            btn_jzfs_cash.Enabled = false;
            lab_OrderNum.Text = "MMS" + DateTime.Now.ToString("yyyyMMddHHmmss");

            //string sql = "select * from tb_Goods where GAmount > 0";
            string sql = "select GID, GName, GCID, GPrice, GUnit, ID from tb_Goods where GAmount > 0";
            MySqlConnection myconn = BaseClass.DBConn.MyConn();
            myconn.Open();
            MySqlCommand mycmd = new MySqlCommand(sql, myconn);
            MySqlDataAdapter mysda = new MySqlDataAdapter(mycmd);
            DataTable dt = new DataTable();
            mysda.Fill(dt);
            mysda.Dispose();
            mycmd.Dispose();
            myconn.Close();
            dtgoods = dt;
            Column1.DataSource = dt;
            Column2.DataSource = dt;
            Column1.DisplayMember = "GID";
            Column2.DisplayMember = "GName";
        }
        #endregion

        #region 获取返回值
        private static object ExecuteScalar(string sql, MySqlParameter[] sp)
        {
            using (MySqlConnection myconn = BaseClass.DBConn.MyConn())
            {
                myconn.Open();
                MySqlCommand mycmd = new MySqlCommand(sql, myconn);
                for (int i = 0; i < sp.Length; i++)
                {
                    mycmd.Parameters.Add(sp[i]);
                }
                object b = mycmd.ExecuteScalar();
                mycmd.Dispose();
                myconn.Close();
                return b;
            }
        }
        #endregion

        #region 窗体加载事件
        private void UFrmSyt_Load(object sender, EventArgs e)
        {
            initialize();
        }
        #endregion

        #region 结账方式-现金 按钮单击事件
        private void btn_jzfs_cash_Click(object sender, EventArgs e)
        {
            xj++;
            printOrder();
            if (MessageBox.Show("找零：" + lab_price_zl.Text + "元，" + "是否打印购物清单？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                printDialog1.ShowDialog();
                printDocument1.Print();
            }
            if (saveOrder() > 1)
            {
                reset();
            }
        }
        #endregion

        #region 结账方式-支付宝 按钮单击事件
        private void btn_jzfs_Alipay_Click(object sender, EventArgs e)
        {
            FrmPayWithAlipay fpwa = new FrmPayWithAlipay();
            fpwa.oid = lab_OrderNum.Text.ToString().Trim();
            fpwa.price = lab_price_yf.Text.ToString().Trim();
            fpwa.Show();
            fpwa.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FPWA_Closed);
        }
        #endregion

        #region 当支付宝付款窗口关闭时事件
        private void FPWA_Closed(object sender, EventArgs e)
        {
            if (MessageBox.Show("已完成支付？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                alipay++;
                printOrder();
                if (MessageBox.Show("是否打印购物清单？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    printDialog1.ShowDialog();
                    printDocument1.Print();
                }
                if (saveOrder() > 1)
                {
                    reset();
                }
            }
            else
            {
                alipay = 0;
            }
        }
        #endregion

        #region 添加订单信息 更新库存
        private int saveOrder()
        {
            if (xj > 0)
            {
                opm = "现金";
            }
            if (alipay > 0)
            {
                opm = "支付宝";
            }
            FrmMain fm = new FrmMain();
            MySqlConnection myconn = BaseClass.DBConn.MyConn();
            myconn.Open();
            int a = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                string sql = "insert into tb_Order (OID, OGID, OGName, OGCID, OGAmount, OGPrice, OGUnit, OGSum, OEID, OPaymentMethod, IsReturn) values (@oid, @ogid, @ogname, @ogcid, @ogamount, @ogprice, @ogunit, @ogsum, @oeid, @opaymentmethod, @isreturn)";
                MySqlCommand mycmd = new MySqlCommand(sql, myconn);
                mycmd.Parameters.Add("@oid", MySqlDbType.VarChar, 20).Value = lab_OrderNum.Text.ToString().Trim();
                mycmd.Parameters.Add("@ogid", MySqlDbType.VarChar, 20).Value = dataGridView1.Rows[i].Cells["Column1"].Value.ToString();
                mycmd.Parameters.Add("@ogname", MySqlDbType.VarChar, 20).Value = dataGridView1.Rows[i].Cells["Column2"].Style.NullValue.ToString();
                mycmd.Parameters.Add("@ogcid", MySqlDbType.VarChar, 20).Value = dataGridView1.Rows[i].Cells["Column3"].Value.ToString();
                mycmd.Parameters.Add("@ogamount", MySqlDbType.Int32, 20).Value = dataGridView1.Rows[i].Cells["Column4"].Value.ToString();
                mycmd.Parameters.Add("@ogprice", MySqlDbType.Decimal, 18).Value = dataGridView1.Rows[i].Cells["Column5"].Value.ToString();
                mycmd.Parameters.Add("@ogunit", MySqlDbType.VarChar, 20).Value = dataGridView1.Rows[i].Cells["Column6"].Value.ToString();
                mycmd.Parameters.Add("@ogsum", MySqlDbType.Decimal, 18).Value = dataGridView1.Rows[i].Cells["Column7"].Value.ToString();
                mycmd.Parameters.Add("@oeid", MySqlDbType.VarChar, 20).Value = oeid;
                mycmd.Parameters.Add("@opaymentmethod", MySqlDbType.VarChar, 20).Value = opm;
                mycmd.Parameters.Add("@isreturn", MySqlDbType.VarChar, 20).Value = "否";
                mycmd.ExecuteNonQuery();
                mycmd.Dispose();
            }
            myconn.Close();
            xj = 0;
            alipay = 0;

            a = 1;

            myconn.Open();
            int b = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                string sql = "select GAmount from tb_Goods where GName=@gname";
                MySqlCommand mycmd = new MySqlCommand(sql, myconn);
                mycmd.Parameters.Add("@gname", MySqlDbType.VarChar, 20).Value = dataGridView1.Rows[i].Cells["Column2"].Style.NullValue.ToString();
                int n = Convert.ToInt32(mycmd.ExecuteScalar());
                if (n > 0)
                {
                    MySqlDataReader mysdr = mycmd.ExecuteReader();
                    mysdr.Read();
                    if (mysdr.HasRows)
                    {
                        sql = "update tb_Goods set GAmount=@gamount where GName=@gname";
                        mycmd = new MySqlCommand(sql, myconn);
                        mycmd.Parameters.Add("@gamount", MySqlDbType.Int32, 20).Value = Convert.ToInt32(mysdr[0].ToString().Trim()) - Convert.ToInt32(dataGridView1.Rows[i].Cells["Column4"].Value.ToString());
                        mycmd.Parameters.Add("@gname", MySqlDbType.VarChar, 20).Value = dataGridView1.Rows[i].Cells["Column2"].Style.NullValue.ToString();
                        mysdr.Dispose();
                        mycmd.ExecuteNonQuery();
                    }
                }
                mycmd.Dispose();
            }
            myconn.Close();
            b = 1;
            return a + b;
        }
        #endregion

        #region 重置按钮单击事件
        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();
        }
        #endregion

        #region 重置事件
        private void reset()
        {
            timer1.Stop();
            string s = oeid;
            UFrmSyt ufs = new UFrmSyt();
            ufs.oeid = s;
            this.Parent.Controls.Add(ufs);
            this.Parent.Controls.Remove(this);
        }
        #endregion

        #region 删除按钮单击事件
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int y = e.RowIndex;
            if (dataGridView1.Rows.Count >= 1)
            {
                if (e.ColumnIndex == (dataGridView1.ColumnCount - 1) && dataGridView1.Rows[y].Cells[e.ColumnIndex].Value != null)
                {
                    DialogResult result = MessageBox.Show("是否要删除当前行信息？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        dataGridView1.Rows.RemoveAt(y);
                    }
                }
            }
        }
        #endregion

        #region datagridview单元格选项变动时同一行对应的一起变动
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            int x = e.ColumnIndex;
            int y = e.RowIndex;
            if (x >= 0 && y >= 0 && dataGridView1.Rows[y].Cells[x].Value != null)
            {
                if (x == 0)
                {
                    dataGridView1.Rows[y].Cells["Column2"].Value = null;
                    for (int i = 0; i < dtgoods.Rows.Count; i++)
                    {
                        if (dtgoods.Rows[i]["GID"].Equals(dataGridView1.Rows[y].Cells[x].Value))
                        {
                            dataGridView1.Rows[y].Cells["Column2"].Style.NullValue = dtgoods.Rows[i]["GName"];
                            break;
                        }
                    }
                    string lbsql = "select tb_GoodsCategory.GCName from tb_GoodsCategory,tb_Goods where tb_Goods.GID=@gid and tb_GoodsCategory.GCID=tb_Goods.GCID";
                    MySqlParameter[] lbsp = new MySqlParameter[] { new MySqlParameter("gid", dataGridView1.Rows[y].Cells["Column1"].Value.ToString().Trim()) };
                    dataGridView1.Rows[y].Cells["Column3"].Value = ExecuteScalar(lbsql, lbsp).ToString();

                    string djsql = "select GPrice from tb_Goods where GID=@gid";
                    MySqlParameter[] djsp = new MySqlParameter[] { new MySqlParameter("gid", dataGridView1.Rows[y].Cells["Column1"].Value.ToString().Trim()) };
                    dataGridView1.Rows[y].Cells["Column5"].Value = Convert.ToInt32(ExecuteScalar(djsql, djsp));

                    string dwsql = "select GUnit from tb_Goods where GID=@gid";
                    MySqlParameter[] dwsp = new MySqlParameter[] { new MySqlParameter("gid", dataGridView1.Rows[y].Cells["Column1"].Value.ToString().Trim()) };
                    dataGridView1.Rows[y].Cells["Column6"].Value = ExecuteScalar(dwsql, dwsp).ToString();
                }
                if (x == 1)
                {
                    dataGridView1.Rows[y].Cells["Column1"].Value = null;
                    for (int i = 0; i < dtgoods.Rows.Count; i++)
                    {
                        if (dtgoods.Rows[i]["GName"].Equals(dataGridView1.Rows[y].Cells[x].Value))
                        {
                            dataGridView1.Rows[y].Cells["Column1"].Style.NullValue = dtgoods.Rows[i]["GID"];
                            dataGridView1.Rows[y].Cells["Column1"].Value = dtgoods.Rows[i]["GID"];
                            break;
                        }
                    }
                    string lbsql = "select tb_GoodsCategory.GCName from tb_GoodsCategory,tb_Goods where tb_Goods.GID=@gid and tb_GoodsCategory.GCID=tb_Goods.GCID";
                    MySqlParameter[] lbsp = new MySqlParameter[] { new MySqlParameter("gid", dataGridView1.Rows[y].Cells["Column1"].Value.ToString().Trim()) };
                    dataGridView1.Rows[y].Cells["Column3"].Value = ExecuteScalar(lbsql, lbsp).ToString();

                    string djsql = "select GPrice from tb_Goods where GID=@gid";
                    MySqlParameter[] djsp = new MySqlParameter[] { new MySqlParameter("gid", dataGridView1.Rows[y].Cells["Column1"].Value.ToString().Trim()) };
                    dataGridView1.Rows[y].Cells["Column5"].Value = Convert.ToInt32(ExecuteScalar(djsql, djsp));

                    string dwsql = "select GUnit from tb_Goods where GID=@gid";
                    MySqlParameter[] dwsp = new MySqlParameter[] { new MySqlParameter("gid", dataGridView1.Rows[y].Cells["Column1"].Value.ToString().Trim()) };
                    dataGridView1.Rows[y].Cells["Column6"].Value = ExecuteScalar(dwsql, dwsp).ToString();
                }
                if (x == 3)
                {
                    Regex s = new Regex(@"^[0-9]{1,}([.]{1}[0-9]{1,2})?$");
                    if (!s.IsMatch(dataGridView1.Rows[y].Cells["Column4"].Value.ToString().Trim()))
                    {
                        MessageBox.Show("请输入正确的数量，默认为0", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.Rows[y].Cells["Column4"].Value = 0;
                    }
                }
                if (dataGridView1.Rows[y].Cells["Column4"].Value != null && dataGridView1.Rows[y].Cells["Column5"].Value != null)
                {
                    string slsql = "select GAmount from tb_Goods where GID=@gid";
                    MySqlParameter[] slsp = new MySqlParameter[] { new MySqlParameter("gid", dataGridView1.Rows[y].Cells["Column1"].Value.ToString().Trim()) };

                    if (Convert.ToDouble(dataGridView1.Rows[y].Cells["Column4"].Value) <= Convert.ToInt32(ExecuteScalar(slsql, slsp)))
                    {
                        dataGridView1.Rows[y].Cells["Column7"].Value = Convert.ToDouble(dataGridView1.Rows[y].Cells["Column4"].Value) * Convert.ToDouble(dataGridView1.Rows[y].Cells["Column5"].Value);
                    }
                    else
                    {

                        MessageBox.Show("该商品库存数量不足，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.Rows[y].Cells["Column4"].Value = 0;
                    }
                }
            }
        }
        #endregion

        #region 行号
        private void RowTitle()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (!dataGridView1.Rows[i].IsNewRow)
                {
                    dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
            }
        }
        #endregion

        #region 新增行行号事件
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            RowTitle();
        }
        #endregion

        #region 移除行行号事件
        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            RowTitle();
        }
        #endregion

        #region 购物清单详细内容
        private void printOrder()
        {
            dtprintorder.Columns.Add("商品编号");
            dtprintorder.Columns.Add("商品名称");
            dtprintorder.Columns.Add("类别");
            dtprintorder.Columns.Add("数量");
            dtprintorder.Columns.Add("单价");
            dtprintorder.Columns.Add("单位");
            dtprintorder.Columns.Add("总价");
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells["Column7"].Value != null)
                {
                    DataRow dr = dtprintorder.NewRow();
                    for (int j = 0; j < 7; j++)
                    {
                        dr[j] = dataGridView1.Rows[i].Cells[j].Value;
                        if (dr[j].ToString() == "")
                        {
                            dr[j] = dataGridView1.Rows[i].Cells[j].Style.NullValue;
                        }
                    }
                    dtprintorder.Rows.Add(dr);
                }
            }
        }
        #endregion

        #region 打印
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Dictionary<int, int> width = GetMaxWidth(dtprintorder);
            int x = e.MarginBounds.X;
            int y = e.MarginBounds.Y;
            int w = e.MarginBounds.Width + 10;
            int left;
            int sum = 0;
            for (int i = 0; i < dtprintorder.Columns.Count; i++)
            {
                sum += width[i] * 18;
            }
            left = (w - sum) / 10 - x;
            Graphics g = e.Graphics;
            Brush b = new SolidBrush(Color.Black);
            Font f = new Font("宋体", 18);
            g.DrawString("qk超市欢迎您", f, b, w / 2, y);
            g.DrawString("您本次消费清单如下：", f, b, x + left, y + 50);
            x = e.MarginBounds.X + left;
            y = e.MarginBounds.Y + 100;
            for (int k = 0; k < dtprintorder.Columns.Count; k++)
            {
                string str = dtprintorder.Columns[k].ColumnName;
                g.DrawString(str, f, b, x, y);
                x = x + width[k] * 30;
            }
            for (int i = 0; i < dtprintorder.Rows.Count; i++)
            {
                x = e.MarginBounds.X + left;
                y = e.MarginBounds.Y + (3 + i) * 50;
                for (int j = 0; j < dtprintorder.Columns.Count; j++)
                {
                    string str = dtprintorder.Rows[i][j].ToString();
                    g.DrawString(str, f, b, x, y);
                    x = x + width[j] * 30;
                }
            }
            g.DrawString("订单编号：" + lab_OrderNum.Text, f, b, e.MarginBounds.X + left, y + 50);
            g.DrawString("交易时间：" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), f, b, e.MarginBounds.X + left, y + 50 * 2);
            FrmMain fm = new FrmMain();
            g.DrawString("收银员：" + oeid, f, b, e.MarginBounds.X + left, y + 50 * 3);
            g.DrawString("应付：" + lab_price_yf.Text + "元", f, b, e.MarginBounds.X + left, y + 50 * 4);
            string zffs;
            if (txtbox_price_sf.Text.Trim() == "")
            {
                zffs = "支付宝";
                g.DrawString("实付：" + lab_price_yf.Text.Trim() + "元", f, b, e.MarginBounds.X + left, y + 50 * 5);
                g.DrawString("支付方式：" + zffs, f, b, e.MarginBounds.X + left, y + 50 * 6);
            }
            else
            {
                zffs = "现金";
                g.DrawString("实付：" + txtbox_price_sf.Text.Trim() + "元", f, b, e.MarginBounds.X + left, y + 50 * 5);
                g.DrawString("找零：" + lab_price_zl.Text + "元", f, b, e.MarginBounds.X + left, y + 50 * 6);
                g.DrawString("支付方式：" + zffs, f, b, e.MarginBounds.X + left, y + 50 * 7);
            }
            g.DrawString("购物清单也可扫描下方二维码查看", f, b, e.MarginBounds.X + left, y + 50 * 8);

            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            QrCodeEncodingOptions options = new QrCodeEncodingOptions();
            options.DisableECI = true;
            //设置内容编码
            options.CharacterSet = "UTF-8";
            //设置二维码的宽度和高度
            options.Width = 150;
            options.Height = 150;
            //设置二维码的边距
            options.Margin = 1;
            writer.Options = options;
            string url = "https://umaru.moe/MarketMS.php?";
            //Bitmap map = writer.Write(url + text);
            //Bitmap map = new Bitmap(url + text);
            //zxing z = new zxing();
            //pictureBox1.Image = writer.Write(url + textBox1.Text);
            g.DrawImage(writer.Write(url + lab_OrderNum.Text), e.MarginBounds.X + left, y + 50 * 9);

            g.DrawString("欢迎您下次光临！", f, b, w / 2, y + 50 * 10);
        }
        #endregion

        #region 获取最大宽度
        private Dictionary<int, int> GetMaxWidth(DataTable dtprintorder)
        {
            Dictionary<int, int> max = new Dictionary<int, int>();
            for (int i = 0; i < dtprintorder.Columns.Count; i++)
            {
                int width = 0;
                for (int j = 0; j < dtprintorder.Rows.Count; j++)
                {
                    width = Math.Max(width, dtprintorder.Rows[j][i].ToString().Length);
                }
                width = Math.Max(width, dtprintorder.Columns[i].ColumnName.Length);
                max.Add(i, width);
            }
            return max;
        }
        #endregion
    }
}