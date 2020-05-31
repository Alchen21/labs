using System;
using System.Collections.Generic;
using System.Text;

namespace LB3
{
    class Mission2
    {
        public static void Begin()
        {
            Console.Write("Введите размер массива: ");
            int n = Int32.Parse(Console.ReadLine());
            int[] myArray = new int[n];
            int i;
            for (i = 0; i < n; i++)
                myArray[i] = i * i;
            for (i = 0; i < n; i++)
                Console.Write(myArray[i] + " ");
            Console.Write("\n");
        }
    }
}
