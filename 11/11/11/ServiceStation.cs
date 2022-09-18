using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    delegate void Contract(Car car);
    internal class ServiceStation
    {
        public void CamberAngle(Car car)
        {
            if (car.CamberAngle) return;
            Console.WriteLine("Done Camber Angle.");
            car.CamberAngle = true;
        }
        public void Paint(Car car)
        {
            if (car.Painted) return;
            Console.WriteLine("Done Painting.");
            car.Painted = true;
        }

        public void ChangeMachineOil(Car car)
        {
            if (car.MachineOilChanged) return;
            Console.WriteLine("Changed Machine Oil.");
            car.MachineOilChanged = true;
        }

        public void InspectCar(Car car)
        {
            if (car.CarInspection) return;
            Console.WriteLine("Done Inspecting Car");
            car.CarInspection = true;
        }

        public void ChangeTires(Car car)
        {
            if (car.TiresChanged) return;
            Console.WriteLine("Done Changing Tires.");
            car.TiresChanged = true;
        }

        public void RepairBody(Car car)
        {
            if (car.RepairedBody) return;
            Console.WriteLine("Done Repairing Body.");
            car.RepairedBody = true;
        }

        public void ListCarProperties(Car car)
        {
            Console.WriteLine($"Camber Angle - {car.CamberAngle}");
            Console.WriteLine($"Painted - {car.Painted}");
            Console.WriteLine($"Changed Machine Oil - {car.MachineOilChanged}");
            Console.WriteLine($"Car Inspection - {car.CarInspection}");
            Console.WriteLine($"Changed Tires - {car.TiresChanged}");
            Console.WriteLine($"Repaired Body - {car.RepairedBody}");
        }

        public void Full(Car car)
        {
            CamberAngle(car);
            Paint(car);
            ChangeMachineOil(car);
            InspectCar(car);
            ChangeTires(car);
            RepairBody(car);
        }

        public Contract CreateContract()
        {
            Contract contract = None;
            ListOperations();
            Console.WriteLine("Enter string containing of 1s and 0s specifying which operation to perform.");
            Console.WriteLine("Any non 1 value, will be considered 0");
            Console.WriteLine("For example: 100111");
            Console.WriteLine("Will perform: Camber Angle, Car Inspection, Tires Changing, Body Repair");
            string operations = Console.ReadLine();
            if (operations is null) return null;
            if (operations.Length != 6)
            {
                Console.WriteLine("Invalid string of operations!");
                return null;
            }

            for (int i = 0; i < 6; i++)
            {
                char op = operations[i];
                if (op != '1') continue;
                if (i == 0) contract += CamberAngle;
                else if (i == 1) contract += Paint;
                else if (i == 2) contract += ChangeMachineOil;
                else if (i == 3) contract += InspectCar;
                else if (i == 4) contract += ChangeTires;
                else contract += RepairBody;
            }

            return contract;
        }

        public void ListOperations()
        {
            Console.WriteLine("Operations: ");
            Console.WriteLine("1. Do Camber Angle");
            Console.WriteLine("2. Paint");
            Console.WriteLine("3. Change Machine Oil");
            Console.WriteLine("4. Inspect Car");
            Console.WriteLine("5. Change Tires");
            Console.WriteLine("6. Repair Body");
        }

        private void None(Car car)
        {

        }
    }
}
