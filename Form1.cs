using System.Runtime.InteropServices;
using System.Text;
using static RandomStudent.Currency;

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

        // 添加窗体的MouseDown事件，并编写如下代码
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        static private int SearchIndex(string[] strings, string res)
        {
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i] == res)
                    return i;
            }
            return -1;
        }
        public static void release(object sender, EventArgs e)
        {
            Map = new int[100];
            return;
        }


        public void ReadFile(object sender, EventArgs e)
        {
            int i = 0;
            string FileName = @"student.dll";
            string LineData;
            if (File.Exists(@"student.dll"))
            {

                if (GetTextFileEncodingType(FileName) == Encoding.UTF8)
                {
                    StreamReader reader = new StreamReader(FileName, Encoding.UTF8);
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

                    reader.Close();
                }
                else
                {
                    StreamReader reader = new StreamReader(FileName, Encoding.GetEncoding("GB2312"));
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

                    reader.Close();
                }
            }
            else
            {
                MessageBox.Show("未找到学生名单，请导入！");
                OpenFile(sender, e);
                SaveFile(sender, e);
            }

        }



        public void ChangeName(object sender, EventArgs e)
        {
            TopMost = true;
            NameLabel.Text = StartRandom(false);
            System.Media.SystemSounds.Asterisk.Play();
        }

        public void About(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright 2023 dyt_dirt\r\n\r\n   Licensed under the Apache License, Version 2.0 (the \"License\");\r\n   you may not use this file except in compliance with the License.\r\n   You may obtain a copy of the License at\r\n\r\n       http://www.apache.org/licenses/LICENSE-2.0\r\n\r\n   Unless required by applicable law or agreed to in writing, software\r\n   distributed under the License is distributed on an \"AS IS\" BASIS,\r\n   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.\r\n   See the License for the specific language governing permissions and\r\n   limitations under the License.");
        }

        public void Exit(object sender, EventArgs e)
        {
            SaveFile(sender, e);
            Close();
        }

        public void GetHelp(object sender, EventArgs e)
        {
            // 这里是一个废案，本来想做使用方法的弹窗，结果我懒（手动狗头）

            MessageBox.Show("毫无疑问这里是个废案。\r\n\r\n Without a doubt, this is an abandoned case.");
        }

        private void GoToSetting(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void 测试功能_Click(object sender, EventArgs e)
        {
            // 笑死我甚至懒得给它取名字
            // 十连up抽取。。。的窗体。。。
            UPWindow window = new UPWindow();
            window.Show();
        }

        private void GetUPList(object sender, EventArgs e)
        {

        }
    }
}