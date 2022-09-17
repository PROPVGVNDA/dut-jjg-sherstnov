using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class IsTriangle : Triangle
    {
        public override Color Color { get { return color; } set { color = value; } }

        public override double SideA { get { return sideA; } set { sideA = sideB = value; } }
        public override double SideB { get { return sideB; } set { sideB = sideA = value; } }
        public override double SideC 
        { 
            get { return sideC; } 
            set
            {
                if (value < sideA + sideB) sideC = value;
            }
        }

        public override string ObjectName { get { return objName; } }

        public IsTriangle(string name)
        {
            this.objName = name;
            Random random = new();
            this.sideA = this.sideB = random.NextDouble() * 100;
            this.sideC = this.sideA * this.sideB;
            while (sideC >= sideA + sideB)
                this.sideC = random.NextDouble() * 100;

            this.color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }
        public IsTriangle(string name, double side)
        {
            Random random = new();
            this.objName = name;
            this.SideA = this.SideB = side;
            this.sideC = random.Next(Convert.ToInt32(sideA / 2), Convert.ToInt32(this.sideA + this.sideB - 1));
            this.color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }

        public IsTriangle(string name, double side, Color color)
        {
            Random random = new();
            this.objName = name;
            this.SideA = this.SideB = side;
            this.sideC = random.Next(Convert.ToInt32(sideA / 2), Convert.ToInt32(this.sideA + this.sideB - 1));
            this.color = color;
        }
        public override double Area()
        {
            return (sideC / 4) * Math.Sqrt(4 * Math.Pow(sideA, 2) - Math.Pow(sideC, 2));
        }

        public override double Perimeter()
        {
            return sideA * 2 + sideC;
        }

        public override void Draw()
        {
            Console.WriteLine($"{this.objName} - a = {this.sideA}, b = {this.sideB}, c = {this.sideC}; " +
                $"Color = {color.GetHashCode()}");
        }
    }
}