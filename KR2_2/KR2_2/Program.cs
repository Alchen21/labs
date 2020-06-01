using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR2_2
{
    class Program
    {
        delegate IOrderedEnumerable<Product> SortString(Func<Product, string> func);
        delegate IOrderedEnumerable<Product> SortDouble(Func<Product, double> func);
        static void Main()
        {
            List<Product> products = new List<Product>();
            Console.Write("Введите количество продуктов: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                Random rand = new Random();
                for (int i = 0; i < n; i++)
                {
                    products.Add(new Product(rand.Next(0, 1000), rand.Next(0, 20), rand.Next(0, 13)));
                }

                Func<Product, string> funcName = (x => x.Name);
                Func<Product, double> funcCost = (x => x.Cost);
                Func<Product, double> funcNumber = (x => x.Number);
                Func<Product, double> funcTimeMonth = (x => x.TimeMonth);
                SortString sortString = products.OrderByDescending;
                SortDouble sortDouble = products.OrderByDescending;

                for(int k = 0; k < 4; k++)
                {
                    List<Product> tempProducts = new List<Product>();
                    if (k == 0)
                        tempProducts.AddRange(sortString(funcName).ToArray());
                    else if (k == 1)
                        tempProducts.AddRange(sortDouble(funcCost).ToArray());
                    else if (k == 2)
                        tempProducts.AddRange(sortDouble(funcNumber).ToArray());
                    else if (k == 3)
                        tempProducts.AddRange(sortDouble(funcTimeMonth).ToArray());
                    else return;

                    products = tempProducts;
                    products.Reverse();

                    Console.WriteLine("Сортировкa №" + k);
                    int i = 0;
                    foreach (var product in products)
                    {
                        i++;
                        Console.WriteLine(String.Format("№{0} {1}", i, product));
                    }
                    Console.WriteLine();
                }
            }
            else Console.WriteLine("Ошибка ввода количества продуктов");
            Console.ReadKey();
        }
    }
}
