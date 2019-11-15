namespace MarketMS.UI
{
    partial class FrmGoodsCategory
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
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_NewCategory = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(222, 98);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(75, 23);
            this.btn_Del.TabIndex = 7;
            this.btn_Del.Text = "删除类别";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(222, 59);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 6;
            this.btn_Edit.Text = "修改";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_NewCategory
            // 
            this.btn_NewCategory.Location = new System.Drawing.Point(222, 20);
            this.btn_NewCategory.Name = "btn_NewCategory";
            this.btn_NewCategory.Size = new System.Drawing.Size(75, 23);
            this.btn_NewCategory.TabIndex = 5;
            this.btn_NewCategory.Text = "新建类别";
            this.btn_NewCategory.UseVisualStyleBackColor = true;
            this.btn_NewCategory.Click += new System.EventHandler(this.btn_NewCategory_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(191, 317);
            this.treeView1.TabIndex = 4;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // FrmGoodsCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 341);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_NewCategory);
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmGoodsCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "商品类别信息";
            this.Load += new System.EventHandler(this.FrmCategory_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmGoodsCategory_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_NewCategory;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
    }
}