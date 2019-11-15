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
    public partial class UFrmSpxx : UserControl
    {
        public UFrmSpxx()
        {
            InitializeComponent();
        }

        #region 刷新treeview内容
        private void tvBindData()
        {
            MySqlConnection myconn = BaseClass.DBConn.MyConn();
            myconn.Open();
            string sql = "select GCName from tb_GoodsCategory";
            MySqlCommand mycmd = new MySqlCommand(sql, myconn);
            MySqlDataReader mysdr = mycmd.ExecuteReader();
            if (treeView1.GetType().ToString().Trim() == "System.Windows.Forms.TreeView")
            {
                System.Windows.Forms.TreeView tr = (System.Windows.Forms.TreeView)treeView1;
                tr.Nodes.Clear();
                System.Windows.Forms.TreeNode tn = new System.Windows.Forms.TreeNode("所有类别", 0, 1);
                while (mysdr.Read())
                {
                    tn.Nodes.Add("", mysdr[0].ToString().Trim(), 0, 1);
                }
                tr.Nodes.Add(tn);
                tr.ExpandAll();
            }
            mysdr.Dispose();
            mycmd.Dispose();
            myconn.Close();
        }
        #endregion

        #region 刷新datagridview内容
        public void dgBindData()
        {
            int n = 0;
            dataGridView1.Columns.Clear();
            MySqlConnection myconn = BaseClass.DBConn.MyConn();
            myconn.Open();
            string sql = "select GID as 商品编号, GName as 商品名称, GCID as 类别, GPrice as 售价, GBid as 进价, GAmount as 库存数量, GMinimumInventory as 最小库存, GUnit as 单位, GShelfLife as 保质期, GProductionDate as 生产日期, GSupplier as 供应商, GNotes as 备注, ID as ID from tb_Goods";
            MySqlDataAdapter mysda = new MySqlDataAdapter(sql, myconn);
            DataSet ds = new DataSet();
            ds.Clear();
            mysda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.ClearSelection();

            dataGridView1.Columns[12].Visible = false;

            MySqlCommand mycmd = new MySqlCommand(sql, myconn);
            MySqlDataReader mysdr = mycmd.ExecuteReader();
            while (mysdr.Read())
            {
                n++;
            }
            mysdr.Dispose();
            for (int i = 0; i < n; i++)
            {
                dataGridView1.Columns[11].Width = 204;
                string ssql = "select * from tb_Goods where ID = '" + dataGridView1.Rows[i].Cells[12].Value.ToString().Trim() + "'";
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
                            dataGridView1.Rows[i].Cells[2].Value = gcmysdr["GCName"].ToString().Trim();
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

        #region 窗体加载事件
        private void UFrmSpxx_Load(object sender, EventArgs e)
        {
            tvBindData();
            dgBindData();

            /*MySqlConnection myconn = BaseClass.DBConn.MyConn();
            myconn.Open();
            string sql = "select GCName from tb_GoodsCategory";
            MySqlCommand mycmd = new MySqlCommand(sql, myconn);
            MySqlDataReader mysdr = mycmd.ExecuteReader();
            if (treeView1.GetType().ToString().Trim() == "System.Windows.Forms.TreeView")
            {
                System.Windows.Forms.TreeView tr = (System.Windows.Forms.TreeView)treeView1;
                tr.Nodes.Clear();
                System.Windows.Forms.TreeNode tn = new System.Windows.Forms.TreeNode("所有类别", 0, 1);
                while (mysdr.Read())
                {
                    tn.Nodes.Add("", mysdr[0].ToString().Trim(), 0, 1);
                }
                tr.Nodes.Add(tn);
                tr.ExpandAll();
            }
            mysdr.Dispose();
            mycmd.Dispose();
            myconn.Close();*/
        }
        #endregion

        #region 顶部 添加按钮 单击事件
        private void tsbtn_Add_Click(object sender, EventArgs e)
        {
            FrmNEGoods fneg = new FrmNEGoods();
            fneg.ne = 0;
            fneg.Show();
        }
        #endregion

        #region 顶部 修改按钮 单击事件
        private void tsbtn_Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                FrmNEGoods fneg = new FrmNEGoods();
                fneg.ne = 1;

                fneg.gid = dataGridView1.SelectedCells[0].Value.ToString().Trim();
                fneg.gname = dataGridView1.SelectedCells[1].Value.ToString().Trim();
                fneg.gcid = dataGridView1.SelectedCells[2].Value.ToString().Trim();
                fneg.gprice = dataGridView1.SelectedCells[3].Value.ToString().Trim();
                fneg.gbid = dataGridView1.SelectedCells[4].Value.ToString().Trim();
                fneg.gunit = dataGridView1.SelectedCells[7].Value.ToString().Trim();
                fneg.gsupplier = dataGridView1.SelectedCells[10].Value.ToString().Trim();
                fneg.gnotes = dataGridView1.SelectedCells[11].Value.ToString().Trim();
                fneg.id = dataGridView1.SelectedCells[12].Value.ToString().Trim();

                fneg.Show();
            }
            else
            {
                MessageBox.Show("请选择要修改的数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region 顶部 删除按钮 单击事件
        private void tsbtn_Del_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DialogResult result = MessageBox.Show("您确定要删除吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    MySqlConnection myconn = BaseClass.DBConn.MyConn();
                    myconn.Open();
                    string sql = "delete from tb_Goods where ID = '" + dataGridView1.SelectedCells[12].Value.ToString().Trim() + "'";
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

        #region 顶部 商品类别设置按钮 单击事件
        private void tsbtn_Category_Click(object sender, EventArgs e)
        {
            FrmGoodsCategory fgc = new FrmGoodsCategory();
            fgc.Show();
        }
        #endregion

        #region 顶部 查找按钮 单击事件
        private void tsbtn_Search_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            MySqlConnection myconn = BaseClass.DBConn.MyConn();
            myconn.Open();
            string sql = "select GID as 商品编号, GName as 商品名称, GCID as 类别, GPrice as 售价, GBid as 进价, GAmount as 库存数量, GMinimumInventory as 最小库存, GUnit as 单位, GShelfLife as 保质期, GProductionDate as 生产日期, GSupplier as 供应商, GNotes as 备注, ID as ID from tb_Goods where GID = '" + tstxtbox_spbhmc.Text.Trim() + "' or GName = '" + tstxtbox_spbhmc.Text.Trim() + "'";
            MySqlCommand mycmd = new MySqlCommand(sql, myconn);
            MySqlDataReader mysdr = mycmd.ExecuteReader();
            mysdr.Read();
            if (mysdr.HasRows)
            {
                DataSet ds = new DataSet();
                ds.Clear();
                mysdr.Dispose();
                MySqlDataAdapter mysda = new MySqlDataAdapter(sql, myconn);
                mysda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.ClearSelection();
                dataGridView1.Columns[12].Visible = false;
                mysda.Dispose();
            }
            else
            {
                MessageBox.Show("您查找的商品不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgBindData();
                tstxtbox_spbhmc.Text = "";
                tstxtbox_spbhmc.Focus();
            }
            mysdr.Dispose();
            mycmd.Dispose();
            myconn.Close();
        }
        #endregion

        #region treeview类别单击事件
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string type = e.Node.Text;
            if (type == "所有类别")
            {
                dgBindData();
            }
            else
            {
                MySqlConnection myconn = BaseClass.DBConn.MyConn();
                myconn.Open();
                string tvmysql = "select * from tb_GoodsCategory where GCName='" + e.Node.Text + "'";
                MySqlCommand tvmycmd = new MySqlCommand(tvmysql, myconn);
                MySqlDataReader tvmysdr = tvmycmd.ExecuteReader();
                tvmysdr.Read();
                if (tvmysdr.HasRows)
                {
                    int n = 0;
                    dataGridView1.Columns.Clear();
                    string sql = "select GID as 商品编号, GName as 商品名称, GCID as 类别, GPrice as 售价, GBid as 进价, GAmount as 库存数量, GMinimumInventory as 最小库存, GUnit as 单位, GShelfLife as 保质期, GProductionDate as 生产日期, GSupplier as 供应商, GNotes as 备注, ID as ID from tb_Goods where GCID='" + tvmysdr[0].ToString().Trim() + "'";
                    MySqlDataAdapter mysda = new MySqlDataAdapter(sql, myconn);
                    DataSet ds = new DataSet();
                    tvmysdr.Dispose();
                    ds.Clear();
                    mysda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.ClearSelection();

                    dataGridView1.Columns[12].Visible = false;

                    MySqlCommand mycmd = new MySqlCommand(sql, myconn);
                    MySqlDataReader mysdr = mycmd.ExecuteReader();
                    while (mysdr.Read())
                    {
                        n++;
                    }
                    mysdr.Dispose();
                    for (int i = 0; i < n; i++)
                    {
                        dataGridView1.Columns[11].Width = 204;
                        string ssql = "select * from tb_Goods where ID = '" + dataGridView1.Rows[i].Cells[12].Value.ToString().Trim() + "'";
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
                                    dataGridView1.Rows[i].Cells[2].Value = gcmysdr["GCName"].ToString().Trim();
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
                }
                tvmysdr.Dispose();
                tvmycmd.Dispose();
                myconn.Close();
            }
        }
        #endregion
    }
}