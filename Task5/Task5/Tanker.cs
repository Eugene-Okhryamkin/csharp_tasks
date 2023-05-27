using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Tanker : CargoShip
    {
        public string CargoType { get; set; }
        public int CargoCompartments { get; set; }

        public override void LoadCargo()
        {
            Console.WriteLine("Loading cargo onto the tanker.");
        }

        public override void UnloadCargo()
        {
            Console.WriteLine("Unloading cargo from the tanker.");
        }

        public void Refuel()
        {
            Console.WriteLine("Refueling the tanker.");
        }

        public void ActivateSailingMode()
        {
            Console.WriteLine("Activating sailing mode for the tanker.");
        }
    }
}
