using System.Runtime.InteropServices;

namespace RandomStudent
{
    public partial class Form1 : Form
    {
        int line = 0;
        string[] ListOfStudents = new string[100];
        int[] Map = new int[100];
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

        //添加窗体的MouseDown事件，并编写如下代码
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        public void OpenAndSave(object sender, EventArgs e)
        {
            line = 0;
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "(*.txt)|*.txt",
                Multiselect = false
            };
            ofd.ShowDialog();
            string FileName = ofd.FileName;
            if (FileName == "")
            {
                return;
            }
            MessageBox.Show(FileName);
            StreamReader reader = new StreamReader(FileName);
            string LineData;
            while ((LineData = reader.ReadLine()) != null)
            {
                ListOfStudents[line++] = LineData;
            }
            reader.Close();
            SaveFile(sender, e);
        }

        public void ReadFile(object sender, EventArgs e)
        {
            string FileName = @"student.dll";
            string LineData;
            if (File.Exists(@"student.dll"))
            {
                StreamReader reader = new StreamReader(FileName);
                while ((LineData = reader.ReadLine()) != null)
                {
                    ListOfStudents[line++] = LineData;
                }
                reader.Close();
            }
            else
            {
                MessageBox.Show("未找到学生名单，请导入！");
                OpenAndSave(sender, e);
            }

        }

        public void SaveFile(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(@"student.dll");
            for (int i = 0; i < line; i++)
            {
                writer.WriteLine(ListOfStudents[i]);
            }

            writer.Close();
            FileInfo info = new FileInfo(@"student.dll");
            info.Attributes = FileAttributes.Hidden | FileAttributes.ReadOnly;
        }

        public void StartRandom(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            long time = dt.ToFileTime();
            Random random = new((int)time);
            int nowLine;
        Flag:
            nowLine = random.Next(line);
            if (Map[nowLine] == 0)
            {
                NameLabel.Text = ListOfStudents[nowLine];
                Map[nowLine] += (int)(line * 0.65);
            }
            else goto Flag;

            for (int i = 0; i < line; i++)
            {
                if (Map[i] > 0)
                    Map[i]--;
            }

        }

        public void About(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright 2023 dyt_dirt\r\n\r\n   Licensed under the Apache License, Version 2.0 (the \"License\");\r\n   you may not use this file except in compliance with the License.\r\n   You may obtain a copy of the License at\r\n\r\n       http://www.apache.org/licenses/LICENSE-2.0\r\n\r\n   Unless required by applicable law or agreed to in writing, software\r\n   distributed under the License is distributed on an \"AS IS\" BASIS,\r\n   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.\r\n   See the License for the specific language governing permissions and\r\n   limitations under the License.\r\n\r\n\r\n  源代码会放在GitHub上：https://www.github.com/dytdirt/RandomStudent   感兴趣的同学可以抄代码（bushi\r\n\r\n\r\n  这个随机学生是某位同学送给老师的\"毕业设计\"，由于时间仓促，难免会有bug，如果有同学能帮助修复bug，我会很开心的（）");
        }

        public void Exit(object sender, EventArgs e)
        {
            Close();
        }
    }
}