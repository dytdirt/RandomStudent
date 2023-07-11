using System.Runtime.InteropServices;
using System.Text;
using System.Security.Cryptography;
using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace RandomStudent
{

    public partial class Form1 : Form
    {
        int line = 0;
        // char[] Base64List = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";
        // 原始Base64表
        char[] Base64List = "啊啵呲的额佛哥喝一金课勒摸呢欧破气日四特五鱼无洗一紫锟斤拷坤鸡炒粉qwertyuiopasdfghjklzxcvbnm],/{+".ToCharArray();
        //                                                                        ^~~~~~~ 都说了炒粉不能加鸡精！
        string[] ListOfStudents = new string[100];
        string FileOutput;
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

        public String Base64Encode(String EncodeString)
        {
            String ResultString = "\0";
            for (int i = 0; i < EncodeString.Length; i += 3)
            {
            }

            return ResultString;
        }

        // 添加窗体的MouseDown事件，并编写如下代码
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private static bool IsUTF8Bytes(byte[] data)
        {
            int charByteCounter = 1; // 计算当前正分析的字符应还有的字节数 
            byte curByte; // 当前分析的字节. 
            for (int i = 0; i < data.Length; i++)
            {
                curByte = data[i];
                if (charByteCounter == 1)
                {
                    if (curByte >= 0x80)
                    {
                        // 判断当前 
                        while (((curByte <<= 1) & 0x80) != 0)
                        {
                            charByteCounter++;
                        }
                        // 标记位首位若为非0 则至少以2个1开始 如:110XXXXX...........1111110X 
                        if (charByteCounter == 1 || charByteCounter > 6)
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    // 若是UTF-8 此时第一位必须为1 
                    if ((curByte & 0xC0) != 0x80)
                    {
                        return false;
                    }
                    charByteCounter--;
                }
            }
            if (charByteCounter > 1)
            {
                throw new Exception("非预期的byte格式");
            }
            return true;
        }

        static Encoding GetTextFileEncodingType(string fileName)
        {
            Encoding encoding = Encoding.Default;
            FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream, encoding);
            byte[] buffer = binaryReader.ReadBytes((int)fileStream.Length);
            binaryReader.Close();
            fileStream.Close();
            if (buffer.Length >= 3 && buffer[0] == 239 && buffer[1] == 187 && buffer[2] == 191)
            {
                encoding = Encoding.UTF8;
            }
            else if (buffer.Length >= 3 && buffer[0] == 254 && buffer[1] == 255 && buffer[2] == 0)
            {
                encoding = Encoding.BigEndianUnicode;
            }
            else if (buffer.Length >= 3 && buffer[0] == 255 && buffer[1] == 254 && buffer[2] == 65)
            {
                encoding = Encoding.Unicode;
            }
            else if (IsUTF8Bytes(buffer))
            {
                encoding = Encoding.UTF8;
            }
            return encoding;
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

            /*
                以下代码只有在经过NuGet安装System.Text.Encoding.CodePages后才有用
                （不然会抛出异常）
            */


            if (GetTextFileEncodingType(FileName) == Encoding.UTF8)
            {

                StreamReader reader = new StreamReader(FileName, Encoding.UTF8);
                // 如果文件编码为UTF8（Windows7以上（不含））则用正常方法打开

                string LineData;
                while ((LineData = reader.ReadLine()) != null)
                {
                    ListOfStudents[line++] = LineData;
                }
                reader.Close();
            }
            else
            {
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                StreamReader reader = new StreamReader(FileName, Encoding.GetEncoding("GB2312"));
                // 在较老版本Windows，文本文档默认编码为ANSI（多种编码混合形态，其中中文为GB2312）

                string LineData;
                while ((LineData = reader.ReadLine()) != null)
                {
                    ListOfStudents[line++] = LineData;
                }
                reader.Close();
            }
            SaveFile(sender, e);
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
                OpenAndSave(sender, e);
            }

        }

        public void SaveFile(object sender, EventArgs e)
        {
            FileOutput += line.ToString();
            FileOutput += "\n";
            for (int i = 0; i < line; i++)
            {
                FileOutput += ListOfStudents[i] + " " + Map[i].ToString() + "\n";
            }
            if (File.Exists(@"student.dll"))
            {
                FileInfo i = new FileInfo(@"student.dll");
                i.Attributes = FileAttributes.Normal;
            }

            StreamWriter writer = new StreamWriter(@"student.dll");
            writer.WriteLine(line);
            for (int i = 0; i < line; i++)
            {
                writer.WriteLine(ListOfStudents[i]);
            }
            for (int i = 0; i < line; i++)
            {
                writer.WriteLine(Map[i]);
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
                System.Media.SystemSounds.Asterisk.Play();
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
            SaveFile(sender, e);
            Close();
        }
    }
}