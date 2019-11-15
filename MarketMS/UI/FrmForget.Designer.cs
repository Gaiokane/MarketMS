namespace MarketMS.UI
{
    partial class FrmForget
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lab_Find = new System.Windows.Forms.Label();
            this.radbtn_Tel = new System.Windows.Forms.RadioButton();
            this.btn_WBack = new System.Windows.Forms.Button();
            this.btn_WSubmit = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lab_CheckNewPasswd = new System.Windows.Forms.Label();
            this.lab_NewPasswd = new System.Windows.Forms.Label();
            this.lab_Tel = new System.Windows.Forms.Label();
            this.lab_UserName = new System.Windows.Forms.Label();
            this.btn_CBack = new System.Windows.Forms.Button();
            this.btn_CSubmit = new System.Windows.Forms.Button();
            this.txtbox_CheckNewPasswd = new System.Windows.Forms.TextBox();
            this.txtbox_NewPasswd = new System.Windows.Forms.TextBox();
            this.txtbox_Tel = new System.Windows.Forms.TextBox();
            this.txtbox_UserName = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(260, 237);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lab_Find);
            this.tabPage1.Controls.Add(this.radbtn_Tel);
            this.tabPage1.Controls.Add(this.btn_WBack);
            this.tabPage1.Controls.Add(this.btn_WSubmit);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(252, 211);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lab_Find
            // 
            this.lab_Find.AutoSize = true;
            this.lab_Find.Location = new System.Drawing.Point(23, 23);
            this.lab_Find.Name = "lab_Find";
            this.lab_Find.Size = new System.Drawing.Size(65, 12);
            this.lab_Find.TabIndex = 3;
            this.lab_Find.Text = "找回方式：";
            // 
            // radbtn_Tel
            // 
            this.radbtn_Tel.AutoSize = true;
            this.radbtn_Tel.Checked = true;
            this.radbtn_Tel.Location = new System.Drawing.Point(57, 83);
            this.radbtn_Tel.Name = "radbtn_Tel";
            this.radbtn_Tel.Size = new System.Drawing.Size(107, 16);
            this.radbtn_Tel.TabIndex = 2;
            this.radbtn_Tel.TabStop = true;
            this.radbtn_Tel.Text = "通过手机号找回";
            this.radbtn_Tel.UseVisualStyleBackColor = true;
            // 
            // btn_WBack
            // 
            this.btn_WBack.Location = new System.Drawing.Point(136, 141);
            this.btn_WBack.Name = "btn_WBack";
            this.btn_WBack.Size = new System.Drawing.Size(75, 23);
            this.btn_WBack.TabIndex = 1;
            this.btn_WBack.Text = "返回";
            this.btn_WBack.UseVisualStyleBackColor = true;
            this.btn_WBack.Click += new System.EventHandler(this.btn_WBack_Click);
            // 
            // btn_WSubmit
            // 
            this.btn_WSubmit.Location = new System.Drawing.Point(25, 141);
            this.btn_WSubmit.Name = "btn_WSubmit";
            this.btn_WSubmit.Size = new System.Drawing.Size(75, 23);
            this.btn_WSubmit.TabIndex = 0;
            this.btn_WSubmit.Text = "确定";
            this.btn_WSubmit.UseVisualStyleBackColor = true;
            this.btn_WSubmit.Click += new System.EventHandler(this.btn_WSubmit_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lab_CheckNewPasswd);
            this.tabPage2.Controls.Add(this.lab_NewPasswd);
            this.tabPage2.Controls.Add(this.lab_Tel);
            this.tabPage2.Controls.Add(this.lab_UserName);
            this.tabPage2.Controls.Add(this.btn_CBack);
            this.tabPage2.Controls.Add(this.btn_CSubmit);
            this.tabPage2.Controls.Add(this.txtbox_CheckNewPasswd);
            this.tabPage2.Controls.Add(this.txtbox_NewPasswd);
            this.tabPage2.Controls.Add(this.txtbox_Tel);
            this.tabPage2.Controls.Add(this.txtbox_UserName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(252, 211);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lab_CheckNewPasswd
            // 
            this.lab_CheckNewPasswd.AutoSize = true;
            this.lab_CheckNewPasswd.Location = new System.Drawing.Point(17, 114);
            this.lab_CheckNewPasswd.Name = "lab_CheckNewPasswd";
            this.lab_CheckNewPasswd.Size = new System.Drawing.Size(77, 12);
            this.lab_CheckNewPasswd.TabIndex = 9;
            this.lab_CheckNewPasswd.Text = "确认新密码：";
            // 
            // lab_NewPasswd
            // 
            this.lab_NewPasswd.AutoSize = true;
            this.lab_NewPasswd.Location = new System.Drawing.Point(17, 86);
            this.lab_NewPasswd.Name = "lab_NewPasswd";
            this.lab_NewPasswd.Size = new System.Drawing.Size(77, 12);
            this.lab_NewPasswd.TabIndex = 8;
            this.lab_NewPasswd.Text = "新  密  码：";
            // 
            // lab_Tel
            // 
            this.lab_Tel.AutoSize = true;
            this.lab_Tel.Location = new System.Drawing.Point(17, 58);
            this.lab_Tel.Name = "lab_Tel";
            this.lab_Tel.Size = new System.Drawing.Size(77, 12);
            this.lab_Tel.TabIndex = 7;
            this.lab_Tel.Text = "绑定手机号：";
            // 
            // lab_UserName
            // 
            this.lab_UserName.AutoSize = true;
            this.lab_UserName.Location = new System.Drawing.Point(17, 30);
            this.lab_UserName.Name = "lab_UserName";
            this.lab_UserName.Size = new System.Drawing.Size(77, 12);
            this.lab_UserName.TabIndex = 6;
            this.lab_UserName.Text = "用  户  名：";
            // 
            // btn_CBack
            // 
            this.btn_CBack.Location = new System.Drawing.Point(153, 164);
            this.btn_CBack.Name = "btn_CBack";
            this.btn_CBack.Size = new System.Drawing.Size(75, 23);
            this.btn_CBack.TabIndex = 5;
            this.btn_CBack.Text = "返回";
            this.btn_CBack.UseVisualStyleBackColor = true;
            this.btn_CBack.Click += new System.EventHandler(this.btn_CBack_Click);
            // 
            // btn_CSubmit
            // 
            this.btn_CSubmit.Location = new System.Drawing.Point(19, 164);
            this.btn_CSubmit.Name = "btn_CSubmit";
            this.btn_CSubmit.Size = new System.Drawing.Size(75, 23);
            this.btn_CSubmit.TabIndex = 4;
            this.btn_CSubmit.Text = "确定";
            this.btn_CSubmit.UseVisualStyleBackColor = true;
            this.btn_CSubmit.Click += new System.EventHandler(this.btn_CSubmit_Click);
            // 
            // txtbox_CheckNewPasswd
            // 
            this.txtbox_CheckNewPasswd.Location = new System.Drawing.Point(110, 111);
            this.txtbox_CheckNewPasswd.Name = "txtbox_CheckNewPasswd";
            this.txtbox_CheckNewPasswd.PasswordChar = '*';
            this.txtbox_CheckNewPasswd.Size = new System.Drawing.Size(100, 21);
            this.txtbox_CheckNewPasswd.TabIndex = 3;
            this.txtbox_CheckNewPasswd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_CheckNewPasswd_KeyPress);
            // 
            // txtbox_NewPasswd
            // 
            this.txtbox_NewPasswd.Location = new System.Drawing.Point(110, 83);
            this.txtbox_NewPasswd.Name = "txtbox_NewPasswd";
            this.txtbox_NewPasswd.PasswordChar = '*';
            this.txtbox_NewPasswd.Size = new System.Drawing.Size(100, 21);
            this.txtbox_NewPasswd.TabIndex = 2;
            this.txtbox_NewPasswd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_NewPasswd_KeyPress);
            // 
            // txtbox_Tel
            // 
            this.txtbox_Tel.Location = new System.Drawing.Point(110, 55);
            this.txtbox_Tel.Name = "txtbox_Tel";
            this.txtbox_Tel.Size = new System.Drawing.Size(100, 21);
            this.txtbox_Tel.TabIndex = 1;
            this.txtbox_Tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_Tel_KeyPress);
            // 
            // txtbox_UserName
            // 
            this.txtbox_UserName.Location = new System.Drawing.Point(110, 27);
            this.txtbox_UserName.Name = "txtbox_UserName";
            this.txtbox_UserName.Size = new System.Drawing.Size(100, 21);
            this.txtbox_UserName.TabIndex = 0;
            this.txtbox_UserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_UserName_KeyPress);
            // 
            // FrmForget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmForget";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "找回密码";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormForget_FormClosing);
            this.Load += new System.EventHandler(this.FrmForget_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lab_Find;
        private System.Windows.Forms.RadioButton radbtn_Tel;
        private System.Windows.Forms.Button btn_WBack;
        private System.Windows.Forms.Button btn_WSubmit;
        private System.Windows.Forms.Label lab_CheckNewPasswd;
        private System.Windows.Forms.Label lab_NewPasswd;
        private System.Windows.Forms.Label lab_Tel;
        private System.Windows.Forms.Label lab_UserName;
        private System.Windows.Forms.Button btn_CBack;
        private System.Windows.Forms.Button btn_CSubmit;
        private System.Windows.Forms.TextBox txtbox_CheckNewPasswd;
        private System.Windows.Forms.TextBox txtbox_NewPasswd;
        private System.Windows.Forms.TextBox txtbox_Tel;
        private System.Windows.Forms.TextBox txtbox_UserName;
    }
}