using System;
using System.Collections.Generic;
using System.Text;

namespace LB3
{
    class Mission4
    {
        public static void Begin()
        {
            int[] myArray = { 0, -1, -2, 3, 4, 5, -6, -7, 8, -9 };
            Print(myArray);
            Change(myArray);
            Print(myArray);
            Array.Sort(myArray);
            Print(myArray);
        }

        private static void Print(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write("{0} ", a[i]);
            Console.WriteLine();
        }
        private static void Change(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                if (a[i] > 0) a[i] = 0;
        }
    }
}
