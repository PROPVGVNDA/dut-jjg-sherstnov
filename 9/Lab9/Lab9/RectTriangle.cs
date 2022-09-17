using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class RectTriangle : Triangle
    {
        public override Color Color { get { return color; } set { color = value; } }

        public override double SideA
        {
            get { return sideA; }
            set 
            {
                sideA = value;
                sideC = Hypotenuse(sideA, sideB);
            }
        }
        public override double SideB
        {
            get { return sideB; }
            set
            {
                sideB = value;
                sideC = Hypotenuse(sideA, sideB);
            }
        }
        public override double SideC
        {
            get { return sideC; }
            set
            {
                sideC = value;
                sideA = Math.Sqrt(Math.Pow(sideC, 2) - Math.Pow(sideB, 2));
            }
        }

        public override string ObjectName { get { return objName; } }

        public RectTriangle(string name)
        {
            this.objName = name;
            Random random = new();
            this.sideA = random.NextDouble() * 100;
            this.sideB = this.sideA * random.NextDouble() + 10.0;
            this.sideC = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
            this.color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }
        public RectTriangle(string name, double side)
        {
            Random random = new();
            this.objName = name;
            this.SideA = side;
            this.sideB = this.sideA * random.NextDouble() + 1;
            this.sideC = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
            this.color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }

        public RectTriangle(string name, double side, Color color)
        {
            Random random = new();
            this.objName = name;
            this.SideA = side;
            this.sideB = this.sideA * random.NextDouble() + 1;
            this.sideC = Hypotenuse(sideA, sideB);
            this.color = color;
        }
        public override double Area()
        {
            return 1.0 / 2.0 * sideA * sideB;
        }

        public override double Perimeter()
        {
            return sideA + sideB + sideC;
        }

        private double Hypotenuse(double a, double b)
        {
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }

        public override void Draw()
        {
            Console.WriteLine($"{this.objName} - a = {this.sideA}, b = {this.sideB}, c = {this.sideC}; " +
                $"Color = {color.GetHashCode()}");
        }
    }
}