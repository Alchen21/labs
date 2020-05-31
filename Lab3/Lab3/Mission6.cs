using System;
using System.Collections.Generic;
using System.Text;

namespace LB3
{
    class Mission6
    {
        public static void Begin()
        {
            try
            {
                int[][] MyArray;
                MakeArray(out MyArray);
                PrintArray("Входящий массив:", MyArray);
                for (int i = 0; i < MyArray.Length; i++)
                    Array.Sort(MyArray[i]);
                Console.WriteLine();
                PrintArray("Изменённый массив:", MyArray);
            }
            catch (FormatException)
            {
                Console.WriteLine("Exception: Неверный формат");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Exception: Переполнение массива");
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("Exception: Недостаточно памяти для создания объекта");
            }
        }
        private static void MakeArray(out int[][] MyArray)
        {
            Console.Write("Введите количество строк: ");
            int n = int.Parse(Console.ReadLine());
            MyArray = new int[n][];
            Random rand = new Random();
            for (int i = 0; i < MyArray.Length; i++)
            {
                int j = (i + 1) * 2;
                MyArray[i] = new int[j];
                for (j = 0; j < MyArray[i].Length; j++)
                {
                    MyArray[i][j] = rand.Next(1000);
                }
            }
        }

        private static void PrintArray(string a, int[][] mas)
        {
            Console.WriteLine(a);
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < mas[i].Length; j++) Console.Write("{0} ",
               mas[i][j]);
                Console.WriteLine();
            }
        }
    }
}
