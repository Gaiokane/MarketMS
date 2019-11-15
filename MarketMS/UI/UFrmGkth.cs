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

namespace MarketMS.UI
{
    public partial class UFrmGkth : UserControl
    {
        string roid = "RWA" + DateTime.Now.ToString("yyyyMMddhhmmss");

        public UFrmGkth()
        {
            InitializeComponent();
        }

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

        #region 查询按钮单击事件
        private void btn_Search_Click(object sender, EventArgs e)
        {
            dgBindData();
        }
        #endregion

        #region 查询按钮刷新datagridview
        private void dgBindData()
        {

            string ordernum;
            dataGridView1.Columns.Clear();
            if (radbtn_All.Checked)
            {
                ordernum = "";
                string allsql = "select OID as 订单编号, OGID as 商品编号, OGName as 商品名称, OGCID as 类别, OGAmount as 数量, OGPrice as 单价, OGUnit as 单位, OGSum as 总价, OPaymentMethod as 付款方式 from tb_Order where IsReturn='否' order by OID desc";
                dataGridView1.DataSource = dgBindData(allsql).Tables[0];

                if (dataGridView1.ColumnCount < 10)
                {
                    DataGridViewTextBoxColumn column7 = new DataGridViewTextBoxColumn();
                    column7.Name = "退货原因";
                    dataGridView1.Columns.Add(column7);
                    DataGridViewButtonColumn column8 = new DataGridViewButtonColumn();
                    column8.HeaderText = "退货";
                    column8.UseColumnTextForButtonValue = true;
                    column8.Text = "提交";
                    column8.Name = "提交";
                    column8.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(column8);
                }

                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.Columns[2].ReadOnly = true;
                dataGridView1.Columns[3].ReadOnly = true;
                dataGridView1.Columns[4].ReadOnly = true;
                dataGridView1.Columns[5].ReadOnly = true;
                dataGridView1.Columns[6].ReadOnly = true;
                dataGridView1.Columns[7].ReadOnly = true;
                dataGridView1.Columns[8].ReadOnly = true;

                dataGridView1.ClearSelection();
                dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                //MessageBox.Show(dataGridView1.Columns["退货原因"].Index.ToString());
            }
            else
            {
                if (cmbox_OrderNum.SelectedItem != null)
                {
                    ordernum = cmbox_OrderNum.Text.ToString().Trim();
                    string onsql = "select OID as 订单编号, OGID as 商品编号, OGName as 商品名称, OGCID as 类别, OGAmount as 数量, OGPrice as 单价, OGUnit as 单位, OGSum as 总价, OPaymentMethod as 付款方式 from tb_Order where OID='" + ordernum + "' and IsReturn='否' order by OID desc";
                    dataGridView1.DataSource = dgBindData(onsql).Tables[0];

                    if (dataGridView1.ColumnCount < 10)
                    {
                        DataGridViewTextBoxColumn column7 = new DataGridViewTextBoxColumn();
                        column7.Name = "退货原因";
                        dataGridView1.Columns.Add(column7);
                        DataGridViewButtonColumn column8 = new DataGridViewButtonColumn();
                        column8.HeaderText = "退货";
                        column8.UseColumnTextForButtonValue = true;
                        column8.Text = "提交";
                        column8.Name = "提交";
                        column8.UseColumnTextForButtonValue = true;
                        dataGridView1.Columns.Add(column8);
                    }

                    dataGridView1.Columns[0].ReadOnly = true;
                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[2].ReadOnly = true;
                    dataGridView1.Columns[3].ReadOnly = true;
                    dataGridView1.Columns[4].ReadOnly = true;
                    dataGridView1.Columns[5].ReadOnly = true;
                    dataGridView1.Columns[6].ReadOnly = true;
                    dataGridView1.Columns[7].ReadOnly = true;
                    dataGridView1.Columns[8].ReadOnly = true;

                    dataGridView1.ClearSelection();
                    dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    MessageBox.Show("请选择订单编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbox_OrderNum.SelectedIndex = 0;
                    cmbox_OrderNum.Focus();
                }
            }
        }
        #endregion

        #region 刷新datagridview内容
        private DataSet dgBindData(string sql)
        {
            MySqlConnection myconn = BaseClass.DBConn.MyConn();
            myconn.Open();
            MySqlDataAdapter mysda = new MySqlDataAdapter(sql, myconn);
            DataSet ds = new DataSet();
            ds.Clear();
            mysda.Fill(ds);
            return ds;
        }
        #endregion

        #region 窗体加载事件
        private void UFrmLsjyjl_Load(object sender, EventArgs e)
        {
            cmbox_OrderNum.Text = "qwe";
            MySqlConnection myconn = BaseClass.DBConn.MyConn();
            myconn.Open();
            string sql = "select DISTINCT OID from tb_Order order by OID desc";
            MySqlCommand mycmd = new MySqlCommand(sql, myconn);
            MySqlDataAdapter mysda = new MySqlDataAdapter(mycmd);
            DataTable dt = new DataTable();
            mysda.Fill(dt);
            mysda.Dispose();
            mycmd.Dispose();
            myconn.Close();
            cmbox_OrderNum.DataSource = dt;
            cmbox_OrderNum.DisplayMember = "OID";
            cmbox_OrderNum.ValueMember = "OID";
        }
        #endregion

        #region 点击订单编号下拉框选中对应radiobtn
        private void cmbox_OrderNum_Click(object sender, EventArgs e)
        {
            radbtn_cmbox.Checked = true;
        }
        #endregion

        #region 退货按钮单击事件
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("提交"))
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells["退货原因"].Value != null)
                    {
                        if (dataGridView1.Rows[e.RowIndex].Cells["退货原因"].Value.ToString() == "1" || dataGridView1.Rows[e.RowIndex].Cells["退货原因"].Value.ToString() == "2" || dataGridView1.Rows[e.RowIndex].Cells["退货原因"].Value.ToString() == "3")
                        {
                            MySqlConnection myconn = BaseClass.DBConn.MyConn();
                            myconn.Open();
                            string sql = "INSERT INTO tb_ReturnOrder(OID, ROGName, ROGCID, ROGAomunt, ROGPrice, ROGUnit, ROGSum, ROPaymentMethod, ROReason, ROID) VALUES (@oid, @rogname, @rogcid, @rogaomunt, @rogprice, @rogunit, @rogsum, @ropaymentmethod, @roreason, @roid)";
                            MySqlCommand mycmd = new MySqlCommand(sql, myconn);
                            mycmd.Parameters.Add("@oid", MySqlDbType.VarChar, 20).Value = dataGridView1.Rows[e.RowIndex].Cells["订单编号"].Value.ToString().Trim();
                            mycmd.Parameters.Add("@rogname", MySqlDbType.VarChar, 20).Value = dataGridView1.Rows[e.RowIndex].Cells["商品名称"].Value.ToString().Trim();
                            mycmd.Parameters.Add("@rogcid", MySqlDbType.VarChar, 20).Value = dataGridView1.Rows[e.RowIndex].Cells["类别"].Value.ToString().Trim();
                            mycmd.Parameters.Add("@rogaomunt", MySqlDbType.VarChar, 20).Value = dataGridView1.Rows[e.RowIndex].Cells["数量"].Value.ToString().Trim();
                            mycmd.Parameters.Add("@rogprice", MySqlDbType.Decimal, 18).Value = dataGridView1.Rows[e.RowIndex].Cells["单价"].Value.ToString().Trim();
                            mycmd.Parameters.Add("@rogunit", MySqlDbType.VarChar, 20).Value = dataGridView1.Rows[e.RowIndex].Cells["单位"].Value.ToString().Trim();
                            mycmd.Parameters.Add("@rogsum", MySqlDbType.Decimal, 18).Value = dataGridView1.Rows[e.RowIndex].Cells["总价"].Value.ToString().Trim();
                            mycmd.Parameters.Add("@ropaymentmethod", MySqlDbType.VarChar, 20).Value = dataGridView1.Rows[e.RowIndex].Cells["付款方式"].Value.ToString().Trim();
                            mycmd.Parameters.Add("@roreason", MySqlDbType.VarChar, 20).Value = dataGridView1.Rows[e.RowIndex].Cells["退货原因"].Value.ToString().Trim();
                            mycmd.Parameters.Add("@roid", MySqlDbType.VarChar, 20).Value = roid;
                            mycmd.ExecuteNonQuery();
                            mycmd.Dispose();
                            myconn.Close();

                            myconn.Open();
                            sql = "update tb_Order set IsReturn=@isreturn where OID=@oid and OGName=@ogname";
                            mycmd = new MySqlCommand(sql, myconn);
                            mycmd.Parameters.Add("@isreturn", MySqlDbType.VarChar, 20).Value = "是";
                            mycmd.Parameters.Add("@oid", MySqlDbType.VarChar, 20).Value = dataGridView1.Rows[e.RowIndex].Cells["订单编号"].Value.ToString().Trim();
                            mycmd.Parameters.Add("@ogname", MySqlDbType.VarChar, 20).Value = dataGridView1.Rows[e.RowIndex].Cells["商品名称"].Value.ToString().Trim();
                            mycmd.ExecuteNonQuery();
                            mycmd.Dispose();
                            myconn.Close();

                            myconn.Open();
                            sql = "select GAmount from tb_Goods where GName=@gname";
                            mycmd = new MySqlCommand(sql, myconn);
                            mycmd.Parameters.Add("@gname", MySqlDbType.VarChar, 20).Value = dataGridView1.Rows[e.RowIndex].Cells["商品名称"].Value.ToString().Trim();
                            int n = Convert.ToInt32(mycmd.ExecuteScalar());
                            if (n > 0)
                            {
                                MySqlDataReader mysdr = mycmd.ExecuteReader();
                                mysdr.Read();
                                if (mysdr.HasRows)
                                {
                                    sql = "update tb_Goods set GAmount=@gamount where GName=@gname";
                                    mycmd = new MySqlCommand(sql, myconn);
                                    mycmd.Parameters.Add("@gamount", MySqlDbType.Int32, 20).Value = Convert.ToInt32(mysdr[0].ToString().Trim()) + Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["数量"].Value.ToString().Trim());
                                    mycmd.Parameters.Add("@gname", MySqlDbType.VarChar, 20).Value = dataGridView1.Rows[e.RowIndex].Cells["商品名称"].Value.ToString().Trim();
                                    mysdr.Dispose();
                                    mycmd.ExecuteNonQuery();
                                }
                            }
                            mycmd.Dispose();
                            myconn.Close();

                            if (dataGridView1.Rows[e.RowIndex].Cells["付款方式"].Value.ToString() == "支付宝")
                            {
                                FrmRefundWithAlipay frwa = new FrmRefundWithAlipay();
                                frwa.oid = dataGridView1.Rows[e.RowIndex].Cells["订单编号"].Value.ToString().Trim();
                                frwa.roid = roid;
                                frwa.price = dataGridView1.Rows[e.RowIndex].Cells["总价"].Value.ToString().Trim();
                                frwa.Show();
                                frwa.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRWA_Closed);
                            }
                            else
                            {
                                MessageBox.Show("退货成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgBindData();
                            }
                        }
                        else
                        {
                            MessageBox.Show("请选择正确的退货原因！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("退货原因不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        #endregion

        #region 当支付宝付款窗口关闭时事件
        private void FRWA_Closed(object sender, EventArgs e)
        {

            MessageBox.Show("退货成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgBindData();
        }
        #endregion
    }
}