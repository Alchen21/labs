using System;
using System.Collections.Generic;
using System.Text;

namespace LB3
{
    class Mission8
    {
        public static void Begin()
        {
            int n, m;
            int[,] myArray = Input(out n, out m);
            Console.WriteLine("Входящий массив:");
            Print(myArray, n, m);
            Console.WriteLine("Введите номер столбца для удаления:");
            int k = int.Parse(Console.ReadLine());
            DeleteArray(myArray, n, ref m, k);
            Console.WriteLine("Изменённый массив:");
            Print(myArray, n, m);
        }

        private static int[,] Input(out int n, out int m)
        {
            Console.WriteLine("Введите размер массива");
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            m = int.Parse(Console.ReadLine());
            Random rand = new Random();
            int[,] a = new int[n, m];
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                {
                    a[i, j] = rand.Next(1000);
                }
            return a;
        }
        private static void Print(int[,] a, int n, int m)
        {
            for (int i = 0; i < n; ++i, Console.WriteLine())
                for (int j = 0; j < m; ++j)
                    Console.Write("{0,5} ", a[i, j]);
        }
        private static void DeleteArray(int[,] a, int n, ref int m, int k)
        {
            for (int i = 0; i < n; ++i)
                for (int j = k; j < m - 1; ++j)
                    a[i, j] = a[i, j + 1];
            --m;
        }
    }
}
