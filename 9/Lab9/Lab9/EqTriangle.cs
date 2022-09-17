using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class EqTriangle : Triangle
    {
        public override Color Color { get { return color; } set { color = value; } }

        public override double SideA { get { return sideA; } set { sideA = sideB = sideC = value; } }
        public override double SideB { get { return sideB; } set { sideB = sideA = sideC = value; } }
        public override double SideC { get { return sideC; } set { sideC = sideA = sideB = value; } }

        public override string ObjectName { get { return objName; } }

        public EqTriangle(string name)
        {
            this.objName = name;
            Random random = new();
            this.sideA = this.sideB = this.sideC = random.NextDouble() * 100;
            this.color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }
        public EqTriangle(string name, double side)
        {
            Random random = new();
            this.objName = name;
            this.SideA = this.SideB = this.SideC = side;
            this.color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }

        public EqTriangle(string name, double side, Color color)
        {
            this.objName = name;
            this.SideA = this.SideB = this.SideC = side;
            this.color = color;
        }
        public override double Area()
        {
            return Math.Sqrt(3) / 4 * Math.Pow(sideA, 2);
        }

        public override double Perimeter()
        {
            return sideA * 3;
        }
        public override void Draw()
        {
            Console.WriteLine($"{this.objName} - a = {this.sideA}, b = {this.sideB}, c = {this.sideC}; " +
                $"Color = {color.GetHashCode()}");
        }
    }
}