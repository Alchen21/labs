using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Work1
    {
        public static void Begin()
        {
            string str = "";
            using(FileStream fs = File.OpenRead(@"Work1.txt"))
            {
                byte[] buffer = new byte[fs.Length];
                UTF8Encoding temp = new UTF8Encoding(true);
                fs.Read(buffer, 0, buffer.Length);
                str += temp.GetString(buffer);
                fs.Close();
            }

            Console.WriteLine("Выражение:");
            Console.WriteLine(str);
            bool fail = false;
            if(str.IndexOf('(') != -1 || str.IndexOf(')') != -1)
            {
                List<int> listOpen = new List<int>();
                List<int> listClose = new List<int>();
                int openIndex = str.IndexOf('(');
                while (openIndex != -1)
                {
                    listOpen.Add(openIndex);
                    openIndex = str.IndexOf('(', openIndex+1);
                }
                int closeIndex = str.IndexOf(')');
                while (closeIndex != -1)
                {
                    listClose.Add(closeIndex);
                    closeIndex = str.IndexOf(')', closeIndex+1);
                }

                if (listOpen.Count != listClose.Count)
                    fail = true;
            }
            Console.WriteLine("Баланс круглых скобок: " + (fail ? "нарушен" : "не нарушен"));
        }
    }
}
