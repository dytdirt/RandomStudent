using System;

namespace TestFeature
{
    class Program
    {

        private static int line = 0;
        private static string[] ListOfStudents = new string[100];
        private static string[] UPList = new string[100];
        private static int[] Map = new int[100];

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
            int nowLine;

        Flag:
            nowLine = random.Next(line);
            if (isUP && SearchIndex(UPList, ListOfStudents[nowLine]) != -1)
            {
                return ListOfStudents[nowLine];
            }
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

            goto Flag;
        }
        static void Main()
        {
            line = 50;
            for (int i = 0; i < 50; i++)
                ListOfStudents[i] = i.ToString();

            for (int i = 0; i < 1; i++) UPList[i] = i.ToString();

            StreamWriter streamWriter = new StreamWriter("./output.out");
            for (int i = 0; i < 1000; i++)
                streamWriter.WriteLine(StartRandom(true));
            streamWriter.Close();
        }
    }
}