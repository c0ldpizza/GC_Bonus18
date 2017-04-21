using System;
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

            List<object> CarList = new List<object>();

            for (int i = 0; i < numCars; i++)
            {
                Console.WriteLine("Would you like to enter data for Car {0}? (y = yes/n = default)", i + 1);
                string defaultCar = Console.ReadLine().ToLower();

                if (defaultCar == "y")
                {
                    Car Car_i = new Car();
                    CarList[i] = Car_i;
                }
                else if (defaultCar == "n")
                {
                    Car Car_i = new Car();
                    CarList[i] = Car_i;
                }
                else
                {

                }

            }
        }
    }
}
