//8-12

/*
using Lab8;

Console.OutputEncoding = System.Text.Encoding.Unicode; // відображення літери і

Smartphone dial = new("123", 50, 50, Color.White, 255, "999", 3);
dial.TakeIncomingCall("423");
dial.Call("123465");
dial.SendSMS("123", "hello");
dial.ReceiveSMS("112323", "world");
dial.SwitchNumber(2);
dial.SendMMS("99123127490", "apple");
dial.ReceiveMMS("99120", "apple");
dial.Photo(0);
dial.Photo(1);
dial.Video(3);

/*
Garage garage = new();

garage.ListCars();

Car car1 = new Car("Toyota Corola", Lab8.Color.Black, 2000, 200);
Car car2 = new Car("Toyota Corola", Lab8.Color.White, 2001, 180);
Car car3 = new Car("Toyota Corola", Lab8.Color.Yellow, 2002, 240.5f);
Car car4 = new Car("Toyota Camri", Lab8.Color.White, 2007, 211);
Car car5 = new Car("Mercedes Benz", Lab8.Color.Red, 2001, 239);
Car car6 = new Car("Kia Ria", Lab8.Color.Red, 2003, 240.5f);
Car car7 = new Car("Mercedes AM", Lab8.Color.Red, 2001, 245.12f);



garage.AddNewCar(car1);
garage.AddNewCar(car2);
garage.AddNewCar(car3);
garage.AddNewCar(car4);
garage.AddNewCar(car5);
garage.AddNewCar(car6);
garage.AddNewCar(car7);

//garage.ListCars();

var lol = garage.GetCars("", Lab8.Color.Red, 2001);
foreach(var car in lol)
    Console.WriteLine($"Car: {car.Name()}, Color: {car.Color()}, " +
                   $"Year: {car.Year()}, Speed: {car.Speed()}, ID: {car.ID()}");

return 0;


if (garage.RemoveCar(560))
{
    Console.WriteLine("Removed car");
}
else
{
    Console.WriteLine("No such car with id");
}

if (garage.RemoveCar("Toyota Corola", Lab8.Color.Black, 2000, 200))
{
    Console.WriteLine("Removed car");
}
else
    Console.WriteLine("No such car with param");

garage.ListCars();

*/