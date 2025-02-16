using System.Runtime.InteropServices;
using System.Text;
// using Markdig;
using static RandomStudent.Currency;
using static Base64.Base64;
using System.Runtime.Versioning;

namespace RandomStudent
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        [SupportedOSPlatform("windows")]
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        /// <summary>
        /// Release the array that stored the count of studentlist.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void release(object sender, EventArgs e)
        {
            Map = new int[100];
            return;
        }
        /// <summary>
        /// It only used in Form1.cs ...
        /// And I think it's unnecessary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        [SupportedOSPlatform("windows")]
        public void ReadFile(object sender, EventArgs e)
        {
            int i = 0;
            string FileName = @"student.dll";
            string? LineData;
            if (File.Exists(@"student.dll"))
            {
                StreamReader reader;
                if (GetTextFileEncodingType(FileName) == Encoding.UTF8)
                    reader = new StreamReader(FileName, Encoding.UTF8);
                else
                    reader = new StreamReader(FileName, Encoding.GetEncoding("GB2312"));


                string TempFile = "tmp.dat";
                StreamWriter writer = new StreamWriter(TempFile, false);
                writer.Write(UnicodeToString(DecryptBase64(reader.ReadToEnd())));
                reader.Close();
                writer.Close();

                if (!File.Exists(TempFile)) File.Create(TempFile);
                reader = new StreamReader(@"tmp.dat");

                line = Convert.ToInt32(reader.ReadLine());
                while (i < line)
                {
                    LineData = reader.ReadLine();
                    ListOfStudents[i++] = LineData;
                }
                i = 0;
                while (i < line)
                {
                    LineData = reader.ReadLine();
                    Map[i++] = Convert.ToInt32(LineData);
                }
                UPnum = Convert.ToInt32(reader.ReadLine());
                i = 0;
                while(i < UPnum)
                {
                    LineData = reader.ReadLine();
                    UPList[i++] = LineData;
                }
                //currentIndex = Convert.ToInt32(reader.ReadLine());
                reader.Close();
                File.Delete(TempFile);
            }
            else
            {
                MessageBox.Show("未找到学生名单，请导入！");
                OpenFile(sender, e);
                SaveFile(sender, e);
            }

        }


        [SupportedOSPlatform("windows")]
        public void ChangeName(object sender, EventArgs e)
        {
            TopMost = true;
            NameLabel.Text = StartRandom(IsUP);
            System.Media.SystemSounds.Asterisk.Play();
        }

        [SupportedOSPlatform("windows")]
        public void About(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright 2023 dyt_dirt\r\n\r\n   Licensed under the Apache License, Version 2.0 (the \"License\");\r\n   you may not use this file except in compliance with the License.\r\n   You may obtain a copy of the License at\r\n\r\n       http://www.apache.org/licenses/LICENSE-2.0\r\n\r\n   Unless required by applicable law or agreed to in writing, software\r\n   distributed under the License is distributed on an \"AS IS\" BASIS,\r\n   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.\r\n   See the License for the specific language governing permissions and\r\n   limitations under the License.");
        }

        [SupportedOSPlatform("windows")]
        public void Exit(object sender, EventArgs e)
        {
            SaveFile(sender, e);
            Close();
        }

        [SupportedOSPlatform("windows")]
        public void GetHelp(object sender, EventArgs e)
        {
            // 这里是一个废案，本来想做使用方法的弹窗，结果我懒（手动狗头）

            MessageBox.Show("毫无疑问这里是个废案。\r\n\r\n Without a doubt, this is an abandoned case.");
        }

        [SupportedOSPlatform("windows")]
        private void GoToSetting(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        [SupportedOSPlatform("windows")]
        private void TestFeature(object sender, EventArgs e)
        {
            UPWindow window = new UPWindow();
            window.Show();
        }

    }
}