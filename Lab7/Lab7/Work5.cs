using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Work5
    {
        public static void Begin()
        {
            const int VARIANT = 9;
            const int COUNT = 2190;
            const int MIN = 500;
            const int MAX = 800;

            ArrayList list = new ArrayList();
            Random rand = new Random();
            for (int i = 0; i < COUNT; i++)
            {
                list.Add(rand.Next(MIN, MAX));
            } //заполнение

            list.Sort(); //сортировка

            Console.WriteLine("Значения: ");
            foreach(var item in list) //вывод
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            list.Insert(VARIANT, VARIANT); //номер варианта индекс варианта

            int randomValue = rand.Next(0, VARIANT + 1000); //генерация и проверка в списке
            int idx = list.IndexOf(randomValue);
            Console.WriteLine($"Value: {randomValue} | Index: " + ((idx == -1) ? "Нет" : idx.ToString()));

            randomValue = rand.Next(0, list.Count-1);
            list.Remove(randomValue); //удалили

            list.Clear(); //очистили
        }
    }
}
