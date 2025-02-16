namespace RandomStudent
{
    public partial class Settings
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
        public void InitializeComponent()
        {
            导入名单 = new Label();
            导入_名单 = new Button();
            清除缓存 = new Label();
            清除 = new Button();
            UP设置 = new Label();
            UP_导入 = new Button();
            连抽个数 = new Label();
            UP个数 = new NumericUpDown();
            访问仓库 = new Label();
            Github = new PictureBox();
            Bilibili = new PictureBox();
            BugRepo = new Label();
            Email = new Label();
            QQID = new Label();
            自动更新 = new Label();
            UpdateMethod = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)UP个数).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Github).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Bilibili).BeginInit();
            SuspendLayout();
            // 
            // 导入名单
            // 
            导入名单.AutoSize = true;
            导入名单.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            导入名单.Location = new Point(12, 20);
            导入名单.Name = "导入名单";
            导入名单.Size = new Size(74, 22);
            导入名单.TabIndex = 0;
            导入名单.Text = "导入名单";
            导入名单.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // 导入_名单
            // 
            导入_名单.Location = new Point(196, 20);
            导入_名单.Name = "导入_名单";
            导入_名单.Size = new Size(60, 22);
            导入_名单.TabIndex = 1;
            导入_名单.Text = "导入";
            导入_名单.UseVisualStyleBackColor = true;
            导入_名单.Click += OpenAndSave;
            // 
            // 清除缓存
            // 
            清除缓存.AutoSize = true;
            清除缓存.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            清除缓存.Location = new Point(12, 50);
            清除缓存.Name = "清除缓存";
            清除缓存.Size = new Size(74, 22);
            清除缓存.TabIndex = 2;
            清除缓存.Text = "清除缓存";
            // 
            // 清除
            // 
            清除.Location = new Point(196, 50);
            清除.Name = "清除";
            清除.Size = new Size(60, 22);
            清除.TabIndex = 3;
            清除.Text = "清除";
            清除.UseVisualStyleBackColor = true;
            // 
            // UP设置
            // 
            UP设置.AutoSize = true;
            UP设置.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            UP设置.Location = new Point(12, 80);
            UP设置.Name = "UP设置";
            UP设置.Size = new Size(97, 22);
            UP设置.TabIndex = 4;
            UP设置.Text = "手动设置UP";
            // 
            // UP_导入
            // 
            UP_导入.Location = new Point(196, 80);
            UP_导入.Name = "UP_导入";
            UP_导入.Size = new Size(60, 22);
            UP_导入.TabIndex = 5;
            UP_导入.Text = "导入";
            UP_导入.UseVisualStyleBackColor = true;
            // 
            // 连抽个数
            // 
            连抽个数.AutoSize = true;
            连抽个数.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            连抽个数.Location = new Point(12, 110);
            连抽个数.Name = "连抽个数";
            连抽个数.Size = new Size(74, 22);
            连抽个数.TabIndex = 6;
            连抽个数.Text = "连抽个数";
            // 
            // UP个数
            // 
            UP个数.Location = new Point(196, 110);
            UP个数.Name = "UP个数";
            UP个数.Size = new Size(60, 23);
            UP个数.TabIndex = 7;
            UP个数.Value = new decimal(new int[] { 10, 0, 0, 0 });
            UP个数.ValueChanged += ValueChanged;
            // 
            // 访问仓库
            // 
            访问仓库.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            访问仓库.Location = new Point(12, 270);
            访问仓库.Name = "访问仓库";
            访问仓库.Size = new Size(74, 22);
            访问仓库.TabIndex = 8;
            访问仓库.Text = "关于作者";
            // 
            // Github
            // 
            Github.Image = Properties.Resources.github;
            Github.Location = new Point(196, 270);
            Github.Name = "Github";
            Github.Size = new Size(32, 32);
            Github.TabIndex = 10;
            Github.TabStop = false;
            Github.Click += GithubLink;
            // 
            // Bilibili
            // 
            Bilibili.Image = Properties.Resources.bilibili;
            Bilibili.Location = new Point(234, 270);
            Bilibili.Name = "Bilibili";
            Bilibili.Size = new Size(32, 32);
            Bilibili.TabIndex = 11;
            Bilibili.TabStop = false;
            Bilibili.Click += BilibiliLink;
            // 
            // BugRepo
            // 
            BugRepo.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            BugRepo.Location = new Point(12, 300);
            BugRepo.Name = "BugRepo";
            BugRepo.Size = new Size(90, 22);
            BugRepo.TabIndex = 12;
            BugRepo.Text = "BUG反馈:";
            // 
            // Email
            // 
            Email.Font = new Font("Microsoft YaHei UI", 9F);
            Email.Location = new Point(92, 300);
            Email.Name = "Email";
            Email.Size = new Size(189, 22);
            Email.TabIndex = 13;
            Email.Text = "邮箱:www7722776@163.com";
            // 
            // QQID
            // 
            QQID.Font = new Font("Microsoft YaHei UI", 9F);
            QQID.Location = new Point(92, 320);
            QQID.Name = "QQID";
            QQID.Size = new Size(109, 22);
            QQID.TabIndex = 14;
            QQID.Text = "QQ:2702409836";
            // 
            // 自动更新
            // 
            自动更新.AutoSize = true;
            自动更新.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            自动更新.Location = new Point(12, 140);
            自动更新.Name = "自动更新";
            自动更新.Size = new Size(74, 22);
            自动更新.TabIndex = 15;
            自动更新.Text = "自动更新";
            // 
            // UpdatedMethod
            // 
            UpdateMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            UpdateMethod.FormattingEnabled = true;
            UpdateMethod.Items.AddRange(new object[] { "检查并自动更新", "检查更新并提醒", "不检查更新" });
            UpdateMethod.Location = new Point(135, 140);
            UpdateMethod.Name = "更新方式";
            UpdateMethod.Size = new Size(121, 23);
            UpdateMethod.TabIndex = 16;
            UpdateMethod.SelectedIndexChanged += getIndex;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 450);
            Controls.Add(UpdateMethod);
            Controls.Add(自动更新);
            Controls.Add(QQID);
            Controls.Add(Email);
            Controls.Add(BugRepo);
            Controls.Add(Bilibili);
            Controls.Add(Github);
            Controls.Add(UP个数);
            Controls.Add(连抽个数);
            Controls.Add(UP_导入);
            Controls.Add(UP设置);
            Controls.Add(清除);
            Controls.Add(清除缓存);
            Controls.Add(导入_名单);
            Controls.Add(导入名单);
            Controls.Add(访问仓库);
            Name = "Settings";
            Text = "Settings";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)UP个数).EndInit();
            ((System.ComponentModel.ISupportInitialize)Github).EndInit();
            ((System.ComponentModel.ISupportInitialize)Bilibili).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label 导入名单;
        private Button 导入_名单;
        private Label 清除缓存;
        private Button 清除;
        private Label UP设置;
        private Button UP_导入;
        private Label 连抽个数;
        public NumericUpDown UP个数;
        private CheckBox 权重_CheckBox;
        private Label 访问仓库;
        private PictureBox Github;
        private PictureBox Bilibili;
        private Label BugRepo;
        private Label Email;
        private Label QQID;
        private Label 自动更新;
        public ComboBox UpdateMethod;
    }
}