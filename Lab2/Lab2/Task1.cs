using System;
using System.Collections.Generic;
using System.Text;
namespace LB2
{
    class Task1
    {
        public static void Begin()
        {
            int i = 6;
            double x, y;
            Console.Write("Введите x: ");
            x = Double.Parse(Console.ReadLine());
            if (Math.Abs(x) < 10)
            {
                double a, b;
                Console.Write("Введите a: ");
                a = Double.Parse(Console.ReadLine());
                Console.Write("Введите b: ");
                b = Double.Parse(Console.ReadLine());

                y = Math.Tan(x / i + a) - Math.Log(b * i + 7);
            }
            else
            {
                double c, d;
                Console.Write("Введите c: ");
                c = Double.Parse(Console.ReadLine());
                Console.Write("Введите d: ");
                d = Double.Parse(Console.ReadLine());

                y = c * Math.Pow(Math.Pow(x, 2) + (d * Math.Pow(i, 1.2)), (double)(1m / 9m));
            }
            Console.WriteLine("y = " + y.ToString());
        }
    }
}