using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    interface IShip
    {
        string Name { get; set; }
        int MaxSpeed { get; set; }
        void StartEngines();
        void StopEngines();
    }
}
