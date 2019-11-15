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
using System.Drawing.Printing;
using DLLFullPrint;

namespace MarketMS.UI
{
    public partial class UFrmCgjh : UserControl
    {
        public UFrmCgjh()
        {
            InitializeComponent();
        }

        #region 刷新dategridview
        private void dgBindData()
        {
            int n = 0;
            dataGridView1.Columns.Clear();
            MySqlConnection myconn = BaseClass.DBConn.MyConn();
            myconn.Open();
            string sql = "select POID as 进货编号, POGSupplier as 供应商, PODate as 进货日期, POGID as 商品编号, POGName as 商品名称, POGCID as 类别, POGUnit as 单位, POGBid as 进价, POGPrice as 售价, POAmount as 进货数量, POGMinimumInventory as 最小库存, POGShelfLife as 保质期, POGProductionDate as 生产日期, POGNotes as 备注, ID as ID from tb_PurchaseOrder";
            MySqlDataAdapter mysda = new MySqlDataAdapter(sql, myconn);
            DataSet ds = new DataSet();
            ds.Clear();
            mysda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.ClearSelection();

            dataGridView1.Columns[14].Visible = false;

            MySqlCommand mycmd = new MySqlCommand(sql, myconn);
            MySqlDataReader mysdr = mycmd.ExecuteReader();
            while (mysdr.Read())
            {
                n++;
            }
            mysdr.Dispose();
            for (int i = 0; i < n; i++)
            {
                dataGridView1.Columns[13].Width = 204;
                string ssql = "select * from tb_Goods where GID = '" + dataGridView1.Rows[i].Cells[3].Value.ToString().Trim() + "'";
                MySqlCommand smycmd = new MySqlCommand(ssql, myconn);
                mysdr = smycmd.ExecuteReader();
                mysdr.Read();
                if (mysdr.HasRows)
                {
                    int gcid = Convert.ToInt32(mysdr["GCID"].ToString().Trim());
                    mysdr.Dispose();
                    string gcsql = "select GCID, GCName from tb_GoodsCategory where GCID='" + gcid + "'";
                    MySqlCommand gcmycmd = new MySqlCommand(gcsql, myconn);
                    MySqlDataReader gcmysdr = gcmycmd.ExecuteReader();
                    gcmysdr.Read();
                    if (gcmysdr.HasRows)
                    {
                        if (gcid == Convert.ToInt32(gcmysdr["GCID"].ToString().Trim()))
                        {
                            dataGridView1.Rows[i].Cells[5].Value = gcmysdr["GCName"].ToString().Trim();
                        }
                    }
                    gcmysdr.Dispose();
                    gcmycmd.Dispose();
                }
                mysdr.Dispose();
                smycmd.Dispose();
            }
            mycmd.Dispose();
            mysda.Dispose();
            myconn.Close();
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

        #region 将dataGridView数据显示到Excle中
        private void DataGridviewShowToExcel()
        {
            //建立Excel对象      
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            excel.Visible = true;
            //生成字段名称      
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                excel.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
            }
            //填充数据      
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1[j, i].ValueType == typeof(string))
                    {
                        excel.Cells[i + 2, j + 1] = "'" + dataGridView1[j, i].Value.ToString();
                    }
                    else
                    {
                        excel.Cells[i + 2, j + 1] = dataGridView1[j, i].Value.ToString();
                    }
                }
            }
        }
        #endregion

        #region 打印
        private void print()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            DataRow dr;
            //设置列表头 
            foreach (DataGridViewColumn headerCell in dataGridView1.Columns)
            {
                dt.Columns.Add(headerCell.HeaderText);
            }
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                dr = dt.NewRow();
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    dr[i] = item.Cells[i].Value.ToString();
                }
                dt.Rows.Add(dr);
            }
            DataSet dy = new DataSet();
            dy.Tables.Add(dt);
            MyDLL.TakeOver(dy);
        }
        #endregion

        #region 窗体加载事件
        private void UFrmCgjh_Load(object sender, EventArgs e)
        {
            tscmbox_cxtj.SelectedIndex = 0;
            dgBindData();
        }
        #endregion

        #region 进货单录入按钮单击事件
        private void tsbtn_POAdd_Click(object sender, EventArgs e)
        {
            FrmNEPurchaseOrder fnepo = new FrmNEPurchaseOrder();
            fnepo.po = 0;
            fnepo.Show();
        }
        #endregion

        #region 进货单修改按钮单击事件
        private void tsbtn_POEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                FrmNEPurchaseOrder fnepo = new FrmNEPurchaseOrder();
                fnepo.po = 1;

                fnepo.poid = dataGridView1.SelectedCells[0].Value.ToString().Trim();
                fnepo.pogsupplier = dataGridView1.SelectedCells[1].Value.ToString().Trim();
                fnepo.podate = dataGridView1.SelectedCells[2].Value.ToString().Trim();
                fnepo.pogid = dataGridView1.SelectedCells[3].Value.ToString().Trim();
                fnepo.pogname = dataGridView1.SelectedCells[4].Value.ToString().Trim();
                fnepo.pogcid = dataGridView1.SelectedCells[5].Value.ToString().Trim();
                fnepo.pogunit = dataGridView1.SelectedCells[6].Value.ToString().Trim();
                fnepo.pogbid = dataGridView1.SelectedCells[7].Value.ToString().Trim();
                fnepo.pogprice = dataGridView1.SelectedCells[8].Value.ToString().Trim();
                fnepo.poamount = dataGridView1.SelectedCells[9].Value.ToString().Trim();
                fnepo.pogminimuminventory = dataGridView1.SelectedCells[10].Value.ToString().Trim();
                fnepo.pogshelflife = dataGridView1.SelectedCells[11].Value.ToString().Trim();
                fnepo.pogproductiondate = dataGridView1.SelectedCells[12].Value.ToString().Trim();
                fnepo.pognotes = dataGridView1.SelectedCells[13].Value.ToString().Trim();
                fnepo.id = dataGridView1.SelectedCells[14].Value.ToString().Trim();

                fnepo.Show();
            }
            else
            {
                MessageBox.Show("请选择要修改的数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region 进货单删除按钮单击事件
        private void tsbtn_PODel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DialogResult result = MessageBox.Show("您确定要删除吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    MySqlConnection myconn = BaseClass.DBConn.MyConn();
                    myconn.Open();
                    string sql = "delete from tb_PurchaseOrder where ID = '" + dataGridView1.SelectedCells[14].Value.ToString().Trim() + "'";
                    MySqlCommand mycmd = new MySqlCommand(sql, myconn);
                    int n = mycmd.ExecuteNonQuery();
                    if (n > 0)
                    {
                        MessageBox.Show("删除商品信息成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgBindData();
                    }
                    else
                    {
                        MessageBox.Show("删除商品信息失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    mycmd.Dispose();
                    myconn.Close();
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的商品！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region 供应商设置按钮单击事件
        private void tsbtn_GSSet_Click(object sender, EventArgs e)
        {
            FrmGoodsSupplier fgs = new FrmGoodsSupplier();
            fgs.Show();
        }
        #endregion

        #region 导出Excel按钮单击事件
        private void tsbtn_ExportExcel_Click(object sender, EventArgs e)
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

        #region 打印按钮单击事件
        private void tsbtn_Print_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null)
            {
                MessageBox.Show("没有要打印的内容！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                print();
            }
        }
        #endregion

        #region 查询按钮单击事件
        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tscmbox_cxtj.SelectedIndex == 0)
            {
                dgBindData();
            }
            else
            {
                string begin = dtp_Begin.Value.ToString("yyyy-MM-dd");
                string end = dtp_End.Value.ToString("yyyy-MM-dd");

                int n = 0;
                dataGridView1.Columns.Clear();
                MySqlConnection myconn = BaseClass.DBConn.MyConn();
                myconn.Open();
                string sql = "select POID as 进货编号, POGSupplier as 供应商, PODate as 进货日期, POGID as 商品编号, POGName as 商品名称, POGCID as 类别, POGUnit as 单位, POGBid as 进价, POGPrice as 售价, POAmount as 进货数量, POGMinimumInventory as 最小库存, POGShelfLife as 保质期, POGProductionDate as 生产日期, POGNotes as 备注, ID as ID from tb_PurchaseOrder where PODate between '" + begin + "' and '" + end + "'";
                MySqlDataAdapter mysda = new MySqlDataAdapter(sql, myconn);
                DataSet ds = new DataSet();
                ds.Clear();
                mysda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.ClearSelection();

                dataGridView1.Columns[14].Visible = false;

                MySqlCommand mycmd = new MySqlCommand(sql, myconn);
                MySqlDataReader mysdr = mycmd.ExecuteReader();
                while (mysdr.Read())
                {
                    n++;
                }
                mysdr.Dispose();
                for (int i = 0; i < n; i++)
                {
                    dataGridView1.Columns[13].Width = 204;
                    string ssql = "select * from tb_Goods where GID = '" + dataGridView1.Rows[i].Cells[3].Value.ToString().Trim() + "'";
                    MySqlCommand smycmd = new MySqlCommand(ssql, myconn);
                    mysdr = smycmd.ExecuteReader();
                    mysdr.Read();
                    if (mysdr.HasRows)
                    {
                        int gcid = Convert.ToInt32(mysdr["GCID"].ToString().Trim());
                        mysdr.Dispose();
                        string gcsql = "select GCID, GCName from tb_GoodsCategory where GCID='" + gcid + "'";
                        MySqlCommand gcmycmd = new MySqlCommand(gcsql, myconn);
                        MySqlDataReader gcmysdr = gcmycmd.ExecuteReader();
                        gcmysdr.Read();
                        if (gcmysdr.HasRows)
                        {
                            if (gcid == Convert.ToInt32(gcmysdr["GCID"].ToString().Trim()))
                            {
                                dataGridView1.Rows[i].Cells[5].Value = gcmysdr["GCName"].ToString().Trim();
                            }
                        }
                        gcmysdr.Dispose();
                        gcmycmd.Dispose();
                    }
                    mysdr.Dispose();
                    smycmd.Dispose();
                }
                mycmd.Dispose();
                mysda.Dispose();
                myconn.Close();
            }
        }
        #endregion
    }
}