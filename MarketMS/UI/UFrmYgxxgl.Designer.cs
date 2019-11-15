namespace MarketMS.UI
{
    partial class UFrmYgxxgl
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtn_Save = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Cancel = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Add = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Edit = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Del = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Export = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Exit = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lab_cxtj = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txtbox_cxtjLN = new System.Windows.Forms.TextBox();
            this.cmbox_cxtj = new System.Windows.Forms.ComboBox();
            this.cmbox_cxtjPS = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lab_Passwd = new System.Windows.Forms.Label();
            this.lab_Address = new System.Windows.Forms.Label();
            this.lab_Tel = new System.Windows.Forms.Label();
            this.lab_Position = new System.Windows.Forms.Label();
            this.lab_Age = new System.Windows.Forms.Label();
            this.lab_Sex = new System.Windows.Forms.Label();
            this.lab_Name = new System.Windows.Forms.Label();
            this.lab_LoginName = new System.Windows.Forms.Label();
            this.txtbox_Passwd = new System.Windows.Forms.TextBox();
            this.txtbox_Address = new System.Windows.Forms.TextBox();
            this.txtbox_Tel = new System.Windows.Forms.TextBox();
            this.cmbox_Position = new System.Windows.Forms.ComboBox();
            this.txtbox_Age = new System.Windows.Forms.TextBox();
            this.cmbox_Sex = new System.Windows.Forms.ComboBox();
            this.txtbox_Name = new System.Windows.Forms.TextBox();
            this.txtbox_LoginName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tsbtn_Search = new System.Windows.Forms.ToolStripDropDownButton();
            this.查看本人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.查看员工总人数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看所有员工信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看各职位员工数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lab_ID = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtn_Search,
            this.tsbtn_Save,
            this.tsbtn_Cancel,
            this.tsbtn_Add,
            this.tsbtn_Edit,
            this.tsbtn_Del,
            this.tsbtn_Export,
            this.tsbtn_Exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(913, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtn_Save
            // 
            this.tsbtn_Save.Image = global::MarketMS.Properties.Resources.save;
            this.tsbtn_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Save.Name = "tsbtn_Save";
            this.tsbtn_Save.Size = new System.Drawing.Size(52, 22);
            this.tsbtn_Save.Text = "保存";
            this.tsbtn_Save.Click += new System.EventHandler(this.tsbtn_Save_Click);
            // 
            // tsbtn_Cancel
            // 
            this.tsbtn_Cancel.Image = global::MarketMS.Properties.Resources.back;
            this.tsbtn_Cancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Cancel.Name = "tsbtn_Cancel";
            this.tsbtn_Cancel.Size = new System.Drawing.Size(52, 22);
            this.tsbtn_Cancel.Text = "取消";
            this.tsbtn_Cancel.Click += new System.EventHandler(this.tsbtn_Cancel_Click);
            // 
            // tsbtn_Add
            // 
            this.tsbtn_Add.Image = global::MarketMS.Properties.Resources.add;
            this.tsbtn_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Add.Name = "tsbtn_Add";
            this.tsbtn_Add.Size = new System.Drawing.Size(52, 22);
            this.tsbtn_Add.Text = "添加";
            this.tsbtn_Add.Click += new System.EventHandler(this.tsbtn_Add_Click);
            // 
            // tsbtn_Edit
            // 
            this.tsbtn_Edit.Image = global::MarketMS.Properties.Resources.edit;
            this.tsbtn_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Edit.Name = "tsbtn_Edit";
            this.tsbtn_Edit.Size = new System.Drawing.Size(52, 22);
            this.tsbtn_Edit.Text = "修改";
            this.tsbtn_Edit.Click += new System.EventHandler(this.tsbtn_Edit_Click);
            // 
            // tsbtn_Del
            // 
            this.tsbtn_Del.Image = global::MarketMS.Properties.Resources.delete;
            this.tsbtn_Del.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Del.Name = "tsbtn_Del";
            this.tsbtn_Del.Size = new System.Drawing.Size(52, 22);
            this.tsbtn_Del.Text = "删除";
            this.tsbtn_Del.Click += new System.EventHandler(this.tsbtn_Del_Click);
            // 
            // tsbtn_Export
            // 
            this.tsbtn_Export.Image = global::MarketMS.Properties.Resources.excel;
            this.tsbtn_Export.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Export.Name = "tsbtn_Export";
            this.tsbtn_Export.Size = new System.Drawing.Size(52, 22);
            this.tsbtn_Export.Text = "导出";
            this.tsbtn_Export.Click += new System.EventHandler(this.tsbtn_Export_Click);
            // 
            // tsbtn_Exit
            // 
            this.tsbtn_Exit.Image = global::MarketMS.Properties.Resources.exit;
            this.tsbtn_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Exit.Name = "tsbtn_Exit";
            this.tsbtn_Exit.Size = new System.Drawing.Size(52, 22);
            this.tsbtn_Exit.Text = "退出";
            this.tsbtn_Exit.Click += new System.EventHandler(this.tsbtn_Exit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.lab_cxtj);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.txtbox_cxtjLN);
            this.groupBox1.Controls.Add(this.cmbox_cxtj);
            this.groupBox1.Controls.Add(this.cmbox_cxtjPS);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(3, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(907, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询";
            // 
            // lab_cxtj
            // 
            this.lab_cxtj.AutoSize = true;
            this.lab_cxtj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lab_cxtj.Location = new System.Drawing.Point(48, 24);
            this.lab_cxtj.Name = "lab_cxtj";
            this.lab_cxtj.Size = new System.Drawing.Size(65, 12);
            this.lab_cxtj.TabIndex = 4;
            this.lab_cxtj.Text = "查询条件：";
            // 
            // btn_Search
            // 
            this.btn_Search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Search.Location = new System.Drawing.Point(396, 19);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "查询";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txtbox_cxtjLN
            // 
            this.txtbox_cxtjLN.Location = new System.Drawing.Point(269, 20);
            this.txtbox_cxtjLN.Name = "txtbox_cxtjLN";
            this.txtbox_cxtjLN.Size = new System.Drawing.Size(100, 21);
            this.txtbox_cxtjLN.TabIndex = 1;
            this.txtbox_cxtjLN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_cxtjLN_KeyPress);
            // 
            // cmbox_cxtj
            // 
            this.cmbox_cxtj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_cxtj.FormattingEnabled = true;
            this.cmbox_cxtj.Items.AddRange(new object[] {
            "按用户名查找",
            "按姓名查找",
            "按职位查找",
            "按性别查找",
            "查看所有员工信息",
            "查看各职位员工数"});
            this.cmbox_cxtj.Location = new System.Drawing.Point(119, 20);
            this.cmbox_cxtj.Name = "cmbox_cxtj";
            this.cmbox_cxtj.Size = new System.Drawing.Size(120, 20);
            this.cmbox_cxtj.TabIndex = 0;
            this.cmbox_cxtj.SelectedIndexChanged += new System.EventHandler(this.cmbox_cxtj_SelectedIndexChanged);
            // 
            // cmbox_cxtjPS
            // 
            this.cmbox_cxtjPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_cxtjPS.FormattingEnabled = true;
            this.cmbox_cxtjPS.Location = new System.Drawing.Point(269, 20);
            this.cmbox_cxtjPS.Name = "cmbox_cxtjPS";
            this.cmbox_cxtjPS.Size = new System.Drawing.Size(100, 20);
            this.cmbox_cxtjPS.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lab_ID);
            this.groupBox2.Controls.Add(this.lab_Passwd);
            this.groupBox2.Controls.Add(this.lab_Address);
            this.groupBox2.Controls.Add(this.lab_Tel);
            this.groupBox2.Controls.Add(this.lab_Position);
            this.groupBox2.Controls.Add(this.lab_Age);
            this.groupBox2.Controls.Add(this.lab_Sex);
            this.groupBox2.Controls.Add(this.lab_Name);
            this.groupBox2.Controls.Add(this.lab_LoginName);
            this.groupBox2.Controls.Add(this.txtbox_Passwd);
            this.groupBox2.Controls.Add(this.txtbox_Address);
            this.groupBox2.Controls.Add(this.txtbox_Tel);
            this.groupBox2.Controls.Add(this.cmbox_Position);
            this.groupBox2.Controls.Add(this.txtbox_Age);
            this.groupBox2.Controls.Add(this.cmbox_Sex);
            this.groupBox2.Controls.Add(this.txtbox_Name);
            this.groupBox2.Controls.Add(this.txtbox_LoginName);
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(3, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(907, 144);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "员工信息";
            // 
            // lab_Passwd
            // 
            this.lab_Passwd.AutoSize = true;
            this.lab_Passwd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lab_Passwd.Location = new System.Drawing.Point(325, 115);
            this.lab_Passwd.Name = "lab_Passwd";
            this.lab_Passwd.Size = new System.Drawing.Size(65, 12);
            this.lab_Passwd.TabIndex = 15;
            this.lab_Passwd.Text = "密    码：";
            // 
            // lab_Address
            // 
            this.lab_Address.AutoSize = true;
            this.lab_Address.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lab_Address.Location = new System.Drawing.Point(48, 115);
            this.lab_Address.Name = "lab_Address";
            this.lab_Address.Size = new System.Drawing.Size(65, 12);
            this.lab_Address.TabIndex = 14;
            this.lab_Address.Text = "住    址：";
            // 
            // lab_Tel
            // 
            this.lab_Tel.AutoSize = true;
            this.lab_Tel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lab_Tel.Location = new System.Drawing.Point(325, 84);
            this.lab_Tel.Name = "lab_Tel";
            this.lab_Tel.Size = new System.Drawing.Size(65, 12);
            this.lab_Tel.TabIndex = 13;
            this.lab_Tel.Text = "手    机：";
            // 
            // lab_Position
            // 
            this.lab_Position.AutoSize = true;
            this.lab_Position.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lab_Position.Location = new System.Drawing.Point(325, 54);
            this.lab_Position.Name = "lab_Position";
            this.lab_Position.Size = new System.Drawing.Size(65, 12);
            this.lab_Position.TabIndex = 12;
            this.lab_Position.Text = "职    位：";
            // 
            // lab_Age
            // 
            this.lab_Age.AutoSize = true;
            this.lab_Age.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lab_Age.Location = new System.Drawing.Point(325, 25);
            this.lab_Age.Name = "lab_Age";
            this.lab_Age.Size = new System.Drawing.Size(65, 12);
            this.lab_Age.TabIndex = 11;
            this.lab_Age.Text = "年    龄：";
            // 
            // lab_Sex
            // 
            this.lab_Sex.AutoSize = true;
            this.lab_Sex.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lab_Sex.Location = new System.Drawing.Point(48, 84);
            this.lab_Sex.Name = "lab_Sex";
            this.lab_Sex.Size = new System.Drawing.Size(65, 12);
            this.lab_Sex.TabIndex = 10;
            this.lab_Sex.Text = "性    别：";
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lab_Name.Location = new System.Drawing.Point(48, 54);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(65, 12);
            this.lab_Name.TabIndex = 9;
            this.lab_Name.Text = "姓    名：";
            // 
            // lab_LoginName
            // 
            this.lab_LoginName.AutoSize = true;
            this.lab_LoginName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lab_LoginName.Location = new System.Drawing.Point(48, 25);
            this.lab_LoginName.Name = "lab_LoginName";
            this.lab_LoginName.Size = new System.Drawing.Size(65, 12);
            this.lab_LoginName.TabIndex = 8;
            this.lab_LoginName.Text = "用 户 名：";
            // 
            // txtbox_Passwd
            // 
            this.txtbox_Passwd.Location = new System.Drawing.Point(396, 112);
            this.txtbox_Passwd.Name = "txtbox_Passwd";
            this.txtbox_Passwd.Size = new System.Drawing.Size(120, 21);
            this.txtbox_Passwd.TabIndex = 7;
            // 
            // txtbox_Address
            // 
            this.txtbox_Address.Location = new System.Drawing.Point(119, 112);
            this.txtbox_Address.Name = "txtbox_Address";
            this.txtbox_Address.Size = new System.Drawing.Size(120, 21);
            this.txtbox_Address.TabIndex = 6;
            // 
            // txtbox_Tel
            // 
            this.txtbox_Tel.Location = new System.Drawing.Point(396, 81);
            this.txtbox_Tel.Name = "txtbox_Tel";
            this.txtbox_Tel.Size = new System.Drawing.Size(120, 21);
            this.txtbox_Tel.TabIndex = 5;
            // 
            // cmbox_Position
            // 
            this.cmbox_Position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_Position.FormattingEnabled = true;
            this.cmbox_Position.Items.AddRange(new object[] {
            "系统管理员",
            "店长",
            "人事部",
            "销售部",
            "库存管理部",
            "销售员"});
            this.cmbox_Position.Location = new System.Drawing.Point(396, 51);
            this.cmbox_Position.Name = "cmbox_Position";
            this.cmbox_Position.Size = new System.Drawing.Size(120, 20);
            this.cmbox_Position.TabIndex = 4;
            // 
            // txtbox_Age
            // 
            this.txtbox_Age.Location = new System.Drawing.Point(396, 22);
            this.txtbox_Age.Name = "txtbox_Age";
            this.txtbox_Age.Size = new System.Drawing.Size(120, 21);
            this.txtbox_Age.TabIndex = 3;
            // 
            // cmbox_Sex
            // 
            this.cmbox_Sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_Sex.FormattingEnabled = true;
            this.cmbox_Sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cmbox_Sex.Location = new System.Drawing.Point(119, 81);
            this.cmbox_Sex.Name = "cmbox_Sex";
            this.cmbox_Sex.Size = new System.Drawing.Size(120, 20);
            this.cmbox_Sex.TabIndex = 2;
            // 
            // txtbox_Name
            // 
            this.txtbox_Name.Location = new System.Drawing.Point(119, 51);
            this.txtbox_Name.Name = "txtbox_Name";
            this.txtbox_Name.Size = new System.Drawing.Size(120, 21);
            this.txtbox_Name.TabIndex = 1;
            // 
            // txtbox_LoginName
            // 
            this.txtbox_LoginName.Location = new System.Drawing.Point(119, 22);
            this.txtbox_LoginName.Name = "txtbox_LoginName";
            this.txtbox_LoginName.Size = new System.Drawing.Size(120, 21);
            this.txtbox_LoginName.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 244);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(907, 289);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tsbtn_Search
            // 
            this.tsbtn_Search.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看本人信息ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.查看员工总人数ToolStripMenuItem,
            this.查看所有员工信息ToolStripMenuItem,
            this.查看各职位员工数ToolStripMenuItem});
            this.tsbtn_Search.Image = global::MarketMS.Properties.Resources.find;
            this.tsbtn_Search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Search.Name = "tsbtn_Search";
            this.tsbtn_Search.Size = new System.Drawing.Size(61, 22);
            this.tsbtn_Search.Text = "查看";
            // 
            // 查看本人信息ToolStripMenuItem
            // 
            this.查看本人信息ToolStripMenuItem.Name = "查看本人信息ToolStripMenuItem";
            this.查看本人信息ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.查看本人信息ToolStripMenuItem.Text = "查看本人信息";
            this.查看本人信息ToolStripMenuItem.Click += new System.EventHandler(this.查看本人信息ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(169, 6);
            // 
            // 查看员工总人数ToolStripMenuItem
            // 
            this.查看员工总人数ToolStripMenuItem.Name = "查看员工总人数ToolStripMenuItem";
            this.查看员工总人数ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.查看员工总人数ToolStripMenuItem.Text = "查看员工总人数";
            this.查看员工总人数ToolStripMenuItem.Click += new System.EventHandler(this.查看员工总人数ToolStripMenuItem_Click);
            // 
            // 查看所有员工信息ToolStripMenuItem
            // 
            this.查看所有员工信息ToolStripMenuItem.Name = "查看所有员工信息ToolStripMenuItem";
            this.查看所有员工信息ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.查看所有员工信息ToolStripMenuItem.Text = "查看所有员工信息";
            this.查看所有员工信息ToolStripMenuItem.Click += new System.EventHandler(this.查看所有员工信息ToolStripMenuItem_Click);
            // 
            // 查看各职位员工数ToolStripMenuItem
            // 
            this.查看各职位员工数ToolStripMenuItem.Name = "查看各职位员工数ToolStripMenuItem";
            this.查看各职位员工数ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.查看各职位员工数ToolStripMenuItem.Text = "查看各职位员工数";
            this.查看各职位员工数ToolStripMenuItem.Click += new System.EventHandler(this.查看各职位员工数ToolStripMenuItem_Click);
            // 
            // lab_ID
            // 
            this.lab_ID.AutoSize = true;
            this.lab_ID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lab_ID.Location = new System.Drawing.Point(553, 30);
            this.lab_ID.Name = "lab_ID";
            this.lab_ID.Size = new System.Drawing.Size(41, 12);
            this.lab_ID.TabIndex = 16;
            this.lab_ID.Text = "label1";
            this.lab_ID.Visible = false;
            // 
            // UFrmYgxxgl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UFrmYgxxgl";
            this.Size = new System.Drawing.Size(913, 536);
            this.Load += new System.EventHandler(this.UFrmYgxxgl_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtn_Save;
        private System.Windows.Forms.ToolStripButton tsbtn_Cancel;
        private System.Windows.Forms.ToolStripButton tsbtn_Add;
        private System.Windows.Forms.ToolStripButton tsbtn_Edit;
        private System.Windows.Forms.ToolStripButton tsbtn_Del;
        private System.Windows.Forms.ToolStripButton tsbtn_Export;
        private System.Windows.Forms.ToolStripButton tsbtn_Exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbox_cxtj;
        private System.Windows.Forms.TextBox txtbox_cxtjLN;
        private System.Windows.Forms.ComboBox cmbox_cxtjPS;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txtbox_Passwd;
        private System.Windows.Forms.TextBox txtbox_Address;
        private System.Windows.Forms.TextBox txtbox_Tel;
        private System.Windows.Forms.ComboBox cmbox_Position;
        private System.Windows.Forms.TextBox txtbox_Age;
        private System.Windows.Forms.ComboBox cmbox_Sex;
        private System.Windows.Forms.TextBox txtbox_Name;
        private System.Windows.Forms.TextBox txtbox_LoginName;
        private System.Windows.Forms.Label lab_Passwd;
        private System.Windows.Forms.Label lab_Address;
        private System.Windows.Forms.Label lab_Tel;
        private System.Windows.Forms.Label lab_Position;
        private System.Windows.Forms.Label lab_Age;
        private System.Windows.Forms.Label lab_Sex;
        private System.Windows.Forms.Label lab_Name;
        private System.Windows.Forms.Label lab_LoginName;
        private System.Windows.Forms.Label lab_cxtj;
        private System.Windows.Forms.ToolStripDropDownButton tsbtn_Search;
        private System.Windows.Forms.ToolStripMenuItem 查看本人信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 查看员工总人数ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看所有员工信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看各职位员工数ToolStripMenuItem;
        private System.Windows.Forms.Label lab_ID;
    }
}
