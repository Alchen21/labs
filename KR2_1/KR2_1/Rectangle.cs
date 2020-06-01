using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR2_1
{
    class Rectangle : IFigure
    {
        readonly string name;
        private double length, width;
        public string Name { get { return name; } }

        public double Length
        {
            get { return length; }
            set
            {
                if (value >= 0) length = value;
                else length = 0;
            }
        }
        public double Width
        {
            get { return width; }
            set
            {
                if (value >= 0) width = value;
                else width = 0;
            }
        }

        public Rectangle() {
            this.name = "Прямоугольник";
            this.Length = 0;
            this.Width = 0;
        }
        public Rectangle(double length, double width, string name) {
            this.name = name;
            this.Length = length;
            this.Width = width;
        }
        public Rectangle(double length, double width) {
            this.name = "Прямоугольник";
            this.Length = length;
            this.Width = width;
        }
        public double GetPerimeter() {
            return ((Length + Width) * 2);
        }
        public double GetSquare() {
            return (Length * Width);
        }
        public override string ToString() {
            return String.Format("Имя прямоугольника: {0} Длинна: {1} Ширина: {2}", Name, Length, Width);
        }
    }
}
