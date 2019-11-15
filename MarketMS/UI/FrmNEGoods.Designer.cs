namespace MarketMS.UI
{
    partial class FrmNEGoods
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
            this.txtbox_GID = new System.Windows.Forms.TextBox();
            this.txtbox_GName = new System.Windows.Forms.TextBox();
            this.cmbox_GCID = new System.Windows.Forms.ComboBox();
            this.txtbox_GPrice = new System.Windows.Forms.TextBox();
            this.txtbox_GBid = new System.Windows.Forms.TextBox();
            this.txtbox_GSupplier = new System.Windows.Forms.TextBox();
            this.cmbox_GUnit = new System.Windows.Forms.ComboBox();
            this.richtxtbox_GNotes = new System.Windows.Forms.RichTextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lab_GID = new System.Windows.Forms.Label();
            this.lab_GName = new System.Windows.Forms.Label();
            this.lab_GCID = new System.Windows.Forms.Label();
            this.lab_GPrice = new System.Windows.Forms.Label();
            this.lab_GBid = new System.Windows.Forms.Label();
            this.lab_GUnit = new System.Windows.Forms.Label();
            this.lab_GSupplier = new System.Windows.Forms.Label();
            this.lab_GNotes = new System.Windows.Forms.Label();
            this.btn_MoreSupplier = new System.Windows.Forms.Button();
            this.btn_AddCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox_GID
            // 
            this.txtbox_GID.Location = new System.Drawing.Point(90, 18);
            this.txtbox_GID.Name = "txtbox_GID";
            this.txtbox_GID.ReadOnly = true;
            this.txtbox_GID.Size = new System.Drawing.Size(120, 21);
            this.txtbox_GID.TabIndex = 0;
            // 
            // txtbox_GName
            // 
            this.txtbox_GName.Location = new System.Drawing.Point(90, 46);
            this.txtbox_GName.Name = "txtbox_GName";
            this.txtbox_GName.Size = new System.Drawing.Size(120, 21);
            this.txtbox_GName.TabIndex = 1;
            // 
            // cmbox_GCID
            // 
            this.cmbox_GCID.FormattingEnabled = true;
            this.cmbox_GCID.Items.AddRange(new object[] {
            "食品饮料",
            "粮油副食",
            "美容洗护",
            "家电",
            "家庭清洁",
            "生鲜水果"});
            this.cmbox_GCID.Location = new System.Drawing.Point(90, 73);
            this.cmbox_GCID.Name = "cmbox_GCID";
            this.cmbox_GCID.Size = new System.Drawing.Size(120, 20);
            this.cmbox_GCID.TabIndex = 2;
            // 
            // txtbox_GPrice
            // 
            this.txtbox_GPrice.Location = new System.Drawing.Point(90, 99);
            this.txtbox_GPrice.Name = "txtbox_GPrice";
            this.txtbox_GPrice.Size = new System.Drawing.Size(120, 21);
            this.txtbox_GPrice.TabIndex = 3;
            // 
            // txtbox_GBid
            // 
            this.txtbox_GBid.Location = new System.Drawing.Point(90, 126);
            this.txtbox_GBid.Name = "txtbox_GBid";
            this.txtbox_GBid.Size = new System.Drawing.Size(120, 21);
            this.txtbox_GBid.TabIndex = 4;
            // 
            // txtbox_GSupplier
            // 
            this.txtbox_GSupplier.Location = new System.Drawing.Point(90, 179);
            this.txtbox_GSupplier.Name = "txtbox_GSupplier";
            this.txtbox_GSupplier.ReadOnly = true;
            this.txtbox_GSupplier.Size = new System.Drawing.Size(120, 21);
            this.txtbox_GSupplier.TabIndex = 5;
            // 
            // cmbox_GUnit
            // 
            this.cmbox_GUnit.FormattingEnabled = true;
            this.cmbox_GUnit.Items.AddRange(new object[] {
            "盒",
            "箱",
            "瓶",
            "桶",
            "袋",
            "台",
            "包",
            "只",
            "斤"});
            this.cmbox_GUnit.Location = new System.Drawing.Point(90, 153);
            this.cmbox_GUnit.Name = "cmbox_GUnit";
            this.cmbox_GUnit.Size = new System.Drawing.Size(120, 20);
            this.cmbox_GUnit.TabIndex = 9;
            // 
            // richtxtbox_GNotes
            // 
            this.richtxtbox_GNotes.Location = new System.Drawing.Point(90, 206);
            this.richtxtbox_GNotes.Name = "richtxtbox_GNotes";
            this.richtxtbox_GNotes.Size = new System.Drawing.Size(200, 60);
            this.richtxtbox_GNotes.TabIndex = 10;
            this.richtxtbox_GNotes.Text = "";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(56, 276);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(157, 276);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 12;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lab_GID
            // 
            this.lab_GID.AutoSize = true;
            this.lab_GID.Location = new System.Drawing.Point(19, 21);
            this.lab_GID.Name = "lab_GID";
            this.lab_GID.Size = new System.Drawing.Size(65, 12);
            this.lab_GID.TabIndex = 13;
            this.lab_GID.Text = "商品编号：";
            // 
            // lab_GName
            // 
            this.lab_GName.AutoSize = true;
            this.lab_GName.Location = new System.Drawing.Point(19, 49);
            this.lab_GName.Name = "lab_GName";
            this.lab_GName.Size = new System.Drawing.Size(65, 12);
            this.lab_GName.TabIndex = 14;
            this.lab_GName.Text = "商品名称：";
            // 
            // lab_GCID
            // 
            this.lab_GCID.AutoSize = true;
            this.lab_GCID.Location = new System.Drawing.Point(19, 76);
            this.lab_GCID.Name = "lab_GCID";
            this.lab_GCID.Size = new System.Drawing.Size(65, 12);
            this.lab_GCID.TabIndex = 15;
            this.lab_GCID.Text = "类    别：";
            // 
            // lab_GPrice
            // 
            this.lab_GPrice.AutoSize = true;
            this.lab_GPrice.Location = new System.Drawing.Point(19, 102);
            this.lab_GPrice.Name = "lab_GPrice";
            this.lab_GPrice.Size = new System.Drawing.Size(65, 12);
            this.lab_GPrice.TabIndex = 16;
            this.lab_GPrice.Text = "售    价：";
            // 
            // lab_GBid
            // 
            this.lab_GBid.AutoSize = true;
            this.lab_GBid.Location = new System.Drawing.Point(19, 129);
            this.lab_GBid.Name = "lab_GBid";
            this.lab_GBid.Size = new System.Drawing.Size(65, 12);
            this.lab_GBid.TabIndex = 17;
            this.lab_GBid.Text = "进    价：";
            // 
            // lab_GUnit
            // 
            this.lab_GUnit.AutoSize = true;
            this.lab_GUnit.Location = new System.Drawing.Point(19, 156);
            this.lab_GUnit.Name = "lab_GUnit";
            this.lab_GUnit.Size = new System.Drawing.Size(65, 12);
            this.lab_GUnit.TabIndex = 18;
            this.lab_GUnit.Text = "单    位：";
            // 
            // lab_GSupplier
            // 
            this.lab_GSupplier.AutoSize = true;
            this.lab_GSupplier.Location = new System.Drawing.Point(19, 182);
            this.lab_GSupplier.Name = "lab_GSupplier";
            this.lab_GSupplier.Size = new System.Drawing.Size(65, 12);
            this.lab_GSupplier.TabIndex = 19;
            this.lab_GSupplier.Text = "供 应 商：";
            // 
            // lab_GNotes
            // 
            this.lab_GNotes.AutoSize = true;
            this.lab_GNotes.Location = new System.Drawing.Point(19, 209);
            this.lab_GNotes.Name = "lab_GNotes";
            this.lab_GNotes.Size = new System.Drawing.Size(65, 12);
            this.lab_GNotes.TabIndex = 20;
            this.lab_GNotes.Text = "备    注：";
            // 
            // btn_MoreSupplier
            // 
            this.btn_MoreSupplier.Location = new System.Drawing.Point(216, 180);
            this.btn_MoreSupplier.Name = "btn_MoreSupplier";
            this.btn_MoreSupplier.Size = new System.Drawing.Size(31, 20);
            this.btn_MoreSupplier.TabIndex = 21;
            this.btn_MoreSupplier.Text = "...";
            this.btn_MoreSupplier.UseVisualStyleBackColor = true;
            this.btn_MoreSupplier.Click += new System.EventHandler(this.btn_MoreSupplier_Click);
            // 
            // btn_AddCategory
            // 
            this.btn_AddCategory.Location = new System.Drawing.Point(216, 72);
            this.btn_AddCategory.Name = "btn_AddCategory";
            this.btn_AddCategory.Size = new System.Drawing.Size(21, 21);
            this.btn_AddCategory.TabIndex = 22;
            this.btn_AddCategory.Text = "+";
            this.btn_AddCategory.UseVisualStyleBackColor = true;
            this.btn_AddCategory.Click += new System.EventHandler(this.btn_AddCategory_Click);
            // 
            // FrmNEGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 311);
            this.Controls.Add(this.btn_AddCategory);
            this.Controls.Add(this.btn_MoreSupplier);
            this.Controls.Add(this.lab_GNotes);
            this.Controls.Add(this.lab_GSupplier);
            this.Controls.Add(this.lab_GUnit);
            this.Controls.Add(this.lab_GBid);
            this.Controls.Add(this.lab_GPrice);
            this.Controls.Add(this.lab_GCID);
            this.Controls.Add(this.lab_GName);
            this.Controls.Add(this.lab_GID);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.richtxtbox_GNotes);
            this.Controls.Add(this.cmbox_GUnit);
            this.Controls.Add(this.txtbox_GSupplier);
            this.Controls.Add(this.txtbox_GBid);
            this.Controls.Add(this.txtbox_GPrice);
            this.Controls.Add(this.cmbox_GCID);
            this.Controls.Add(this.txtbox_GName);
            this.Controls.Add(this.txtbox_GID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmNEGoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加/修改商品";
            this.Load += new System.EventHandler(this.FrmNEGoods_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmNEGoods_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_GID;
        private System.Windows.Forms.TextBox txtbox_GName;
        private System.Windows.Forms.ComboBox cmbox_GCID;
        private System.Windows.Forms.TextBox txtbox_GPrice;
        private System.Windows.Forms.TextBox txtbox_GBid;
        private System.Windows.Forms.TextBox txtbox_GSupplier;
        private System.Windows.Forms.ComboBox cmbox_GUnit;
        private System.Windows.Forms.RichTextBox richtxtbox_GNotes;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lab_GID;
        private System.Windows.Forms.Label lab_GName;
        private System.Windows.Forms.Label lab_GCID;
        private System.Windows.Forms.Label lab_GPrice;
        private System.Windows.Forms.Label lab_GBid;
        private System.Windows.Forms.Label lab_GUnit;
        private System.Windows.Forms.Label lab_GSupplier;
        private System.Windows.Forms.Label lab_GNotes;
        private System.Windows.Forms.Button btn_MoreSupplier;
        private System.Windows.Forms.Button btn_AddCategory;
    }
}