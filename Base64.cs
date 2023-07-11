using System.Text;

namespace Base64
{
    public class Base64
    {
        // char[] Base64List = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/".ToCharArray();
        // 原始Base64表
        private static readonly char[] Base64List = "啊啵呲的额佛哥喝一几愙勒摸呢欧破气釰娰特躌鱼橆洗一紫锟斤拷坤鸡炒粉qwertyuiopasdfghjklzxcvbnm],/{+".ToCharArray();

        public static string EncryptToBase64(string EncryptString)
        {
            string ResultString = "";
            byte[] Input = Encoding.Default.GetBytes(EncryptString);

            for (int i = 0; i < Input.Length; i++)
            {
                Console.WriteLine(Input[i]);
            }
            for (int i = 0; i + 2 < Input.Length; i += 3)
            {
                byte c1 = Input[i], c2 = (byte)Input[i + 1], c3 = (byte)Input[i + 2];
                byte temp1 = (byte)(c1 << 6), temp2 = (byte)(c2 << 4), temp3 = (byte)(c3 >> 6);
                c1 >>= 2;
                c2 >>= 4;
                c2 |= (byte)(temp1 >> 2);
                byte c4 = (byte)(c3 << 2);
                c3 = (byte)((temp2 >> 2) | temp3);
                c4 >>= 2;
                ResultString += Base64List[c1].ToString() + Base64List[c2].ToString() + Base64List[c3].ToString() + Base64List[c4].ToString();

            }

            if (Input.Length % 3 == 2)
            {
                int i = Input.Length - 2;
                byte c1 = Input[i], c2 = Input[i + 1], c3 = (byte)'\0', c4 = (byte)'\0';
                byte temp1 = (byte)(c1 << 6), temp2 = (byte)(c2 << 4), temp3 = (byte)(c3 >> 6);
                c1 >>= 2;
                c2 >>= 4;
                c2 |= (byte)(temp1 >> 2);
                c4 = (byte)(c3 << 2);
                c3 = (byte)((temp2 >> 2) | temp3);
                c4 >>= 2;
                ResultString += Base64List[c1].ToString() + Base64List[c2].ToString() + Base64List[c3].ToString();
                ResultString += "=";
            }
            else if (Input.Length % 3 == 1)
            {
                int i = Input.Length - 1;
                byte c1 = Input[i], c2 = (byte)'\0', c3 = (byte)'\0', c4 = (byte)'\0';
                byte temp1 = (byte)(c1 << 6), temp2 = (byte)(c2 << 4), temp3 = (byte)(c3 >> 6);
                c1 >>= 2;
                c2 >>= 4;
                c2 |= (byte)(temp1 >> 2);
                c4 = (byte)(c3 << 2);
                c3 = (byte)((temp2 >> 2) | temp3);
                c4 >>= 2;
                ResultString += Base64List[c1].ToString() + Base64List[c2].ToString();
                ResultString += "==";
            }

            return ResultString;
        }
    }
}