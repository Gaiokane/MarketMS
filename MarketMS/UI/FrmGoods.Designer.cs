namespace MarketMS.UI
{
    partial class FrmGoods
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGoods));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tslab_spbhmc = new System.Windows.Forms.ToolStripLabel();
            this.tstxtbox_spbhmc = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtn_Search = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtn_Add = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Edit = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Del = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Category = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslab_spbhmc,
            this.tstxtbox_spbhmc,
            this.tsbtn_Search});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(893, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tslab_spbhmc
            // 
            this.tslab_spbhmc.Name = "tslab_spbhmc";
            this.tslab_spbhmc.Size = new System.Drawing.Size(97, 22);
            this.tslab_spbhmc.Text = "商品编号/名称：";
            // 
            // tstxtbox_spbhmc
            // 
            this.tstxtbox_spbhmc.Name = "tstxtbox_spbhmc";
            this.tstxtbox_spbhmc.Size = new System.Drawing.Size(100, 25);
            // 
            // tsbtn_Search
            // 
            this.tsbtn_Search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_Search.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Search.Image")));
            this.tsbtn_Search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Search.Name = "tsbtn_Search";
            this.tsbtn_Search.Size = new System.Drawing.Size(47, 22);
            this.tsbtn_Search.Text = "■ 查找";
            this.tsbtn_Search.Click += new System.EventHandler(this.tsbtn_Search_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtn_Add,
            this.tsbtn_Edit,
            this.tsbtn_Del,
            this.tsbtn_Category});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(893, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtn_Add
            // 
            this.tsbtn_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_Add.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Add.Image")));
            this.tsbtn_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Add.Name = "tsbtn_Add";
            this.tsbtn_Add.Size = new System.Drawing.Size(47, 22);
            this.tsbtn_Add.Text = "■ 添加";
            this.tsbtn_Add.Click += new System.EventHandler(this.tsbtn_Add_Click);
            // 
            // tsbtn_Edit
            // 
            this.tsbtn_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_Edit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Edit.Image")));
            this.tsbtn_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Edit.Name = "tsbtn_Edit";
            this.tsbtn_Edit.Size = new System.Drawing.Size(47, 22);
            this.tsbtn_Edit.Text = "■ 修改";
            this.tsbtn_Edit.Click += new System.EventHandler(this.tsbtn_Edit_Click);
            // 
            // tsbtn_Del
            // 
            this.tsbtn_Del.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_Del.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Del.Image")));
            this.tsbtn_Del.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Del.Name = "tsbtn_Del";
            this.tsbtn_Del.Size = new System.Drawing.Size(47, 22);
            this.tsbtn_Del.Text = "■ 删除";
            this.tsbtn_Del.Click += new System.EventHandler(this.tsbtn_Del_Click);
            // 
            // tsbtn_Category
            // 
            this.tsbtn_Category.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_Category.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Category.Image")));
            this.tsbtn_Category.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Category.Name = "tsbtn_Category";
            this.tsbtn_Category.Size = new System.Drawing.Size(95, 22);
            this.tsbtn_Category.Text = "■ 商品类别设置";
            this.tsbtn_Category.Click += new System.EventHandler(this.tsbtn_Category_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(178, 53);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(715, 440);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 53);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(172, 440);
            this.treeView1.TabIndex = 4;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // FrmGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 493);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmGoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "商品信息";
            this.Load += new System.EventHandler(this.FrmGoods_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmGoods_KeyPress);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel tslab_spbhmc;
        private System.Windows.Forms.ToolStripTextBox tstxtbox_spbhmc;
        private System.Windows.Forms.ToolStripButton tsbtn_Search;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtn_Add;
        private System.Windows.Forms.ToolStripButton tsbtn_Edit;
        private System.Windows.Forms.ToolStripButton tsbtn_Del;
        private System.Windows.Forms.ToolStripButton tsbtn_Category;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TreeView treeView1;
    }
}