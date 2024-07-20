<<<<<<< HEAD
﻿namespace RandomStudent
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
            带权抽取 = new Label();
            ((System.ComponentModel.ISupportInitialize)UP个数).BeginInit();
            SuspendLayout();
            // 
            // 导入名单
            // 
            导入名单.AutoSize = true;
            导入名单.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            导入名单.Location = new Point(12, 22);
            导入名单.Name = "导入名单";
            导入名单.Size = new Size(74, 22);
            导入名单.TabIndex = 0;
            导入名单.Text = "导入名单";
            导入名单.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // 导入_名单
            // 
            导入_名单.Location = new Point(196, 22);
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
            清除缓存.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
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
            UP设置.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
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
            UP_导入.Click += Currency.UPImport;
            // 
            // 连抽个数
            // 
            连抽个数.AutoSize = true;
            连抽个数.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            连抽个数.Location = new Point(12, 110);
            连抽个数.Name = "连抽个数";
            连抽个数.Size = new Size(180, 22);
            连抽个数.TabIndex = 6;
            连抽个数.Text = "(TestFeature)连抽个数";
            // 
            // UP个数
            // 
            UP个数.Location = new Point(196, 110);
            UP个数.Name = "UP个数";
            UP个数.Size = new Size(60, 22);
            UP个数.TabIndex = 7;
            UP个数.Value = 10;
            UP个数.ValueChanged += ValueChanged;
            //
            // 带权抽取
            //
            带权抽取.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            带权抽取.Location = new Point(12, 135);
            带权抽取.Name = "带权抽取";
            带权抽取.Size = new Size(74, 22);
            带权抽取.Text = "带权抽取";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 450);
            Controls.Add(UP个数);
            Controls.Add(连抽个数);
            Controls.Add(UP_导入);
            Controls.Add(UP设置);
            Controls.Add(清除);
            Controls.Add(清除缓存);
            Controls.Add(导入_名单);
            Controls.Add(导入名单);
            Controls.Add(带权抽取);
            Name = "Settings";
            Text = "Settings";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)UP个数).EndInit();
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
        private Label 带权抽取;
        public NumericUpDown UP个数;
        private CheckBox 权重_CheckBox;
    }
=======
﻿namespace RandomStudent
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
            ((System.ComponentModel.ISupportInitialize)UP个数).BeginInit();
            SuspendLayout();
            // 
            // 导入名单
            // 
            导入名单.AutoSize = true;
            导入名单.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            导入名单.Location = new Point(12, 22);
            导入名单.Name = "导入名单";
            导入名单.Size = new Size(74, 22);
            导入名单.TabIndex = 0;
            导入名单.Text = "导入名单";
            导入名单.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // 导入_名单
            // 
            导入_名单.Location = new Point(196, 22);
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
            清除缓存.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
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
            UP设置.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
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
            UP_导入.Click += Currency.UPImport;
            // 
            // 连抽个数
            // 
            连抽个数.AutoSize = true;
            连抽个数.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            连抽个数.Location = new Point(12, 110);
            连抽个数.Name = "连抽个数";
            连抽个数.Size = new Size(180, 22);
            连抽个数.TabIndex = 6;
            连抽个数.Text = "(TestFeature)连抽个数";
            // 
            // UP个数
            // 
            UP个数.Location = new Point(196, 110);
            UP个数.Name = "UP个数";
            UP个数.Size = new Size(60, 22);
            UP个数.TabIndex = 7;
            UP个数.Value = 10;
            UP个数.ValueChanged += ValueChanged;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 450);
            Controls.Add(UP个数);
            Controls.Add(连抽个数);
            Controls.Add(UP_导入);
            Controls.Add(UP设置);
            Controls.Add(清除);
            Controls.Add(清除缓存);
            Controls.Add(导入_名单);
            Controls.Add(导入名单);
            Name = "Settings";
            Text = "Settings";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)UP个数).EndInit();
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
    }
>>>>>>> 88cd3c4068fb401c9db4e010f5899057c394ff73
}