using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Work4
    {
        public static void Begin()
        {
            string str = "";
            using (FileStream fs = File.OpenRead(@"Work4_Input.txt"))
            {
                byte[] buffer = new byte[fs.Length];
                UTF8Encoding temp = new UTF8Encoding(true);
                fs.Read(buffer, 0, buffer.Length);
                str = temp.GetString(buffer);
                fs.Close();
            }

            Stack<int> stack = new Stack<int>();
            Console.WriteLine("Числа: ");
            while (str.Length > 1)
            {
                int temp = int.Parse(str.Substring(0, str.IndexOf(' ')));
                stack.Push(temp);
                Console.Write(temp + " ");
                if (str.IndexOf(' ') == -1) break;
                str = str.Substring(str.IndexOf(' ') + 1);
            }
            Console.WriteLine();

            Console.WriteLine("Числа в обратном порядке: ");
            using (FileStream fs = File.Create(@"Work4_Output.txt"))
            {
                while (stack.Count > 0)
                {
                    Console.Write(stack.Peek() + " ");
                    byte[] info = new UTF8Encoding(true).GetBytes(stack.Pop().ToString() + " ");
                    fs.Write(info, 0, info.Length);
                }
                fs.Close();
            }
            Console.WriteLine();
        }
    }
}
