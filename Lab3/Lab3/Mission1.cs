using System;
using System.Collections.Generic;
using System.Text;

namespace LB3
{
    class Mission1
    {
        public static void Begin()
        {
            int[] myArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int i;
            for (i = 0; i < 10; ++i)
                Console.Write(myArray[i] + " ");
            Console.Write("\n");
        }
    }
}
