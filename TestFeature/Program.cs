using System;
using Markdig;
using System.Text;
using System.Text.RegularExpressions;

namespace TestFeature
{
    class Program
    {

        /// <summary>
        /// Convert a string to a Unicode string.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string StringToUnicode(string source)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(source);
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i += 2)
            {
                stringBuilder.AppendFormat("\\\\u{0}{1}", bytes[i + 1].ToString("x").PadLeft(2, '0'), bytes[i].ToString("x").PadLeft(2, '0'));
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
            return new Regex(@"\\\\u([0-9A-F]{4})", RegexOptions.IgnoreCase | RegexOptions.Compiled).Replace(
                         source, x => string.Empty + Convert.ToChar(Convert.ToUInt16(x.Result("$1"), 16)));
        }

        static void Main()
        {
            string test = "# 测试\r\n\r\n## 测试\r\n\r\n## $\\LaTeX$ 测试\r\n\r\n";


            Console.WriteLine(Markdown.ToHtml(test));
        }
    }
}