using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RandomStudent.Currency;

namespace RandomStudent
{
    public partial class UPWindow : Form
    {
        public int ticks = 0;
        public UPWindow()
        {
            InitializeComponent();
        }
        [SupportedOSPlatform("windows")]
        public void OnLoad(object sender, EventArgs e)
        {
            for (int i = 1; i < 100; i++)
            {
                names[i] = new Label();
                names[i].Name = i.ToString();
                names[i].Text = " ";
                names[i].Size = names[i - 1].Size;
                names[i].Location = new Point(names[i - 1].Location.X, names[i - 1].Location.Y);

            }
        }
        [SupportedOSPlatform("windows")]
        public void timerTick(object sender, EventArgs e)
        {
            if (++ticks <= standardNum)
                GetUP(ticks);
            else
                timer.Enabled = false;
        }
        [SupportedOSPlatform("windows")]
        public void GetUP(int i)
        {

            names[i].Text = StartRandom(true);
            names[i].Size = names[i - 1].Size;
            names[i].Location = new Point(names[i - 1].Location.X, names[i - 1].Location.Y + 35);
            names[i].Font = new Font("Microsoft YaHei UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            names[i].TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(names[i]);
        }
    }
}
