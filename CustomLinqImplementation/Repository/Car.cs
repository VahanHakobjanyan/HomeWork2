using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinqImplementation.Repository
{
    public class Car
    {
        public int CarId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car(int carId, string make, string model, int year, string color)
        {
            CarId = carId;
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        public override string ToString()
        {
            return $"Car(Id={CarId}, Make={Make}, Model={Model}, Year={Year}, Color={Color})";
        }
    }
}
