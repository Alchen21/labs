using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR2_1
{
    class Circle : IFigure
    {
        readonly string name;
        private double r;
        public string Name { get { return name; } }

        public double R
        {
            get { return r; }
            set
            {
                if (value >= 0) r = value;
                else r = 0;
            }
        }
        public Circle()
        {
            this.name = "Круг";
            this.R = 0;
        }
        public Circle(double r, string name) {
            this.name = name;
            this.R = r;
        }
        public Circle(double r)
        {
            this.name = "Круг";
            this.R = r;
        }
        public double GetPerimeter() {
            return (2 * Math.PI * R);
        }
        public double GetSquare() {
            return (Math.PI * R * R);
        }
        public override string ToString() {
            return String.Format("Имя круга: {0} Радиус круга: {1}", Name, R);
        }
    }
}
