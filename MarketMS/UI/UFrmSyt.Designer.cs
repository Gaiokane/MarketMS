namespace MarketMS.UI
{
    partial class UFrmSyt
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtbox_price_sf = new System.Windows.Forms.TextBox();
            this.lab_yf = new System.Windows.Forms.Label();
            this.lab_sf = new System.Windows.Forms.Label();
            this.lab_zl = new System.Windows.Forms.Label();
            this.lab_price_yf = new System.Windows.Forms.Label();
            this.lab_price_zl = new System.Windows.Forms.Label();
            this.lab_yuan1 = new System.Windows.Forms.Label();
            this.lab_yuan2 = new System.Windows.Forms.Label();
            this.lab_yuan3 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lab_OrderNumber = new System.Windows.Forms.Label();
            this.lab_OrderNum = new System.Windows.Forms.Label();
            this.btn_jzfs_Alipay = new System.Windows.Forms.Button();
            this.btn_jzfs_cash = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lab_warning = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(907, 390);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // Column1
            // 
            this.Column1.DisplayStyleForCurrentCellOnly = true;
            this.Column1.HeaderText = "商品编号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DisplayStyleForCurrentCellOnly = true;
            this.Column2.HeaderText = "商品名称";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GCID";
            this.Column3.HeaderText = "类别";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "数量";
            this.Column4.Name = "Column4";
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "GPrice";
            this.Column5.HeaderText = "单价";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "GUnit";
            this.Column6.HeaderText = "单位";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "总价";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "删除";
            this.Column8.Name = "Column8";
            this.Column8.Text = "删除";
            this.Column8.UseColumnTextForButtonValue = true;
            // 
            // txtbox_price_sf
            // 
            this.txtbox_price_sf.Location = new System.Drawing.Point(134, 455);
            this.txtbox_price_sf.Name = "txtbox_price_sf";
            this.txtbox_price_sf.Size = new System.Drawing.Size(150, 21);
            this.txtbox_price_sf.TabIndex = 5;
            // 
            // lab_yf
            // 
            this.lab_yf.AutoSize = true;
            this.lab_yf.Location = new System.Drawing.Point(39, 428);
            this.lab_yf.Name = "lab_yf";
            this.lab_yf.Size = new System.Drawing.Size(41, 12);
            this.lab_yf.TabIndex = 9;
            this.lab_yf.Text = "应付：";
            // 
            // lab_sf
            // 
            this.lab_sf.AutoSize = true;
            this.lab_sf.Location = new System.Drawing.Point(39, 458);
            this.lab_sf.Name = "lab_sf";
            this.lab_sf.Size = new System.Drawing.Size(41, 12);
            this.lab_sf.TabIndex = 10;
            this.lab_sf.Text = "实付：";
            // 
            // lab_zl
            // 
            this.lab_zl.AutoSize = true;
            this.lab_zl.Location = new System.Drawing.Point(39, 489);
            this.lab_zl.Name = "lab_zl";
            this.lab_zl.Size = new System.Drawing.Size(41, 12);
            this.lab_zl.TabIndex = 11;
            this.lab_zl.Text = "找零：";
            // 
            // lab_price_yf
            // 
            this.lab_price_yf.AutoSize = true;
            this.lab_price_yf.Location = new System.Drawing.Point(205, 428);
            this.lab_price_yf.Name = "lab_price_yf";
            this.lab_price_yf.Size = new System.Drawing.Size(11, 12);
            this.lab_price_yf.TabIndex = 12;
            this.lab_price_yf.Text = "0";
            // 
            // lab_price_zl
            // 
            this.lab_price_zl.AutoSize = true;
            this.lab_price_zl.Location = new System.Drawing.Point(205, 489);
            this.lab_price_zl.Name = "lab_price_zl";
            this.lab_price_zl.Size = new System.Drawing.Size(11, 12);
            this.lab_price_zl.TabIndex = 13;
            this.lab_price_zl.Text = "0";
            // 
            // lab_yuan1
            // 
            this.lab_yuan1.AutoSize = true;
            this.lab_yuan1.Location = new System.Drawing.Point(351, 428);
            this.lab_yuan1.Name = "lab_yuan1";
            this.lab_yuan1.Size = new System.Drawing.Size(17, 12);
            this.lab_yuan1.TabIndex = 14;
            this.lab_yuan1.Text = "元";
            // 
            // lab_yuan2
            // 
            this.lab_yuan2.AutoSize = true;
            this.lab_yuan2.Location = new System.Drawing.Point(351, 458);
            this.lab_yuan2.Name = "lab_yuan2";
            this.lab_yuan2.Size = new System.Drawing.Size(17, 12);
            this.lab_yuan2.TabIndex = 15;
            this.lab_yuan2.Text = "元";
            // 
            // lab_yuan3
            // 
            this.lab_yuan3.AutoSize = true;
            this.lab_yuan3.Location = new System.Drawing.Point(351, 489);
            this.lab_yuan3.Name = "lab_yuan3";
            this.lab_yuan3.Size = new System.Drawing.Size(17, 12);
            this.lab_yuan3.TabIndex = 16;
            this.lab_yuan3.Text = "元";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(787, 475);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 8;
            this.btn_reset.Text = "重置";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // lab_OrderNumber
            // 
            this.lab_OrderNumber.AutoSize = true;
            this.lab_OrderNumber.Location = new System.Drawing.Point(579, 428);
            this.lab_OrderNumber.Name = "lab_OrderNumber";
            this.lab_OrderNumber.Size = new System.Drawing.Size(65, 12);
            this.lab_OrderNumber.TabIndex = 17;
            this.lab_OrderNumber.Text = "订单编号：";
            // 
            // lab_OrderNum
            // 
            this.lab_OrderNum.AutoSize = true;
            this.lab_OrderNum.Location = new System.Drawing.Point(650, 428);
            this.lab_OrderNum.Name = "lab_OrderNum";
            this.lab_OrderNum.Size = new System.Drawing.Size(77, 12);
            this.lab_OrderNum.TabIndex = 18;
            this.lab_OrderNum.Text = "lab_OrderNum";
            // 
            // btn_jzfs_Alipay
            // 
            this.btn_jzfs_Alipay.Location = new System.Drawing.Point(100, 20);
            this.btn_jzfs_Alipay.Name = "btn_jzfs_Alipay";
            this.btn_jzfs_Alipay.Size = new System.Drawing.Size(75, 23);
            this.btn_jzfs_Alipay.TabIndex = 7;
            this.btn_jzfs_Alipay.Text = "支付宝";
            this.btn_jzfs_Alipay.UseVisualStyleBackColor = true;
            this.btn_jzfs_Alipay.Click += new System.EventHandler(this.btn_jzfs_Alipay_Click);
            // 
            // btn_jzfs_cash
            // 
            this.btn_jzfs_cash.Location = new System.Drawing.Point(19, 20);
            this.btn_jzfs_cash.Name = "btn_jzfs_cash";
            this.btn_jzfs_cash.Size = new System.Drawing.Size(75, 23);
            this.btn_jzfs_cash.TabIndex = 6;
            this.btn_jzfs_cash.Text = "现金";
            this.btn_jzfs_cash.UseVisualStyleBackColor = true;
            this.btn_jzfs_cash.Click += new System.EventHandler(this.btn_jzfs_cash_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_jzfs_cash);
            this.groupBox1.Controls.Add(this.btn_jzfs_Alipay);
            this.groupBox1.Location = new System.Drawing.Point(581, 455);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 55);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "结账方式";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lab_warning
            // 
            this.lab_warning.AutoSize = true;
            this.lab_warning.ForeColor = System.Drawing.Color.Red;
            this.lab_warning.Location = new System.Drawing.Point(374, 458);
            this.lab_warning.Name = "lab_warning";
            this.lab_warning.Size = new System.Drawing.Size(0, 12);
            this.lab_warning.TabIndex = 20;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // UFrmSyt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lab_warning);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lab_OrderNum);
            this.Controls.Add(this.lab_OrderNumber);
            this.Controls.Add(this.lab_yuan3);
            this.Controls.Add(this.lab_yuan2);
            this.Controls.Add(this.lab_yuan1);
            this.Controls.Add(this.lab_price_zl);
            this.Controls.Add(this.lab_price_yf);
            this.Controls.Add(this.lab_zl);
            this.Controls.Add(this.lab_sf);
            this.Controls.Add(this.lab_yf);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.txtbox_price_sf);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UFrmSyt";
            this.Size = new System.Drawing.Size(913, 536);
            this.Load += new System.EventHandler(this.UFrmSyt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtbox_price_sf;
        private System.Windows.Forms.Label lab_yf;
        private System.Windows.Forms.Label lab_sf;
        private System.Windows.Forms.Label lab_zl;
        private System.Windows.Forms.Label lab_price_yf;
        private System.Windows.Forms.Label lab_price_zl;
        private System.Windows.Forms.Label lab_yuan1;
        private System.Windows.Forms.Label lab_yuan2;
        private System.Windows.Forms.Label lab_yuan3;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lab_OrderNumber;
        private System.Windows.Forms.Label lab_OrderNum;
        private System.Windows.Forms.Button btn_jzfs_Alipay;
        private System.Windows.Forms.Button btn_jzfs_cash;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lab_warning;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn Column8;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}
