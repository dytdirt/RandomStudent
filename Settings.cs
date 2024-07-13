using System;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
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

        [SupportedOSPlatform("windows")]
        public void OpenAndSave(object sender, EventArgs e)
        {
            OpenFile(sender, e);
            SaveFile(sender, e);
        }

        [SupportedOSPlatform("windows")]
        public void ValueChanged(object sender, EventArgs e)
        {
            standardNum = Convert.ToInt32(UP个数.Value);
        }
    }
}
