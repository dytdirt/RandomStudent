using System.Text;

namespace Base64
{
    public class Base64
    {
        // char[] Base64List = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/".ToCharArray();
        // 原始Base64表
        private static readonly char[] Base64List = "啊啵呲的额佛哥喝一几愙勒摸呢欧破气釰娰特躌鱼无洗一紫锟斤拷坤鸡炒粉qwertyuiopasdfghjklzxcvbnm],/{+".ToCharArray();
        //                                                                                       ^~~~~~~ 都说了炒粉不能加鸡精！

        public static string EncryptToBase64(string EncryptString)
        {
            string ResultString = "";
            byte[] Input = Encoding.Default.GetBytes(EncryptString);

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

        public static string DecryptToBase64(string EncryptedString)
        {
            string ResultString = "";

            for (int i = 0; i + 3 < EncryptedString.Length; i+=4)
            {
                char c1 = EncryptedString[i], c2 = EncryptedString[i + 1], c3 = EncryptedString[i + 2], c4 = EncryptedString[i + 3];
                byte b1 = 0, b2 = 0, b3 = 0;

                for (byte j = 0; j < 64; j++)
                {
                    if (c1 == Base64List[j])
                    {
                        b1 = (byte)(j << 2);
                    }
                    if (c2 == Base64List[j])
                    {
                        b1 |= (byte)(j >> 4);
                        b2 = (byte)(j << 4);
                    }
                    if (c3 == '=')
                    {
                        b2 |= (byte)(0 >> 2);
                        b3 = (byte)((((0 >> 2) << 2) ^ 0) << 6);
                    }
                    else if (c3 == Base64List[j])
                    {
                        b2 |= (byte)(j >> 2);
                        b3 = (byte)((((j >> 2) << 2) ^ j) << 6);
                    }
                    if (c4 == '=')
                    {
                        b3 |= 0;
                    }
                    else if (c4 == Base64List[j])
                    {
                        b3 |= (byte)j;
                    }
                    // special (c3 (or c4) == '=')
                }

                c1 = (char)b1;
                c2 = (char)b2;
                c3 = (char)b3;

                ResultString += c1.ToString() + c2.ToString() + c3.ToString();
            }

            return ResultString;
        }
    }
}