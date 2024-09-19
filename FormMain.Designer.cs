namespace CaptchaManual
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            文件ToolStripMenuItem = new ToolStripMenuItem();
            tsmiNew = new ToolStripMenuItem();
            tsmiImport = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            tsmiSave = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            tsmiExit = new ToolStripMenuItem();
            帮助ToolStripMenuItem = new ToolStripMenuItem();
            tsmiAbout = new ToolStripMenuItem();
            toolStripContainer1 = new ToolStripContainer();
            tlpWork = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            btnSelectDir = new Button();
            txtDir = new TextBox();
            label3 = new Label();
            txtURL = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            cbAutoDownload = new CheckBox();
            btnDownload = new Button();
            btnConfirm = new Button();
            txtCaptcha = new TextBox();
            pbCaptcha = new PictureBox();
            menuStrip1.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            tlpWork.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCaptcha).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 文件ToolStripMenuItem, 帮助ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(710, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            文件ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmiNew, tsmiImport, toolStripSeparator1, tsmiSave, toolStripSeparator2, tsmiExit });
            文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            文件ToolStripMenuItem.Size = new Size(44, 21);
            文件ToolStripMenuItem.Text = "文件";
            // 
            // tsmiNew
            // 
            tsmiNew.Name = "tsmiNew";
            tsmiNew.Size = new Size(100, 22);
            tsmiNew.Text = "新建";
            tsmiNew.Click += tsmiNew_Click;
            // 
            // tsmiImport
            // 
            tsmiImport.Name = "tsmiImport";
            tsmiImport.Size = new Size(100, 22);
            tsmiImport.Text = "导入";
            tsmiImport.Click += tsmiImport_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(97, 6);
            // 
            // tsmiSave
            // 
            tsmiSave.Name = "tsmiSave";
            tsmiSave.Size = new Size(100, 22);
            tsmiSave.Text = "保存";
            tsmiSave.Click += tsmiSave_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(97, 6);
            // 
            // tsmiExit
            // 
            tsmiExit.Name = "tsmiExit";
            tsmiExit.Size = new Size(100, 22);
            tsmiExit.Text = "退出";
            tsmiExit.Click += tsmiExit_Click;
            // 
            // 帮助ToolStripMenuItem
            // 
            帮助ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmiAbout });
            帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            帮助ToolStripMenuItem.Size = new Size(44, 21);
            帮助ToolStripMenuItem.Text = "帮助";
            // 
            // tsmiAbout
            // 
            tsmiAbout.Name = "tsmiAbout";
            tsmiAbout.Size = new Size(100, 22);
            tsmiAbout.Text = "关于";
            tsmiAbout.Click += tsmiAbout_Click;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(tlpWork);
            toolStripContainer1.ContentPanel.Margin = new Padding(2, 2, 2, 2);
            toolStripContainer1.ContentPanel.Size = new Size(710, 372);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Margin = new Padding(2, 2, 2, 2);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(710, 397);
            toolStripContainer1.TabIndex = 1;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(menuStrip1);
            // 
            // tlpWork
            // 
            tlpWork.ColumnCount = 1;
            tlpWork.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpWork.Controls.Add(groupBox1, 0, 0);
            tlpWork.Controls.Add(groupBox2, 0, 1);
            tlpWork.Dock = DockStyle.Fill;
            tlpWork.Enabled = false;
            tlpWork.Location = new Point(0, 0);
            tlpWork.Margin = new Padding(2, 2, 2, 2);
            tlpWork.Name = "tlpWork";
            tlpWork.RowCount = 2;
            tlpWork.RowStyles.Add(new RowStyle(SizeType.Absolute, 142F));
            tlpWork.RowStyles.Add(new RowStyle(SizeType.Absolute, 14F));
            tlpWork.Size = new Size(710, 372);
            tlpWork.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSelectDir);
            groupBox1.Controls.Add(txtDir);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtURL);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(2, 2);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(706, 138);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "基本配置";
            // 
            // btnSelectDir
            // 
            btnSelectDir.Location = new Point(596, 104);
            btnSelectDir.Margin = new Padding(2, 2, 2, 2);
            btnSelectDir.Name = "btnSelectDir";
            btnSelectDir.Size = new Size(71, 24);
            btnSelectDir.TabIndex = 6;
            btnSelectDir.Text = "选择";
            btnSelectDir.UseVisualStyleBackColor = true;
            btnSelectDir.Click += btnSelectDir_Click;
            // 
            // txtDir
            // 
            txtDir.Location = new Point(80, 106);
            txtDir.Margin = new Padding(2, 2, 2, 2);
            txtDir.Name = "txtDir";
            txtDir.ReadOnly = true;
            txtDir.Size = new Size(498, 23);
            txtDir.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 108);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 17);
            label3.TabIndex = 4;
            label3.Text = "数据目录：";
            // 
            // txtURL
            // 
            txtURL.Location = new Point(80, 62);
            txtURL.Margin = new Padding(2, 2, 2, 2);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(589, 23);
            txtURL.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 67);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 2;
            label2.Text = "下载地址：";
            // 
            // txtName
            // 
            txtName.Location = new Point(80, 23);
            txtName.Margin = new Padding(2, 2, 2, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(589, 23);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 27);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 17);
            label1.TabIndex = 0;
            label1.Text = "项目名称：";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbAutoDownload);
            groupBox2.Controls.Add(btnDownload);
            groupBox2.Controls.Add(btnConfirm);
            groupBox2.Controls.Add(txtCaptcha);
            groupBox2.Controls.Add(pbCaptcha);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(2, 144);
            groupBox2.Margin = new Padding(2, 2, 2, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 2, 2, 2);
            groupBox2.Size = new Size(706, 226);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "数据验证";
            // 
            // cbAutoDownload
            // 
            cbAutoDownload.AutoSize = true;
            cbAutoDownload.Location = new Point(434, 144);
            cbAutoDownload.Margin = new Padding(2, 2, 2, 2);
            cbAutoDownload.Name = "cbAutoDownload";
            cbAutoDownload.Size = new Size(111, 21);
            cbAutoDownload.TabIndex = 12;
            cbAutoDownload.Text = "确认后自动下载";
            cbAutoDownload.UseVisualStyleBackColor = true;
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(174, 144);
            btnDownload.Margin = new Padding(2, 2, 2, 2);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(71, 24);
            btnDownload.TabIndex = 11;
            btnDownload.Text = "下载";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(515, 91);
            btnConfirm.Margin = new Padding(2, 2, 2, 2);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(71, 24);
            btnConfirm.TabIndex = 10;
            btnConfirm.Text = "确认";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtCaptcha
            // 
            txtCaptcha.Location = new Point(410, 91);
            txtCaptcha.Margin = new Padding(2, 2, 2, 2);
            txtCaptcha.Name = "txtCaptcha";
            txtCaptcha.Size = new Size(97, 23);
            txtCaptcha.TabIndex = 9;
            // 
            // pbCaptcha
            // 
            pbCaptcha.Location = new Point(137, 57);
            pbCaptcha.Margin = new Padding(2, 2, 2, 2);
            pbCaptcha.Name = "pbCaptcha";
            pbCaptcha.Size = new Size(146, 66);
            pbCaptcha.TabIndex = 8;
            pbCaptcha.TabStop = false;
            // 
            // FormMain
            // 
            AcceptButton = btnConfirm;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 397);
            Controls.Add(toolStripContainer1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Captcha Manual";
            Load += FormMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            tlpWork.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCaptcha).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 文件ToolStripMenuItem;
        private ToolStripMenuItem tsmiNew;
        private ToolStripMenuItem tsmiImport;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem tsmiSave;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem tsmiExit;
        private ToolStripContainer toolStripContainer1;
        private ToolStripMenuItem 帮助ToolStripMenuItem;
        private ToolStripMenuItem tsmiAbout;
        private TableLayoutPanel tlpWork;
        private GroupBox groupBox1;
        private TextBox txtDir;
        private Label label3;
        private TextBox txtURL;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private Button btnSelectDir;
        private GroupBox groupBox2;
        private Button btnConfirm;
        private TextBox txtCaptcha;
        private PictureBox pbCaptcha;
        private Button btnDownload;
        private CheckBox cbAutoDownload;
    }
}
