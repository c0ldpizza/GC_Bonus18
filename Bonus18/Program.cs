﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many cars would you like to enter data for?");
            int numCars = int.Parse(Console.ReadLine());

            List<object> CarList = new List<object>(numCars);

            for (int i = 0; i < numCars; i++)
            {
                Console.WriteLine("Would you like to enter data for Car {0}? (y = yes/n = default)", i + 1);
                string defaultCar = Console.ReadLine().ToLower();

                if (defaultCar == "y")
                {
                    //Car Car = new Car("Chevy", "Astro", 2003, 2000.00);
                    Car Car = new Car();

                    Console.Write("Enter the Make:");
                    Car.Make = Console.ReadLine();
                    Console.Write("Enter the Model:");
                    Car.Model = Console.ReadLine();
                    Console.Write("Enter the Year:");
                    Car.Year = int.Parse(Console.ReadLine());
                    Console.Write("Enter the Price:");
                    Car.Price = double.Parse(Console.ReadLine());

                    CarList.Add(Car);
                }
                else if (defaultCar == "n")
                {
                    Car Car = new Car();
                    CarList.Add(Car);
                }
                else
                {
                    Console.WriteLine("Invalid Input. Goodbye");
                    break;
                }
                
            }

            foreach (object item in CarList)
            {
                
                Console.WriteLine(item);
            }
        }
    }
}
