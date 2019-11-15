namespace MarketMS.UI
{
    partial class FrmNEGoodsSupplier
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
            this.txtbox_GSName = new System.Windows.Forms.TextBox();
            this.txtbox_GSPName = new System.Windows.Forms.TextBox();
            this.txtbox_GSTel = new System.Windows.Forms.TextBox();
            this.txtbox_GSAddress = new System.Windows.Forms.TextBox();
            this.richtxtbox_GSNotes = new System.Windows.Forms.RichTextBox();
            this.btn_SSubmit = new System.Windows.Forms.Button();
            this.btn_SCancel = new System.Windows.Forms.Button();
            this.lab_SName = new System.Windows.Forms.Label();
            this.lab_SPName = new System.Windows.Forms.Label();
            this.lab_STel = new System.Windows.Forms.Label();
            this.lab_SAddress = new System.Windows.Forms.Label();
            this.lab_SNotes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbox_GSName
            // 
            this.txtbox_GSName.Location = new System.Drawing.Point(107, 12);
            this.txtbox_GSName.Name = "txtbox_GSName";
            this.txtbox_GSName.Size = new System.Drawing.Size(150, 21);
            this.txtbox_GSName.TabIndex = 0;
            // 
            // txtbox_GSPName
            // 
            this.txtbox_GSPName.Location = new System.Drawing.Point(107, 39);
            this.txtbox_GSPName.Name = "txtbox_GSPName";
            this.txtbox_GSPName.Size = new System.Drawing.Size(150, 21);
            this.txtbox_GSPName.TabIndex = 1;
            // 
            // txtbox_GSTel
            // 
            this.txtbox_GSTel.Location = new System.Drawing.Point(107, 66);
            this.txtbox_GSTel.Name = "txtbox_GSTel";
            this.txtbox_GSTel.Size = new System.Drawing.Size(150, 21);
            this.txtbox_GSTel.TabIndex = 2;
            // 
            // txtbox_GSAddress
            // 
            this.txtbox_GSAddress.Location = new System.Drawing.Point(107, 93);
            this.txtbox_GSAddress.Name = "txtbox_GSAddress";
            this.txtbox_GSAddress.Size = new System.Drawing.Size(150, 21);
            this.txtbox_GSAddress.TabIndex = 3;
            // 
            // richtxtbox_GSNotes
            // 
            this.richtxtbox_GSNotes.Location = new System.Drawing.Point(107, 120);
            this.richtxtbox_GSNotes.Name = "richtxtbox_GSNotes";
            this.richtxtbox_GSNotes.Size = new System.Drawing.Size(150, 96);
            this.richtxtbox_GSNotes.TabIndex = 4;
            this.richtxtbox_GSNotes.Text = "";
            // 
            // btn_SSubmit
            // 
            this.btn_SSubmit.Location = new System.Drawing.Point(116, 222);
            this.btn_SSubmit.Name = "btn_SSubmit";
            this.btn_SSubmit.Size = new System.Drawing.Size(75, 23);
            this.btn_SSubmit.TabIndex = 5;
            this.btn_SSubmit.Text = "确定";
            this.btn_SSubmit.UseVisualStyleBackColor = true;
            this.btn_SSubmit.Click += new System.EventHandler(this.btn_SSubmit_Click);
            // 
            // btn_SCancel
            // 
            this.btn_SCancel.Location = new System.Drawing.Point(197, 222);
            this.btn_SCancel.Name = "btn_SCancel";
            this.btn_SCancel.Size = new System.Drawing.Size(75, 23);
            this.btn_SCancel.TabIndex = 6;
            this.btn_SCancel.Text = "取消";
            this.btn_SCancel.UseVisualStyleBackColor = true;
            this.btn_SCancel.Click += new System.EventHandler(this.btn_SCancel_Click);
            // 
            // lab_SName
            // 
            this.lab_SName.AutoSize = true;
            this.lab_SName.Location = new System.Drawing.Point(15, 15);
            this.lab_SName.Name = "lab_SName";
            this.lab_SName.Size = new System.Drawing.Size(77, 12);
            this.lab_SName.TabIndex = 7;
            this.lab_SName.Text = "供应商名字：";
            // 
            // lab_SPName
            // 
            this.lab_SPName.AutoSize = true;
            this.lab_SPName.Location = new System.Drawing.Point(15, 42);
            this.lab_SPName.Name = "lab_SPName";
            this.lab_SPName.Size = new System.Drawing.Size(77, 12);
            this.lab_SPName.TabIndex = 8;
            this.lab_SPName.Text = "负  责  人：";
            // 
            // lab_STel
            // 
            this.lab_STel.AutoSize = true;
            this.lab_STel.Location = new System.Drawing.Point(9, 69);
            this.lab_STel.Name = "lab_STel";
            this.lab_STel.Size = new System.Drawing.Size(83, 12);
            this.lab_STel.TabIndex = 9;
            this.lab_STel.Text = "联 系 电 话：";
            // 
            // lab_SAddress
            // 
            this.lab_SAddress.AutoSize = true;
            this.lab_SAddress.Location = new System.Drawing.Point(15, 96);
            this.lab_SAddress.Name = "lab_SAddress";
            this.lab_SAddress.Size = new System.Drawing.Size(77, 12);
            this.lab_SAddress.TabIndex = 10;
            this.lab_SAddress.Text = "地      址：";
            // 
            // lab_SNotes
            // 
            this.lab_SNotes.AutoSize = true;
            this.lab_SNotes.Location = new System.Drawing.Point(15, 123);
            this.lab_SNotes.Name = "lab_SNotes";
            this.lab_SNotes.Size = new System.Drawing.Size(77, 12);
            this.lab_SNotes.TabIndex = 11;
            this.lab_SNotes.Text = "备      注：";
            // 
            // FrmNEGoodsSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lab_SNotes);
            this.Controls.Add(this.lab_SAddress);
            this.Controls.Add(this.lab_STel);
            this.Controls.Add(this.lab_SPName);
            this.Controls.Add(this.lab_SName);
            this.Controls.Add(this.btn_SCancel);
            this.Controls.Add(this.btn_SSubmit);
            this.Controls.Add(this.richtxtbox_GSNotes);
            this.Controls.Add(this.txtbox_GSAddress);
            this.Controls.Add(this.txtbox_GSTel);
            this.Controls.Add(this.txtbox_GSPName);
            this.Controls.Add(this.txtbox_GSName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmNEGoodsSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加/修改供应商信息";
            this.Load += new System.EventHandler(this.FrmNESupplier_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmNESupplier_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_GSName;
        private System.Windows.Forms.TextBox txtbox_GSPName;
        private System.Windows.Forms.TextBox txtbox_GSTel;
        private System.Windows.Forms.TextBox txtbox_GSAddress;
        private System.Windows.Forms.RichTextBox richtxtbox_GSNotes;
        private System.Windows.Forms.Button btn_SSubmit;
        private System.Windows.Forms.Button btn_SCancel;
        private System.Windows.Forms.Label lab_SName;
        private System.Windows.Forms.Label lab_SPName;
        private System.Windows.Forms.Label lab_STel;
        private System.Windows.Forms.Label lab_SAddress;
        private System.Windows.Forms.Label lab_SNotes;
    }
}