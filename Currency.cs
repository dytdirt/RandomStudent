using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomStudent
{

    class Currency
    {
        public static int line = 0;
        public static int UPnum = 0;
        public static int standardNum = 0;
        public static string[] ListOfStudents = new string[100];
        public static string[] UPList = new string[100];
        public static int[] Map = new int[100];
        public static void release(object sender, EventArgs e)
        {
            Map = new int[100];
            return;
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

        public static Encoding GetTextFileEncodingType(string fileName)
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
        static private int SearchIndex(string[] strings, string res)
        {
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i] == res)
                    return i;
            }
            return -1;
        }
        static public string StartRandom(bool isUP)
        {
            DateTime dt = DateTime.Now;
            long time = dt.ToFileTime();
            Random random = new((int)time);
            Random random1 = new(random.Next());
            int nowLine;

        Flag:
            nowLine = random.Next(line);
            if (isUP && SearchIndex(UPList, ListOfStudents[nowLine]) != -1)
            {
                return ListOfStudents[nowLine];
            }
            if (random1.Next() % 4 == 3)
            {
                if (Map[nowLine] == 0)
                {
                    Map[nowLine] += (int)(line * 0.65);

                    for (int i = 0; i < line; i++)
                    {
                        if (Map[i] > 0)
                            Map[i]--;
                    }

                    return ListOfStudents[nowLine];
                }
            }
            goto Flag;
        }
        public static void SaveFile(object sender, EventArgs e)
        {
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

        public static void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "导入学生名单",
                Filter = "(*.txt)|*.txt",
                Multiselect = false
            };

            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;

            line = 0;
            string FileName = ofd.FileName;

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
        }

        public static void UPImport(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "导入UP名单",
                Filter = "(*.txt)|*.txt",
                Multiselect = false
            };

            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            UPnum = 0;
            if (GetTextFileEncodingType(openFileDialog.FileName) == Encoding.UTF8)
            {

                StreamReader reader = new StreamReader(openFileDialog.FileName, Encoding.UTF8);
                // 如果文件编码为UTF8（Windows7以上（不含））则用正常方法打开

                string LineData;
                while ((LineData = reader.ReadLine()) != null)
                {
                    UPList[UPnum++] = LineData;
                }
                reader.Close();
            }
            else
            {
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                StreamReader reader = new StreamReader(openFileDialog.FileName, Encoding.GetEncoding("GB2312"));
                // 在较老版本Windows，文本文档默认编码为ANSI（多种编码混合形态，其中中文为GB2312）

                string LineData;
                while ((LineData = reader.ReadLine()) != null)
                {
                    UPList[UPnum++] = LineData;
                }
                reader.Close();
            }
            /*
                        StreamWriter streamWriter = new StreamWriter("./student.dll"); // 有风险
                        foreach (string data in UPList)
                            streamWriter.WriteLine(data);
                        streamWriter.Close();
                        */
        }
    }
}
