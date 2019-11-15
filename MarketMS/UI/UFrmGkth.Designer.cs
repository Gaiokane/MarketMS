namespace MarketMS.UI
{
    partial class UFrmGkth
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Search = new System.Windows.Forms.Button();
            this.radbtn_cmbox = new System.Windows.Forms.RadioButton();
            this.radbtn_All = new System.Windows.Forms.RadioButton();
            this.cmbox_OrderNum = new System.Windows.Forms.ComboBox();
            this.lab_OrderNum = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 143);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(907, 390);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.radbtn_cmbox);
            this.panel1.Controls.Add(this.radbtn_All);
            this.panel1.Controls.Add(this.cmbox_OrderNum);
            this.panel1.Controls.Add(this.lab_OrderNum);
            this.panel1.Location = new System.Drawing.Point(23, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            this.panel1.TabIndex = 6;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(171, 57);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 10;
            this.btn_Search.Text = "查询";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // radbtn_cmbox
            // 
            this.radbtn_cmbox.AutoSize = true;
            this.radbtn_cmbox.Location = new System.Drawing.Point(96, 24);
            this.radbtn_cmbox.Name = "radbtn_cmbox";
            this.radbtn_cmbox.Size = new System.Drawing.Size(14, 13);
            this.radbtn_cmbox.TabIndex = 6;
            this.radbtn_cmbox.TabStop = true;
            this.radbtn_cmbox.UseVisualStyleBackColor = true;
            // 
            // radbtn_All
            // 
            this.radbtn_All.AutoSize = true;
            this.radbtn_All.Checked = true;
            this.radbtn_All.Location = new System.Drawing.Point(96, 60);
            this.radbtn_All.Name = "radbtn_All";
            this.radbtn_All.Size = new System.Drawing.Size(47, 16);
            this.radbtn_All.TabIndex = 7;
            this.radbtn_All.TabStop = true;
            this.radbtn_All.Text = "全部";
            this.radbtn_All.UseVisualStyleBackColor = true;
            // 
            // cmbox_OrderNum
            // 
            this.cmbox_OrderNum.FormattingEnabled = true;
            this.cmbox_OrderNum.Location = new System.Drawing.Point(116, 21);
            this.cmbox_OrderNum.Name = "cmbox_OrderNum";
            this.cmbox_OrderNum.Size = new System.Drawing.Size(130, 20);
            this.cmbox_OrderNum.TabIndex = 8;
            this.cmbox_OrderNum.Click += new System.EventHandler(this.cmbox_OrderNum_Click);
            // 
            // lab_OrderNum
            // 
            this.lab_OrderNum.AutoSize = true;
            this.lab_OrderNum.Location = new System.Drawing.Point(25, 24);
            this.lab_OrderNum.Name = "lab_OrderNum";
            this.lab_OrderNum.Size = new System.Drawing.Size(65, 12);
            this.lab_OrderNum.TabIndex = 9;
            this.lab_OrderNum.Text = "订单编号：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(425, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "退货原因：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.质量问题（过期，商品损坏等）\r\n\r\n2.规格不符（大小，数量不符表述等）\r\n\r\n3.其他";
            // 
            // UFrmGkth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UFrmGkth";
            this.Size = new System.Drawing.Size(913, 536);
            this.Load += new System.EventHandler(this.UFrmLsjyjl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.RadioButton radbtn_cmbox;
        private System.Windows.Forms.RadioButton radbtn_All;
        private System.Windows.Forms.ComboBox cmbox_OrderNum;
        private System.Windows.Forms.Label lab_OrderNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}
