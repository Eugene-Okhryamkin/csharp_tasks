using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public abstract class CargoShip : IShip
    {

        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public int MaxCargoCapacity { get; set; }
        public bool EngineStatus { get; private set; }

        public abstract void LoadCargo();
        public abstract void UnloadCargo();
        public bool CheckEngineStatus()
        {
            return EngineStatus;
        }

        public void StartEngines()
        {
            EngineStatus = true;
            Console.WriteLine("Engines started.");
        }

        public void StopEngines()
        {
            EngineStatus = false;
            Console.WriteLine("Engines stopped.");
        }
    }
}
