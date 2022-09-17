using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    internal class Car
    {
        private string name;
        private Color color;
        private uint year;
        private float speed;
        private UInt64 id;

        private static UInt64 carId = 0;
        public Car(string carName, Color carColor, uint carYear, float carSpeed)
        {
            name = carName;
            color = carColor;
            year = carYear;
            speed = carSpeed;

            id = carId;
            carId++;
        }

        public string Name()
        {
            return name;
        }

        public string Color()
        {
            switch (color)
            {
                case Lab8.Color.White:
                    return "White";
                case Lab8.Color.Black:
                    return "Black";
                case Lab8.Color.Yellow:
                    return "Yellow";
                case Lab8.Color.Red:
                    return "Red";
                case Lab8.Color.Blue:
                    return "Blue";
                case Lab8.Color.Green:
                    return "Green";
            }

            return "Invalid";
        }

        public Lab8.Color ColorCode()
        {
            return color;
        }

        public uint Year()
        {
            return year;
        }

        public float Speed()
        {
            return speed;
        }

        public UInt64 ID()
        {
            return id;
        }
    }
}
