using System;
using System.Collections.Generic;
using System.Text;

namespace LB3
{
    class Mission7
    {
        public static void Begin()
        {
            try
            {
                int[] myArray = Input();
                int n = myArray.Length;
                Console.WriteLine("Входящий массив:");
                Print(myArray, n);
                Console.Write("Введите индекс элемента для удаления:");
                int m = int.Parse(Console.ReadLine());
                DeleteArray(myArray, ref n, m);
                Console.WriteLine("Изменённый массив:");
                Print(myArray, n);
            }
            catch (FormatException)
            {
                Console.WriteLine("Exception: Неверный формат");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Exception: Переполнение массива");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Exception: Выход за пределы памяти");
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("Exception: Недостаточно памяти для создания объекта");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        private static int[] Input()
        {
            Console.Write("Введите размер массива: ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0) throw new Exception("Размер массива не может быть меньше или равно 0");
            int[] a = new int[n];
            for (int i = 0; i < n; ++i)
            {
                Console.Write("a[{0}]= ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }
        private static void Print(int[] a, int n)
        {
            for (int i = 0; i < n; ++i) Console.Write("{0} ", a[i]);
            Console.WriteLine();
        }
        private static void DeleteArray(int[] a, ref int n, int m)
        {
            if (m >= n || m < 0) throw new Exception("Элемент для удаления массива выходит за пределы");
            for (int i = m; i < n - 1; ++i)
                a[i] = a[i + 1];
            --n;
        }
    }
}
