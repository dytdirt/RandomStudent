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
            names[0] = new Label();
            SuspendLayout();
            //
            // timer
            //
            timer.Enabled = true;
            timer.Interval = 200;
            timer.Tick += timerTick;
            timer.Start();
            // 
            // UPWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(220, 450);
            Name = "UPWindow";
            Text = "UPWindow";
            Load += OnLoad;
            ResumeLayout(false);
        }

        #endregion

        public Label[] names;
        private System.Windows.Forms.Timer timer;
    }
}