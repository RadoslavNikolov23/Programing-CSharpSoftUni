﻿namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            Car car = new Car()
            {
                Make = "VW",
                Model = "MK3",
                Year = 1992,
                FuelConsumption=200,
                FuelQuantity=900
            };
            car.Drive(200);
            Console.WriteLine(car.WhoAmI());

          //  Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
        }

    }
}