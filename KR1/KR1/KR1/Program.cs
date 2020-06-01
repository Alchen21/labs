using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KR1
{
    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            while (true)
            {
                Console.WriteLine("0) Выход.");
                Console.WriteLine("1) Добавить студента.");
                Console.WriteLine("2) Удалить студента.");
                Console.WriteLine("3) Список студентов.");
                Console.WriteLine("4) Список студентов из группы.");
                Console.WriteLine("5) Список студентов отсортированых по среднему балу.");
                Console.Write("Выберите действие: ");
                if (int.TryParse(Console.ReadLine(), out int n))
                {
                    switch(n)
                    {
                        case 0:
                            Environment.Exit(0);
                            break;
                        case 1:
                            Student.AddStudent(ref students);
                            break;
                        case 2:
                            Student.RemoveStudent(ref students);
                            break;
                        case 3:
                            Student.PrintInfo(students);
                            break;
                        case 4:
                            Console.Write("Введите группу: ");
                            string group = Console.ReadLine();
                            Student.PrintInfo(Student.FindByGroup(students, group));
                            break;
                        case 5:
                            Student.PrintInfo(Student.SortByRating(students));
                            break;
                        default:
                            Console.WriteLine("Неверный номер действия!");
                            break;
                    }
                }
                else Console.WriteLine("Неверный номер действия!");

                Console.WriteLine("Для продолжения нажмите любую клавишу...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
