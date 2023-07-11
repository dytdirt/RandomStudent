using System.Text.RegularExpressions;
using System.Text;
using System.Security.Cryptography;
using System;
using System.IO;
using System.Collections.Generic;

namespace Base64
{
    public class Base64
    {
        // char[] Base64List = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/".ToCharArray();
        // 原始Base64表
        char[] Base64List = "啊啵呲的额佛哥喝一几愙勒摸呢欧破气釰娰特躌鱼橆洗一紫锟斤拷坤鸡炒粉qwertyuiopasdfghjklzxcvbnm],/{+".ToCharArray();
        //                                                                      ^~~~~~~ 都说了炒粉不能加鸡精！
        public static bool IsChinese(char c)
        {
            return Regex.IsMatch(c.ToString(), @"[\u4e00-\u9fa5]");
        }

        public static byte[] Init(string Input) // 将字符串中所有字符转化为byte[] (包括中英文
        {
            List<byte> list = new();
            List<byte> Output = list;
            for (int i = 0; i < Input.Length; i++)
            {
                if (IsChinese(Input[i])) // 中文所占为两个字节
                {
                    Int32 i3 = Input[i];
                    byte temp1 = (byte)(i3 >> 8);
                    byte temp2 = (byte)(i3 << 8);
                    temp2 >>= 8;

                    Output.Add(temp1);
                    Output.Add(temp2);
                }
                else
                {
                    byte temp;
                    temp = (byte)Input[i];
                    Output.Add(temp);
                }
            }

            return Output.ToArray();
        }

        public string EncryptToBase64(string EncryptString)
        {
            string ResultString = "\0";
            byte[] Input = Init(EncryptString);
            for(int i = 0; i + 2 < Input.Length;i+=3){
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

            return ResultString;
        }
    }
}