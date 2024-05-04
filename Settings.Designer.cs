namespace RandomStudent
{
    partial class Settings
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
            导入名单 = new Label();
            导入_名单 = new Button();
            清除缓存 = new Label();
            清除 = new Button();
            UP设置 = new Label();
            UP_导入 = new Button();
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
            导入_名单.Size = new Size(60, 23);
            导入_名单.TabIndex = 1;
            导入_名单.Text = "导入";
            导入_名单.UseVisualStyleBackColor = true;
            导入_名单.Click += Form1.OpenAndSave;
            // 
            // 清除缓存
            // 
            清除缓存.AutoSize = true;
            清除缓存.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            清除缓存.Location = new Point(12, 51);
            清除缓存.Name = "清除缓存";
            清除缓存.Size = new Size(74, 22);
            清除缓存.TabIndex = 2;
            清除缓存.Text = "清除缓存";
            // 
            // 清除
            // 
            清除.Location = new Point(196, 51);
            清除.Name = "清除";
            清除.Size = new Size(60, 23);
            清除.TabIndex = 3;
            清除.Text = "清除";
            清除.UseVisualStyleBackColor = true;
            清除.Click += Form1.release;
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
            UP_导入.Size = new Size(60, 23);
            UP_导入.TabIndex = 5;
            UP_导入.Text = "导入";
            UP_导入.UseVisualStyleBackColor = true;
            UP_导入.Click += UPWindow.UPImport;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 450);
            Controls.Add(UP_导入);
            Controls.Add(UP设置);
            Controls.Add(清除);
            Controls.Add(清除缓存);
            Controls.Add(导入_名单);
            Controls.Add(导入名单);
            Name = "Settings";
            Text = "Settings";
            TopMost = true;
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
    }
}