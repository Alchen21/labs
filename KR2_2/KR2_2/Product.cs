using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR2_2
{
    class Product
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public double Number { get; set; }
        public double TimeMonth { get; set; }

        public Product()
        {
            Name = "Продукт";
            Cost = 0;
            Number = 0;
            TimeMonth = 0;
        }
        public Product(string name, double cost, double number, double timeMonth)
        {
            Name = name;
            Cost = cost;
            Number = number;
            TimeMonth = timeMonth;
        }

        public Product(double cost, double number, double timeMonth)
        {
            Name = "Продукт";
            Cost = cost;
            Number = number;
            TimeMonth = timeMonth;
        }

        public override string ToString()
        {
            return String.Format("Название: {0} Цена: {1} На складе: {2} Срок придатности: {3}", Name, Cost, Number, TimeMonth);
        }
    }
}
