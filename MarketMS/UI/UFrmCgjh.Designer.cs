namespace MarketMS.UI
{
    partial class UFrmCgjh
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UFrmCgjh));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtn_POAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_POEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_PODel = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_GSSet = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_ExportExcel = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Print = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tscmbox_cxtj = new System.Windows.Forms.ToolStripComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp_End = new System.Windows.Forms.DateTimePicker();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lab_to = new System.Windows.Forms.Label();
            this.dtp_Begin = new System.Windows.Forms.DateTimePicker();
            this.lab_Date = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtn_POAdd,
            this.tsbtn_POEdit,
            this.tsbtn_PODel,
            this.tsbtn_GSSet,
            this.tsbtn_ExportExcel,
            this.tsbtn_Print});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(913, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtn_POAdd
            // 
            this.tsbtn_POAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_POAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_POAdd.Image")));
            this.tsbtn_POAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_POAdd.Name = "tsbtn_POAdd";
            this.tsbtn_POAdd.Size = new System.Drawing.Size(87, 22);
            this.tsbtn_POAdd.Text = " ■ 进货单录入";
            this.tsbtn_POAdd.Click += new System.EventHandler(this.tsbtn_POAdd_Click);
            // 
            // tsbtn_POEdit
            // 
            this.tsbtn_POEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_POEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_POEdit.Image")));
            this.tsbtn_POEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_POEdit.Name = "tsbtn_POEdit";
            this.tsbtn_POEdit.Size = new System.Drawing.Size(87, 22);
            this.tsbtn_POEdit.Text = " ■ 进货单修改";
            this.tsbtn_POEdit.Click += new System.EventHandler(this.tsbtn_POEdit_Click);
            // 
            // tsbtn_PODel
            // 
            this.tsbtn_PODel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_PODel.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_PODel.Image")));
            this.tsbtn_PODel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_PODel.Name = "tsbtn_PODel";
            this.tsbtn_PODel.Size = new System.Drawing.Size(87, 22);
            this.tsbtn_PODel.Text = " ■ 进货单删除";
            this.tsbtn_PODel.Click += new System.EventHandler(this.tsbtn_PODel_Click);
            // 
            // tsbtn_GSSet
            // 
            this.tsbtn_GSSet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_GSSet.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_GSSet.Image")));
            this.tsbtn_GSSet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_GSSet.Name = "tsbtn_GSSet";
            this.tsbtn_GSSet.Size = new System.Drawing.Size(87, 22);
            this.tsbtn_GSSet.Text = " ■ 供应商设置";
            this.tsbtn_GSSet.Click += new System.EventHandler(this.tsbtn_GSSet_Click);
            // 
            // tsbtn_ExportExcel
            // 
            this.tsbtn_ExportExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_ExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_ExportExcel.Image")));
            this.tsbtn_ExportExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_ExportExcel.Name = "tsbtn_ExportExcel";
            this.tsbtn_ExportExcel.Size = new System.Drawing.Size(80, 22);
            this.tsbtn_ExportExcel.Text = " ■ 导出Excel";
            this.tsbtn_ExportExcel.Click += new System.EventHandler(this.tsbtn_ExportExcel_Click);
            // 
            // tsbtn_Print
            // 
            this.tsbtn_Print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_Print.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Print.Image")));
            this.tsbtn_Print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Print.Name = "tsbtn_Print";
            this.tsbtn_Print.Size = new System.Drawing.Size(51, 22);
            this.tsbtn_Print.Text = " ■ 打印";
            this.tsbtn_Print.Click += new System.EventHandler(this.tsbtn_Print_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscmbox_cxtj});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(913, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tscmbox_cxtj
            // 
            this.tscmbox_cxtj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscmbox_cxtj.Items.AddRange(new object[] {
            "查询全部",
            "按日期查询"});
            this.tscmbox_cxtj.Name = "tscmbox_cxtj";
            this.tscmbox_cxtj.Size = new System.Drawing.Size(121, 25);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtp_End);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.lab_to);
            this.panel1.Controls.Add(this.dtp_Begin);
            this.panel1.Controls.Add(this.lab_Date);
            this.panel1.Location = new System.Drawing.Point(137, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 25);
            this.panel1.TabIndex = 2;
            // 
            // dtp_End
            // 
            this.dtp_End.Location = new System.Drawing.Point(202, 2);
            this.dtp_End.Name = "dtp_End";
            this.dtp_End.Size = new System.Drawing.Size(126, 21);
            this.dtp_End.TabIndex = 3;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(334, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "查询";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lab_to
            // 
            this.lab_to.AutoSize = true;
            this.lab_to.Location = new System.Drawing.Point(179, 8);
            this.lab_to.Name = "lab_to";
            this.lab_to.Size = new System.Drawing.Size(17, 12);
            this.lab_to.TabIndex = 2;
            this.lab_to.Text = "至";
            // 
            // dtp_Begin
            // 
            this.dtp_Begin.Location = new System.Drawing.Point(50, 2);
            this.dtp_Begin.Name = "dtp_Begin";
            this.dtp_Begin.Size = new System.Drawing.Size(123, 21);
            this.dtp_Begin.TabIndex = 1;
            // 
            // lab_Date
            // 
            this.lab_Date.AutoSize = true;
            this.lab_Date.Location = new System.Drawing.Point(3, 8);
            this.lab_Date.Name = "lab_Date";
            this.lab_Date.Size = new System.Drawing.Size(41, 12);
            this.lab_Date.TabIndex = 0;
            this.lab_Date.Text = "日期：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 53);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(907, 480);
            this.dataGridView1.TabIndex = 3;
            // 
            // UFrmCgjh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UFrmCgjh";
            this.Size = new System.Drawing.Size(913, 536);
            this.Load += new System.EventHandler(this.UFrmCgjh_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtn_POAdd;
        private System.Windows.Forms.ToolStripButton tsbtn_POEdit;
        private System.Windows.Forms.ToolStripButton tsbtn_PODel;
        private System.Windows.Forms.ToolStripButton tsbtn_GSSet;
        private System.Windows.Forms.ToolStripButton tsbtn_ExportExcel;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbtn_Print;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lab_to;
        private System.Windows.Forms.DateTimePicker dtp_Begin;
        private System.Windows.Forms.Label lab_Date;
        private System.Windows.Forms.DateTimePicker dtp_End;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripComboBox tscmbox_cxtj;
    }
}
