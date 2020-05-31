using System;

namespace LB3
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
                        Mission1.Begin();
                        break;
                    case 2:
                        Mission2.Begin();
                        break;
                    case 4:
                        Mission4.Begin();
                        break;
                    case 6:
                        Mission6.Begin();
                        break;
                    case 7:
                        Mission7.Begin();
                        break;
                    case 8:
                        Mission8.Begin();
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