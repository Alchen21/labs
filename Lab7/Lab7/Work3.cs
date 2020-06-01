using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Work3
    {
        public static void Begin()
        {
            string str = "";
            using (FileStream fs = File.OpenRead(@"Work3.txt"))
            {
                byte[] buffer = new byte[fs.Length];
                UTF8Encoding temp = new UTF8Encoding(true);
                fs.Read(buffer, 0, buffer.Length);
                str = temp.GetString(buffer);
                fs.Close();
            }
            ArrayList list = new ArrayList();
            try
            {
                while (str.Length > 3)
                {
                    Person tempPerson = new Person();
                    tempPerson.Surname = str.Substring(0, str.IndexOf(' '));
                    str = str.Substring(str.IndexOf(' ') + 1);
                    tempPerson.Name = str.Substring(0, str.IndexOf(' '));
                    str = str.Substring(str.IndexOf(' ') + 1);
                    tempPerson.Patronymic = str.Substring(0, str.IndexOf(' '));
                    str = str.Substring(str.IndexOf(' ') + 1);
                    tempPerson.Age = int.Parse(str.Substring(0, str.IndexOf(' ')));
                    str = str.Substring(str.IndexOf(' ') + 1);
                    if (str.IndexOf('\n') != -1)
                        tempPerson.Weight = double.Parse(str.Substring(0, str.IndexOf('\n') - 1));
                    else
                        tempPerson.Weight = double.Parse(str.Substring(0, str.Length));

                    list.Add(tempPerson);

                    if (str.IndexOf('\n') == -1 || str.IndexOf('\n') >= str.Length - 1) break;
                    str = str.Substring(str.IndexOf('\n') + 1);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Читаемый файл имеет ошибки!\n" + e.Message);
            }
            finally
            {
                int i = 0;
                Person[] listArr = new Person[list.Count];
                foreach(var item in list)
                {
                    listArr[i] = (Person)item;
                    i++;
                }
                Array.Sort(listArr);
                list.Clear();
                list.AddRange(listArr);
                i = 0;
                foreach (var item in list)
                {
                    i++;
                    Console.WriteLine($"№{i} | {item}");
                }
            }
        }

        struct Person : IComparable<Person>, IComparer<Person>
        {
            public string Surname;
            public string Name;
            public string Patronymic;
            public int Age;
            public double Weight;
            public override string ToString()
            {
                return $"Фамилия: {Surname} | Имя: {Name} | Отчество: {Patronymic} | Возраст: {Age} лет | Вес: {Weight} кг.";
            }

            public int Compare(Person x, Person y)
            {
                return x.Age.CompareTo(y.Age);
            }

            public int CompareTo(Person other)
            {
                return this.Age.CompareTo(other.Age);
            }
        }
    }
}
