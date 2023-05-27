using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT
{
    class Car
    {
        public string Brand { get; set; }
        public Wheel CarWheel { get; set; }
        public Engine CarEngine { get; set; }

        public Car(string brand, Wheel wheel, Engine engine)
        {
            Brand = brand;
            CarWheel = wheel;
            CarEngine = engine;
        }

        public void Drive()
        {
            Console.WriteLine("Автомобиль едет.");
        }

        public void Refuel()
        {
            Console.WriteLine("Автомобиль заправляется.");
        }

        public void ChangeWheel(int newSize)
        {
            CarWheel.ChangeWheel(newSize);
        }

        public void PrintBrand()
        {
            Console.WriteLine($"Марка автомобиля: {Brand}");
        }
    }

}
