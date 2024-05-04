using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomStudent
{
    public partial class UPWindow : Form
    {
        public static int UPnum = 0;
        public static int standardNum = 0;
        public UPWindow()
        {
            InitializeComponent();
        }

        public static void UPImport(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "导入UP名单";
            openFileDialog.Filter = "(*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            UPnum = 0;
            if (Currency.GetTextFileEncodingType(openFileDialog.FileName) == Encoding.UTF8)
            {

                StreamReader reader = new StreamReader(openFileDialog.FileName, Encoding.UTF8);
                // 如果文件编码为UTF8（Windows7以上（不含））则用正常方法打开

                string LineData;
                while ((LineData = reader.ReadLine()) != null)
                {
                    Form1.UPList[UPnum++] = LineData;
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
                    Form1.UPList[UPnum++] = LineData;
                }
                reader.Close();
            }

            StreamWriter streamWriter = new StreamWriter("./student.dll");
            foreach (string data in Form1.UPList)
                streamWriter.WriteLine(data);
            streamWriter.Close();
        }

        public void GetUP(object sender, EventArgs e)
        {
            //
        }
    }
}
