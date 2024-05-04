using System;

namespace TestFeature
{
    class Program
    {

        public static int line = 0;
        public static string[] ListOfStudents = new string[10000];
        internal static string[] UPList = new string[10000];
        public static int[] Map = new int[10000];

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
        static void Main()
        {
            line = 100;
            for (int i = 0; i < 100; i++)
                ListOfStudents[i] = i.ToString();


            for (int i = 0; i < 100; i++)
            {
                Dictionary<string, int> valuePairs = new Dictionary<string, int>();
                string filepath = "./outputs/output" + i.ToString() + ".csv";
                StreamWriter streamWriter = new StreamWriter(filepath);
                UPList = new string[10000];
                for (int j = 0; j < i; j++)
                    UPList[j] = j.ToString();

                for (int j = 0; j < 1000; j++)
                {
                    string res = StartRandom(true);
                    if (valuePairs.ContainsKey(res))
                        valuePairs[res]++;
                    else
                        valuePairs.Add(res, 1);
                }

                for (int j = 0; j < 100; j++)
                {
                    if (valuePairs.ContainsKey(j.ToString()))
                    {
                        string outs = j.ToString() + "," + valuePairs[j.ToString()];
                        streamWriter.WriteLine(outs);
                    }
                    else
                    {
                        string outs = j.ToString() + "," + "0";
                        streamWriter.WriteLine(outs);
                    }
                }
                streamWriter.Close();
            }
        }
    }
}