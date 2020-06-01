using System;
using System.Text;
using System.IO;

namespace Lab4
{ 
        static void Main(string[] args)
{
            int counter = 0; // лічильник слів, де d стоїть на 2-му місці
            bool empty = true;
            bool onlyNumbers = true;

            string line; // допоміжний рядок 
            char[] separator = { ' ', '.', '*', '+', ';', ',', '?', '!', '-', '/' }; // масив
            StringBuilder otvet = new StringBuilder(); // рядок-відповідь
            using (StreamReader MyFile = new StreamReader("text.txt"))
            {
                // читання рядка з файлу, поки це можливо
                while ((line = MyFile.ReadLine()) != null)
                {
                    empty = false;
                    Console.WriteLine(line); // друкуємо, що прочитали
                                             //виділяємо слова
                    string[] words = line.Split(separator);
                    foreach (string slovo in words) //цикл за словами, цикл foreach
                    {
                        if ((slovo.Length >= 2) && (slovo[1] == 'd'))
                        {
                            counter++;
                            otvet.Append(slovo);
                            otvet.Append(" ");
                        }

                        if (onlyNumbers)
                        {
                            foreach (char c in slovo)
                            {
                                if (!Char.IsDigit(c))
                                    onlyNumbers = false;
                            }
                        }
                    }
                }
            }
            if (empty)
            {
                Console.WriteLine("Файл пустой");
                return;
            }

            if (counter == 0)
                Console.WriteLine("В файле нет слов, где на второй позиции буква d");

            if (onlyNumbers)
                Console.WriteLine("В тексте одни цифры");

            Console.WriteLine("Имеем {0} сходств с условием.", counter);
            Console.WriteLine(otvet.ToString());
        }
    }
}
