using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Text.RegularExpressions;
using static Base64.Base64;
using static RandomStudent.Settings;

namespace RandomStudent
{

    class Currency
    {
        public static int line = 0;
        public static int UPnum = 0;
        public static int standardNum = 10;
        public static string?[] ListOfStudents = new string[100];
        public static string?[] UPList = new string[100];
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
        /// <summary>
        /// Convert a string to a Unicode string.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string StringToUnicode(string? source)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(source);
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i += 2)
            {
                stringBuilder.AppendFormat("\\u{0}{1}", bytes[i + 1].ToString("x").PadLeft(2, '0'), bytes[i].ToString("x").PadLeft(2, '0'));
            }
            return stringBuilder.ToString();
        }
        /// <summary>
        /// Convert the Unicode string back to the normal string.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string UnicodeToString(string source)
        {
            return new Regex(@"\\u([0-9A-F]{4})", RegexOptions.IgnoreCase | RegexOptions.Compiled).Replace(
                         source, x => string.Empty + Convert.ToChar(Convert.ToUInt16(x.Result("$1"), 16)));
        }

        static public int SearchIndex<T>(T[] strings, T res)
        {
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Equals(res))
                    return i;
            }
            return 0;
        }
        static public string? StartRandom(bool isUP)
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

            StreamWriter tmpWriter = new StreamWriter(@"tmp.dat");
            tmpWriter.WriteLine(StringToUnicode(line.ToString()));
            for (int i = 0; i < line; i++)
            {
                tmpWriter.WriteLine(StringToUnicode(ListOfStudents[i]));
            }
            for (int i = 0; i < line; i++)
            {
                tmpWriter.WriteLine(StringToUnicode(Map[i].ToString()));
            }
            for (int i = 0; i < UPnum; i++)
            {
                tmpWriter.WriteLine(StringToUnicode(UPList[i]));
            }
            tmpWriter.Close();

            StreamReader reader = new StreamReader(@"tmp.dat");
            string tmp = reader.ReadToEnd();
            reader.Close();

            StreamWriter writer = new StreamWriter(@"student.dll");
            writer.Write(EncryptToBase64(tmp));
            writer.Close();

            FileInfo info = new FileInfo(@"student.dll");
            info.Attributes = FileAttributes.Hidden | FileAttributes.ReadOnly;
        }
        [SupportedOSPlatform("windows")]
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
            StreamReader reader;
            if (GetTextFileEncodingType(FileName) == Encoding.UTF8)
            {
                reader = new StreamReader(FileName, Encoding.UTF8);
            }
            else
            {
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                reader = new StreamReader(FileName, Encoding.GetEncoding("GB2312"));
            }

            string fileData = reader.ReadToEnd();
            string[] datas = fileData.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string data in datas)
            {
                ListOfStudents[line++] = data;
            }
            reader.Close();
        }
        [SupportedOSPlatform("windows")]
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
            StreamReader reader;
            UPnum = 0;
            if (GetTextFileEncodingType(openFileDialog.FileName) == Encoding.UTF8)
            {
                reader = new StreamReader(openFileDialog.FileName, Encoding.UTF8);
            }
            else
            {
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                reader = new StreamReader(openFileDialog.FileName, Encoding.GetEncoding("GB2312"));
            }

            string fileData = reader.ReadToEnd();
            string[] datas = fileData.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string data in datas)
            {
                UPList[UPnum++] = data;
            }
            reader.Close();
        }
    }
}
