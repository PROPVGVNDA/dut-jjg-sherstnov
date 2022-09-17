using Lab8;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Lab8
{
    internal class Garage
    {
        private List<Car> cars = new();

        public void AddNewCar(Car car)
        {
            cars.Add(car);
        }

        public bool RemoveCar(uint id)
        {
            foreach (Car car in cars)
                if (car.ID() == id)
                {
                    cars.Remove(car);
                    return true;
                }
            return false;
        }

        public bool RemoveCar(string name, Lab8.Color color, uint year, uint speed)
        {
            foreach(Car car in cars)
            {
                if (car.Name() != name) continue;
                if (car.Year() != year) continue;
                if (car.ColorCode() != color) continue;
                if (car.Speed() != speed) continue;

                cars.Remove(car);
                return true;
            }
            return false;
        }

        public List<Car> GetCars(string name)
        {
            List<Car> result = new();
            foreach(Car car in cars)
                if (car.Name() == name) result.Add(car);

            return result;
        }

        public List<Car> GetCars(Color color)
        {
            List<Car> result = new();
            foreach (Car car in cars)
                if (car.ColorCode() == color) result.Add(car);

            return result;
        }
        public List<Car> GetCars(uint year)
        {
            List<Car> result = new();
            foreach (Car car in cars)
                if (car.Year() == year) result.Add(car);

            return result;
        }

        public List<Car> GetCars(float speed)
        {
            List<Car> result = new();
            foreach (Car car in cars)
                if (car.Speed() == speed) result.Add(car);

            return result;
        }

        public List<Car> GetCars(UInt64 id)
        {
            List<Car> result = new();
            foreach (Car car in cars)
                if (car.ID() == id) result.Add(car);

            return result;
        }

        public List<Car> GetCars(string name = "", Lab8.Color color = Lab8.Color.Any, uint year = 0, float speed = 0.0f)
        {
            List<Car> result = new();

            foreach(Car car in cars)
            {
                if (!string.IsNullOrEmpty(name) & car.Name() != name) continue;
                if (year != 0 & car.Year() != year) continue;
                if (color != Lab8.Color.Any & car.ColorCode() != color) continue;
                if (speed != 0 && car.Speed() != speed) continue;

                result.Add(car);
            }

            return result;
        }
        public int CarsCount()
        {
            return cars.Count;
        }

        public void ListCars()
        {
            if (cars.Count == 0)
            {
                Console.WriteLine("Your garage is empty!");
                return;
            }

            foreach (Car car in cars)
                Console.WriteLine($"Car: {car.Name()}, Color: {car.Color()}, " +
                    $"Year: {car.Year()}, Speed: {car.Speed()}, ID: {car.ID()}");
        }
    }
}
