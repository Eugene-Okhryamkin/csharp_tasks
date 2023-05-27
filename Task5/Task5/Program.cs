// See https://aka.ms/new-console-template for more information

using Task5;

namespace Task5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<IShip> ships = new List<IShip>();

            
            Tanker tanker1 = new Tanker();
            tanker1.Name = "Tanker 1";
            tanker1.MaxSpeed = 50;
            tanker1.MaxCargoCapacity = 1000;
            tanker1.CargoType = "Oil";
            tanker1.CargoCompartments = 3;
            ships.Add(tanker1);

            Tanker tanker2 = new Tanker();
            tanker2.Name = "Tanker 2";
            tanker2.MaxSpeed = 60;
            tanker2.MaxCargoCapacity = 1500;
            tanker2.CargoType = "Gas";
            tanker2.CargoCompartments = 4;
            ships.Add(tanker2);

            foreach (IShip ship in ships)
            {
                Console.WriteLine("Ship Name: " + ship.Name);
                Console.WriteLine("Max Speed: " + ship.MaxSpeed);
                ship.StartEngines();
                ship.StopEngines();

                if (ship is Tanker tanker)
                {
                    tanker.LoadCargo();
                    tanker.UnloadCargo();
                    tanker.Refuel();
                    tanker.ActivateSailingMode();
                }

                Console.WriteLine();
            }
        }

    } 
}