// using Markdig;

namespace RandomStudent
{
    partial class Form1
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
            没啥用的关于 = new Button();
            退出 = new Button();
            随机学生 = new Button();
            NameLabel = new Label();
            使用说明 = new Button();
            设置 = new Button();
            测试功能 = new Label();
            SuspendLayout();
            // 
            // 没啥用的关于
            // 
            没啥用的关于.Location = new Point(25, 93);
            没啥用的关于.Name = "没啥用的关于";
            没啥用的关于.Size = new Size(100, 22);
            没啥用的关于.TabIndex = 1;
            没啥用的关于.Text = "没啥用的关于";
            没啥用的关于.Click += About;
            // 
            // 退出
            // 
            退出.Location = new Point(50, 115);
            退出.Name = "退出";
            退出.Size = new Size(50, 22);
            退出.TabIndex = 0;
            退出.Text = "退出";
            退出.UseVisualStyleBackColor = true;
            退出.Click += Exit;
            // 
            // 随机学生
            // 
            随机学生.Location = new Point(35, 71);
            随机学生.Name = "随机学生";
            随机学生.Size = new Size(80, 22);
            随机学生.TabIndex = 0;
            随机学生.Text = "随机学生";
            随机学生.UseVisualStyleBackColor = true;
            随机学生.Click += ChangeName;
            // 
            // NameLabel
            // 
            NameLabel.Font = new Font("Microsoft YaHei UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            NameLabel.Location = new Point(12, 31);
            NameLabel.Name = "NameLabel";
            NameLabel.RightToLeft = RightToLeft.No;
            NameLabel.Size = new Size(126, 35);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "随机学生";
            NameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // 使用说明
            // 
            使用说明.FlatStyle = FlatStyle.Popup;
            使用说明.Location = new Point(75, 154);
            使用说明.Name = "使用说明";
            使用说明.Size = new Size(75, 22);
            使用说明.TabIndex = 2;
            使用说明.Text = "使用说明";
            使用说明.UseVisualStyleBackColor = true;
            使用说明.Click += GetHelp;
            // 
            // 设置
            // 
            设置.FlatStyle = FlatStyle.Popup;
            设置.Location = new Point(0, 154);
            设置.Name = "设置";
            设置.Size = new Size(75, 23);
            设置.TabIndex = 3;
            设置.Text = "设置";
            设置.UseVisualStyleBackColor = true;
            设置.Click += GoToSetting;
            // 
            // 测试功能
            // 
            测试功能.AutoSize = true;
            测试功能.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            测试功能.Location = new Point(0, 0);
            测试功能.Name = "测试功能";
            测试功能.Size = new Size(59, 13);
            测试功能.TabIndex = 4;
            测试功能.Text = "测试功能";
            测试功能.Click += TestFeature;
/*
            string test = "# 测试\r\n\r\n![test][tmp]\r\n\r\n[tmp]:data:image/png;base64,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";
            WebBrowser webBrowser = new WebBrowser()
            {
                Dock = DockStyle.Fill,
                DocumentText = Markdown.ToHtml(test)
            };
            Controls.Add(webBrowser);
*/ // TestFeature: Help doc

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(150, 176);
            Controls.Add(测试功能);
            Controls.Add(设置);
            Controls.Add(使用说明);
            Controls.Add(随机学生);
            Controls.Add(NameLabel);
            Controls.Add(退出);
            Controls.Add(没啥用的关于);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Opacity = 0.8D;
            Text = "Form1";
            TopMost = true;
            Load += ReadFile;
            MouseDown += Form1_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        public Button 没啥用的关于;
        public Button 退出;
        public Button 随机学生;
        public Label NameLabel;
        private Button 使用说明;
        private Button 设置;
        private Label 测试功能;
    }
}