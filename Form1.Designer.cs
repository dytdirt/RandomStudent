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
            连抽 = new Button();
            SuspendLayout();
            // 
            // 没啥用的关于
            // 
            没啥用的关于.Location = new Point(25, 82);
            没啥用的关于.Name = "没啥用的关于";
            没啥用的关于.Size = new Size(100, 22);
            没啥用的关于.TabIndex = 1;
            没啥用的关于.Text = "没啥用的关于";
            没啥用的关于.Click += About;
            // 
            // 退出
            // 
            退出.Location = new Point(50, 126);
            退出.Name = "退出";
            退出.Size = new Size(50, 22);
            退出.TabIndex = 0;
            退出.Text = "退出";
            退出.UseVisualStyleBackColor = true;
            退出.Click += Exit;
            // 
            // 随机学生
            // 
            随机学生.Location = new Point(35, 60);
            随机学生.Name = "随机学生";
            随机学生.Size = new Size(80, 22);
            随机学生.TabIndex = 0;
            随机学生.Text = "随机学生";
            随机学生.UseVisualStyleBackColor = true;
            随机学生.Click += ChangeName;
            // 
            // NameLabel
            // 
            NameLabel.Font = new Font("Microsoft YaHei UI", 20F, FontStyle.Bold);
            NameLabel.Location = new Point(12, 20);
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
            使用说明.Location = new Point(75, 171);
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
            设置.Location = new Point(0, 171);
            设置.Name = "设置";
            设置.Size = new Size(75, 23);
            设置.TabIndex = 3;
            设置.Text = "设置";
            设置.UseVisualStyleBackColor = true;
            设置.Click += GoToSetting;
            // 
            // 连抽
            // 
            连抽.Location = new Point(50, 104);
            连抽.Name = "连抽";
            连抽.Size = new Size(50, 22);
            连抽.TabIndex = 0;
            连抽.Text = "连抽";
            连抽.Click += TestFeature;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(150, 193);
            Controls.Add(设置);
            Controls.Add(使用说明);
            Controls.Add(随机学生);
            Controls.Add(NameLabel);
            Controls.Add(退出);
            Controls.Add(没啥用的关于);
            Controls.Add(连抽);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Opacity = 0.8D;
            Text = "Form1";
            TopMost = true;
            Load += ReadFile;
            MouseDown += Form1_MouseDown;
            ResumeLayout(false);
        }



        #endregion

        public Button 没啥用的关于;
        public Button 退出;
        public Button 随机学生;
        public Label NameLabel;
        private Button 使用说明;
        private Button 设置;
        private Button 连抽;
    }
}