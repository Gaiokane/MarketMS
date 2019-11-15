namespace MarketMS.UI
{
    partial class UFrmDqkc
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Replenishment = new System.Windows.Forms.Button();
            this.btn_RefreshStock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 83);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(907, 450);
            this.dataGridView1.TabIndex = 4;
            // 
            // btn_Replenishment
            // 
            this.btn_Replenishment.Location = new System.Drawing.Point(671, 24);
            this.btn_Replenishment.Name = "btn_Replenishment";
            this.btn_Replenishment.Size = new System.Drawing.Size(75, 23);
            this.btn_Replenishment.TabIndex = 5;
            this.btn_Replenishment.Text = "补货";
            this.btn_Replenishment.UseVisualStyleBackColor = true;
            this.btn_Replenishment.Click += new System.EventHandler(this.btn_Replenishment_Click);
            // 
            // btn_RefreshStock
            // 
            this.btn_RefreshStock.Location = new System.Drawing.Point(768, 24);
            this.btn_RefreshStock.Name = "btn_RefreshStock";
            this.btn_RefreshStock.Size = new System.Drawing.Size(75, 23);
            this.btn_RefreshStock.TabIndex = 6;
            this.btn_RefreshStock.Text = "刷新库存";
            this.btn_RefreshStock.UseVisualStyleBackColor = true;
            this.btn_RefreshStock.Click += new System.EventHandler(this.btn_RefreshStock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "以下商品为当前库存量小于当前商品最小数量的商品";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UFrmDqkc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_RefreshStock);
            this.Controls.Add(this.btn_Replenishment);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UFrmDqkc";
            this.Size = new System.Drawing.Size(913, 536);
            this.Load += new System.EventHandler(this.UFrmDqkc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Replenishment;
        private System.Windows.Forms.Button btn_RefreshStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}
