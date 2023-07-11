using System.Text.RegularExpressions;
using System.Text;
using System.Security.Cryptography;
using System;

namespace Base64
{
    public class Base64
    {
        // char[] Base64List = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/".ToCharArray();
        // 原始Base64表
        char[] Base64List = "啊啵呲的额佛哥喝一几愙勒摸呢欧破气釰娰特躌鱼无洗一紫锟斤拷坤鸡炒粉qwertyuiopasdfghjklzxcvbnm],/{+".ToCharArray();
        //                                                                      ^~~~~~~ 都说了炒粉不能加鸡精！
        public bool IsChinese(char c)
        {
            return Regex.IsMatch(c.ToString(), @"[\u4e00-\u9fa5]");
        }

        public byte[] init(string Input) // 将字符串中所有字符转化为byte[] (包括中英文
        {
            List<byte> Output;
            for (int i = 0; i < Input.Length; i++)
            {
                if (IsChinese(Input[i]))
                {
                    Int32 i3 = Input[i];
                    byte temp1 = (byte)(i3 << 8);
                }
            }
        }
    }
}