using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


        public static void main()
        {
            List<IMeasurable> list = new List<IMeasurable>();
            list.Add(new Square(10));
            list.Add(new Square(30));
            list.Add(new Square(50));
            list.Add(new Square(20));
            list.Add(new Square(40));
            list.Add(new Square(40));

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("Фигура №{0}\t|\tПермиетр: {1}\t|\tПлощадь:{2}", i + 1, list[i].Perimeter(), list[i].Area());
            }
            Console.WriteLine();
            for (int i = 1; i < list.Count; i++)
            {
                Console.WriteLine("№{0} compare to №{1}: {2}", i, i + 1, list[i - 1].CompareTo(list[i]));
            }
        }
    }

    public interface IMeasurable : IComparable
    {
        double Perimeter();
        double Area();
    }

    class Square : IMeasurable, IComparable
    {
        public double A { get; set; }

        public Square(double a = 0)
        {
            this.A = a;
        }
        public double Perimeter()
        {
            return (A * 4);
        }
        public double Area()
        {
            return (A * A);
        }

        public int CompareTo(object obj)
        {
            Square right = (Square)obj;
            if (this.Perimeter() == right.Perimeter()) return 0;
            else if (this.Perimeter() > right.Perimeter()) return 1;
            else return -1;
        }

    }


