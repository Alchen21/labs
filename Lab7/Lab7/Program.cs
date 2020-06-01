using System;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args = null)
        {
            Console.Write("Введите номер задания: ");
            try
            {
                int n = Int32.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Work1.Begin();
                        break;
                    case 2:
                        Work2.Begin();
                        break;
                    case 3:
                        Work3.Begin();
                        break;
                    case 4:
                        Work4.Begin();
                        break;
                    case 5:
                        Work5.Begin();
                        break;
                    default:
                        throw new Exception("Неверный номер задания!");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }

            Console.Write("Продолжить работу с программой? [Y/N]");
            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
            }
            while (key != ConsoleKey.Y && key != ConsoleKey.N);
            if (key == ConsoleKey.Y)
            {
                Console.Clear();
                Main();
            }
        }
    }
}
