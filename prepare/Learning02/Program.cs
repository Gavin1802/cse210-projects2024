using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;


namespace MySpace{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello Learning02 World!");

            var cars = new List<Car>();

            var owner = new Owner();
                owner.name = "James";
                owner.phone = "555-5555";
            
            var car = new Car("Honda", "Civic", 10, 30, owner);
            
            cars.Add(car);

            owner = new Owner();
            owner.name = "Susan";
            owner.phone = "999-9959";

            car = new Car("Ford", "F-150", 30, 5, owner);
            
            cars.Add(car);

            foreach (var c in cars) 
            {
                c.Display();
                int range = c.TotalRange();
            }
        }
    }
}