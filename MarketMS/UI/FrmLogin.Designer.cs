namespace MarketMS.UI
{
    partial class FrmLogin
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
            this.txtbox_UserName = new System.Windows.Forms.TextBox();
            this.txtbox_Passwd = new System.Windows.Forms.TextBox();
            this.txtbox_Captcha = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.picbox_Captcha = new System.Windows.Forms.PictureBox();
            this.lab_UserName = new System.Windows.Forms.Label();
            this.lab_Passwd = new System.Windows.Forms.Label();
            this.lab_captcha = new System.Windows.Forms.Label();
            this.linklab_Forget = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Captcha)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_UserName
            // 
            this.txtbox_UserName.Location = new System.Drawing.Point(91, 53);
            this.txtbox_UserName.Name = "txtbox_UserName";
            this.txtbox_UserName.Size = new System.Drawing.Size(100, 21);
            this.txtbox_UserName.TabIndex = 0;
            this.txtbox_UserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_UserName_KeyPress);
            // 
            // txtbox_Passwd
            // 
            this.txtbox_Passwd.Location = new System.Drawing.Point(91, 83);
            this.txtbox_Passwd.Name = "txtbox_Passwd";
            this.txtbox_Passwd.PasswordChar = '*';
            this.txtbox_Passwd.Size = new System.Drawing.Size(100, 21);
            this.txtbox_Passwd.TabIndex = 1;
            this.txtbox_Passwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_Passwd_KeyPress);
            // 
            // txtbox_Captcha
            // 
            this.txtbox_Captcha.Location = new System.Drawing.Point(91, 112);
            this.txtbox_Captcha.Name = "txtbox_Captcha";
            this.txtbox_Captcha.Size = new System.Drawing.Size(100, 21);
            this.txtbox_Captcha.TabIndex = 2;
            this.txtbox_Captcha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_Captcha_KeyPress);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(45, 148);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "登录";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(137, 148);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Reset.TabIndex = 4;
            this.btn_Reset.Text = "重置";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // picbox_Captcha
            // 
            this.picbox_Captcha.Location = new System.Drawing.Point(197, 112);
            this.picbox_Captcha.Name = "picbox_Captcha";
            this.picbox_Captcha.Size = new System.Drawing.Size(60, 21);
            this.picbox_Captcha.TabIndex = 5;
            this.picbox_Captcha.TabStop = false;
            this.picbox_Captcha.Click += new System.EventHandler(this.picbox_Captcha_Click);
            // 
            // lab_UserName
            // 
            this.lab_UserName.AutoSize = true;
            this.lab_UserName.Location = new System.Drawing.Point(32, 56);
            this.lab_UserName.Name = "lab_UserName";
            this.lab_UserName.Size = new System.Drawing.Size(53, 12);
            this.lab_UserName.TabIndex = 6;
            this.lab_UserName.Text = "用户名：";
            // 
            // lab_Passwd
            // 
            this.lab_Passwd.AutoSize = true;
            this.lab_Passwd.Location = new System.Drawing.Point(32, 86);
            this.lab_Passwd.Name = "lab_Passwd";
            this.lab_Passwd.Size = new System.Drawing.Size(53, 12);
            this.lab_Passwd.TabIndex = 7;
            this.lab_Passwd.Text = "密  码：";
            // 
            // lab_captcha
            // 
            this.lab_captcha.AutoSize = true;
            this.lab_captcha.Location = new System.Drawing.Point(32, 115);
            this.lab_captcha.Name = "lab_captcha";
            this.lab_captcha.Size = new System.Drawing.Size(53, 12);
            this.lab_captcha.TabIndex = 8;
            this.lab_captcha.Text = "验证码：";
            // 
            // linklab_Forget
            // 
            this.linklab_Forget.AutoSize = true;
            this.linklab_Forget.Location = new System.Drawing.Point(218, 153);
            this.linklab_Forget.Name = "linklab_Forget";
            this.linklab_Forget.Size = new System.Drawing.Size(59, 12);
            this.linklab_Forget.TabIndex = 5;
            this.linklab_Forget.TabStop = true;
            this.linklab_Forget.Text = "忘记密码?";
            this.linklab_Forget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklab_Forget_LinkClicked);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.linklab_Forget);
            this.Controls.Add(this.lab_captcha);
            this.Controls.Add(this.lab_Passwd);
            this.Controls.Add(this.lab_UserName);
            this.Controls.Add(this.picbox_Captcha);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txtbox_Captcha);
            this.Controls.Add(this.txtbox_Passwd);
            this.Controls.Add(this.txtbox_UserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "超市管理系统登录";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmLogin_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Captcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_UserName;
        private System.Windows.Forms.TextBox txtbox_Passwd;
        private System.Windows.Forms.TextBox txtbox_Captcha;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.PictureBox picbox_Captcha;
        private System.Windows.Forms.Label lab_UserName;
        private System.Windows.Forms.Label lab_Passwd;
        private System.Windows.Forms.Label lab_captcha;
        private System.Windows.Forms.LinkLabel linklab_Forget;
    }
}