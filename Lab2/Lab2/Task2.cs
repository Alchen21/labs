using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    class Task2
    {

        public static void Begin()
        {
            Dictionary<int, string> group = new Dictionary<int, string>();
            group.Add(1, "Харьковская ");
            group.Add(2, "Петропаловская ");
            group.Add(3, "Роменская");
            group.Add(4, "Барановская");

            Console.Write("Введите номер троллейбуса: ");
            int n = Int32.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("Троллейбус: " + group[1]);
                    break;
                case 2:
                    Console.WriteLine("Троллейбус: " + group[2]);
                    break;
                case 3:
                    Console.WriteLine("Троллейбус: " + group[3]);
                    break;
                case 4:
                    Console.WriteLine("Троллейбус: " + group[4]);
                    break;
            }

            if (n == 1)
                Console.WriteLine("Троллейбус: " + group[1]);
            else if (n == 2)
                Console.WriteLine("Троллейбус: " + group[2]);
            else if (n == 3)
                Console.WriteLine("Троллейбус: " + group[3]);
            else if (n == 4)
                Console.WriteLine("Троллейбус: " + group[4]);
            else
                Console.WriteLine("Данного троллейбуса - не существует");
        }
    }
}