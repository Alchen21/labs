using System;

namespace LB2
{
    class Program
    {
        static void Main(string[] args = null)
        {
            Console.Write("Номер задания: ");
            try
            {
                int n = Int32.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Task1.Begin();
                        break;
                    case 2:
                        Task2.Begin();
                        break;
                    case 3:
                        Task3.Begin();
                        break;
                    default:
                        Console.WriteLine("Данного задания - не существует,выберите существующее");
                        break;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }
        }
    }
}