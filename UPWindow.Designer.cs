using System.Xml;

namespace RandomStudent
{
    partial class UPWindow
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
            components = new System.ComponentModel.Container();
            timer = new System.Windows.Forms.Timer(components);
            names = new Label[100];
            SuspendLayout();
            //
            // timer
            //
            timer.Enabled = true;
            timer.Interval = 200;
            timer.Tick += timerTick;
            timer.Start();
            //
            // names' init
            //
            names[0] = new Label();
            names[0].Font = new Font("Microsoft YaHei UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            names[0].Location = new Point(47, 10);
            names[0].Name = "names[0]";
            names[0].RightToLeft = RightToLeft.No;
            names[0].Size = new Size(126, 35);
            names[0].TabIndex = 0;
            names[0].Text = " ";
            names[0].TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UPWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(220, 450);
            Name = "UPWindow";
            Text = "UPWindow";
            Load += OnLoad;
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label[] names;
        private System.Windows.Forms.Timer timer;
    }
}