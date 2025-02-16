using System;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
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

        public void getIndex(object sender, EventArgs e)
        {
            currentIndex = UpdateMethod.SelectedIndex;
        }

        public String GetBrowser()
        {
            string _BrowserKey1 = @"Software\Clients\StartmenuInternet\";
            string _BrowserKey2 = @"\shell\open\command";

            RegistryKey _RegistryKey = Registry.CurrentUser.OpenSubKey(_BrowserKey1, false);
            if (_RegistryKey == null)
                _RegistryKey = Registry.LocalMachine.OpenSubKey(_BrowserKey1, false);
            String _Result = _RegistryKey.GetValue("").ToString();
            _RegistryKey.Close();

            _RegistryKey = Registry.LocalMachine.OpenSubKey(_BrowserKey1 + _Result + _BrowserKey2);
            _Result = _RegistryKey.GetValue("").ToString();
            _RegistryKey.Close();

            if (_Result.Contains("\""))
            {
                _Result = _Result.TrimStart('"');
                _Result = _Result.Substring(0, _Result.IndexOf('"'));
            }
            return _Result;
        }

        private void GithubLink(object sender, EventArgs e)
        {
            Process.Start(GetBrowser(), "https://github.com/dytdirt/RandomStudent");
        }


        private void BilibiliLink(object sender, EventArgs e)
        {
            Process.Start(GetBrowser(), "https://space.bilibili.com/525979420");
        }
    }
}
