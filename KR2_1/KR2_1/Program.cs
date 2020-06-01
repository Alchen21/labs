using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR2_1
{
    class Program
    {
        static void Main()
        {
            List<IFigure> figures = new List<IFigure>();
            Console.Write("Введите количество фигур: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                Random rand = new Random();
                for(int i = 0; i < n; i++)
                {
                    switch(rand.Next(0, 2))
                    {
                        case 0:
                            figures.Add(new Circle(rand.Next(-10, 100)));
                            break;
                        case 1:
                            figures.Add(new Rectangle(rand.Next(-10, 100), rand.Next(-10, 100)));
                            break;
                    }
                }


                using (FileStream fs = File.Create("Figures.txt"))
                {
                    int i = 0;
                    foreach (var figure in figures)
                    {
                        i++;
                        string figureInfo = String.Format("№{0} {1} Периметр: {2} Площадь: {3}", i, figure, figure.GetPerimeter(), figure.GetSquare());
                        Console.WriteLine(figureInfo);
                        byte[] info = new UTF8Encoding(true).GetBytes(figureInfo + '\n');
                        fs.Write(info, 0, info.Length);
                    }
                    fs.Close();
                }
            }
            else Console.WriteLine("Ошибка ввода количества фигур");

            Console.ReadKey();
        }
    }
}
