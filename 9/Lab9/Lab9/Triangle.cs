using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal abstract class Triangle : IDraw
    {
        protected Color color;
        protected double sideA;
        protected double sideB;
        protected double sideC;

        protected string objName;
        public abstract Color Color
        {
            get;
            set;
        }

        public abstract double SideA
        {
            get;
            set;
        }
        public abstract double SideB
        {
            get;
            set;
        }

        public abstract double SideC
        {
            get;
            set;
        }

        public abstract string ObjectName
        {
            get;
        }

        public abstract double Area();
        public abstract double Perimeter();

        public abstract void Draw();
    }
}
