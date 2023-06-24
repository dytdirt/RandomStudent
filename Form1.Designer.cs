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
            导入名单 = new Button();
            随机学生 = new Button();
            NameLabel = new Label();
            SuspendLayout();
            // 
            // 没啥用的关于
            // 
            没啥用的关于.Location = new Point(30, 105);
            没啥用的关于.Name = "没啥用的关于";
            没啥用的关于.Size = new Size(90, 25);
            没啥用的关于.TabIndex = 1;
            没啥用的关于.Text = "没啥用的关于";
            没啥用的关于.Click += About;
            // 
            // 退出
            // 
            退出.Location = new Point(55, 130);
            退出.Name = "退出";
            退出.Size = new Size(40, 25);
            退出.TabIndex = 0;
            退出.Text = "退出";
            退出.UseVisualStyleBackColor = true;
            退出.Click += Exit;
            // 
            // 导入名单
            // 
            导入名单.FlatStyle = FlatStyle.Popup;
            导入名单.Location = new Point(0, 0);
            导入名单.Name = "导入名单";
            导入名单.Size = new Size(70, 25);
            导入名单.TabIndex = 0;
            导入名单.Text = "导入名单";
            导入名单.UseVisualStyleBackColor = true;
            导入名单.Click += OpenAndSave;
            // 
            // 随机学生
            // 
            随机学生.Location = new Point(40, 80);
            随机学生.Name = "随机学生";
            随机学生.Size = new Size(70, 25);
            随机学生.TabIndex = 0;
            随机学生.Text = "随机学生";
            随机学生.UseVisualStyleBackColor = true;
            随机学生.Click += StartRandom;
            // 
            // NameLabel
            // 
            NameLabel.Font = new Font("Microsoft YaHei UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            NameLabel.Location = new Point(12, 35);
            NameLabel.Name = "NameLabel";
            NameLabel.RightToLeft = RightToLeft.No;
            NameLabel.Size = new Size(126, 40);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "随机学生";
            NameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(150, 200);
            Controls.Add(随机学生);
            Controls.Add(NameLabel);
            Controls.Add(导入名单);
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
        }



        #endregion

        public Button 没啥用的关于;
        public Button 退出;
        public Button 导入名单;
        public Button 随机学生;
        public Label NameLabel;
    }
}