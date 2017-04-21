using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{
    public class Car
    {
        //variables
        private string CarMake;
        private string CarModel;
        private int CarYear;
        private double CarPrice;

        public string Make
        {
            get
            {
                return CarMake;
            }

            set
            {
                CarMake = value;
            }
        }

        public string Model
        {
            get
            {
                return CarModel;
            }

            set
            {
                CarModel = value;
            }
        }

        public int Year
        {
            get
            {
                return CarYear;
            }

            set
            {
                CarYear = value;
            }
        }

        public double Price
        {
            get
            {
                return CarPrice;
            }

            set
            {
                CarPrice = value;
            }
        }

        //properties


        //constructors
        public Car()
        {
            CarMake = "Honda";
            CarModel = "Civic";
            CarYear = 2000;
            CarPrice = 5000.00;
        }

        public Car(string MakeInput, string ModelInput, int YearInput, double PriceInput)
        {
            CarMake = MakeInput;
            CarModel = ModelInput;
            CarYear = YearInput;
            CarPrice = PriceInput;
        }
    }
}
