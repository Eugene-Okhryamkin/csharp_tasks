


using IT;

namespace Application 
{
    public static class App
    {
        public static void Main(string[] args) 
        {
            Wheel carWheel = new Wheel { Size = 18 };
            Engine carEngine = new Engine { Horsepower = 200 };

            Car myCar = new Car("Toyota", carWheel, carEngine);
            myCar.PrintBrand();
            myCar.Drive();
            myCar.Refuel();
            myCar.ChangeWheel(20);

            Console.ReadLine();
        }
    }
}