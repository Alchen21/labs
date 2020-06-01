using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    class Task3
    {


        public static void Begin()
{
    Console.WriteLine("1) Приведение в степень");
    Console.WriteLine("2) Квадратный корень");
    Console.WriteLine("3) Расчитать проценты");

    Console.Write("Введите a: ");
    int a = Int32.Parse(Console.ReadLine());

    Console.Write("Введите номер действия: ");
    switch (Int32.Parse(Console.ReadLine()))
    {
        case 1:
            {
                Console.Write("Введите b: ");
                int b = Int32.Parse(Console.ReadLine());
                int result = (int)Math.Pow(a, b);
                Console.WriteLine("a в степени b: " + result.ToString());
                break;
            }
        case 2:
            {
                double result = Math.Sqrt(a);
                Console.WriteLine("Корень a: " + result.ToString());
            }
            break;
        case 3:
            {
                Console.Write("Введите b: ");
                int b = Int32.Parse(Console.ReadLine());
                double result = Math.Round((double)(a * b / 100m));
                Console.WriteLine("a % b: " + result.ToString());
            }
            break;
        default:
            Console.WriteLine("Неверный номер действия!");
            break;
    }
}
    }
}
