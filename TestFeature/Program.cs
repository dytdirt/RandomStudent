using System;
using Markdig;
using System.Windows.Forms;
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
            string test = "# 测试\r\n\r\n## 测试\r\n\r\n## $\\LaTeX$ 测试\r\n\r\n$$\\small\\texttt{\\color{#FA4129}本}\\huge\\texttt{\\color{#FE9019}人}_{\\small\\texttt{\\color{#FFE304}的}^{\\large\\texttt{\\color{#FFEC01}萌\\color{#FFF900}新}\\small\\texttt{\\color{#FCFB03}Q\\color{#F8FB07}A\\color{#F1FB0B}Q}}}^{\\large\\texttt{\\color{#FFB511}是}{\\small\\texttt{\\color{#FFDC07}刚\\color{#FFEF00}学}\\large\\texttt{\\color{#FFF600}O\\color{#FFFA00}I}}}\\huge\\texttt{\\color{#E6F911}但\\color{#92E82F}是}^{\\large\\texttt{\\color{#39D54B}即}{\\small\\texttt{\\color{#03C767}使}}}_{\\normalsize\\text{\\color{#07C964}是\\color{#00C789}这\\color{#00C7A5}样}}\\texttt{\\color{#00CBC6}我\\color{#00D0EB}也}^{\\small\\texttt{\\color{#00D0F2}要}\\normalsize\\texttt{\\color{#00D0F6}用}\\texttt{\\color{#03BEF4}蒟}_{\\texttt{\\color{#04AAEF}蒻}\\large\\texttt{\\color{#078DE4}的 }}}_{\\scriptsize\\texttt{\\color{#01CDF6}声\\color{#03C2F5}音\\color{#04B4F2}大\\color{#04A7EE}声\\color{#0791E6}喊\\color{#0A7BDD}出}}\\mathcal{\\color{#125BCD}I \\ \\color{#3D2AB5}AK \\ \\color{#A011AD}IOI}$$";
            Markdown.ToHtml(test);
        }
    }
}