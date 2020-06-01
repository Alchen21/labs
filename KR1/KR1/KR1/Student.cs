using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace KR1
{
    class Student
    {
        readonly string surname;
        readonly string group;
        readonly double rating;
        private bool budget;

        public Student(string surname, string group, double rating, bool budget = false)
        {
            this.surname = surname;
            this.group = group;
            this.rating = rating;
            this.budget = budget;
        }

        public string Surname
        {
            get { return surname; }
        }

        public string Group
        {
            get { return group; }
        }

        public double Rating
        {
            get { return rating; }
        }

        public bool Budget
        {
            get { return budget; }
            set { budget = value; }
        }

        public override string ToString()
        {

            return (String.Format("Фамилия: {0} | Группа: {1} | Средний бал: {2} | Форма обучения: {3}",
                Surname, Group, Rating, (Budget ? "Бюджет" : "Контракт")));
        }

        public static List<Student> FindByGroup(List<Student> list, string group)
        {
            List<Student> result = new List<Student>();
            foreach (Student item in list)
            {
                if (item.Group == group)
                    result.Add(item);
            }
            return result;
        }

        public static List<Student> SortByRating(List<Student> list)
        {
            list = list.OrderBy(x => -x.Rating).ToList();
            return list;
        }

        public static void PrintInfo(List<Student> list)
        {
            if(list.Count == 0)
            {
                Console.WriteLine("Список студентов пуст!");
                return;
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("Студент №" + (i + 1));
                Console.WriteLine(list[i]);
                Console.WriteLine("===================================================");
            }
        }

        public static void AddStudent(ref List<Student> list)
        {
            try
            {
                Console.WriteLine("Студент номер " + (list.Count + 1));
                Console.Write("Фамилия: ");
                string tempSurname = Console.ReadLine();
                Console.Write("Группа: ");
                string tempGroup = Console.ReadLine();
                Console.Write("Средний бал: ");
                double tempRating = double.Parse(Console.ReadLine());
                if (tempRating < 0 || tempRating > 5)
                    throw new Exception("Средний бал должен быть от 0 до 5");
                Console.Write("Бюджет/Контракт (true/false): ");
                bool tempBudget = bool.Parse(Console.ReadLine());
                list.Add(new Student(tempSurname, tempGroup, tempRating, tempBudget));
                Console.WriteLine("Студент " + tempSurname + " добавлен!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка при добавлении студента: " + e.Message);
            }
        }

        public static void RemoveStudent(ref List<Student> list)
        {
            try
            {
                Console.Write("Номер: ");
                int id = int.Parse(Console.ReadLine());
                if (list.Count < id || id <= 0) throw new Exception("Такого студента нет!");
                string tempSurname = list[id - 1].Surname;
                list.RemoveAt(id - 1);
                Console.WriteLine("Студент " + tempSurname + " удалён!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка при удалении студента: " + e.Message);
            }
        }
    }
}