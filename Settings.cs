using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RandomStudent.Currency;

namespace RandomStudent
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        public void OpenAndSave(object sender, EventArgs e)
        {
            OpenFile(sender, e);
            SaveFile(sender, e);
        }
    }
}
