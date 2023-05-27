using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT
{
    class Wheel
    {
        public int Size { get; set; }

        public void ChangeWheel(int newSize)
        {
            Size = newSize;
        }
    }
}
