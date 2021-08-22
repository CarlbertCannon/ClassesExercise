using System;
using System.Collections.Generic;

namespace ClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car(); //dot notation
            myCar.Make = "Honda";
            myCar.Model = "Element";
            myCar.Year = 2005;

            var Toyota = new Car() //c# object initialization
            {
                Make = "Toyota",
                Model = "4Runner",
                Year = 2010
            };

            var tesla = new Car("Tesla", "Model S", 2021);

            var carList = new List<Car>() { myCar, Toyota, tesla };

            foreach(var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}"); 
            }





        }
    }
}
