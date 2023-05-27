using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class ColoredJewelry : Jewelry
    {
        public string Color { get; set; }

        public ColoredJewelry(string name, double weight, int cuttingQuality, string color)
            : base(name, weight, cuttingQuality)
        {
            Color = color;
        }

        public new double CalculateQuality()
        {
            double quality = base.CalculateQuality();

            if (Color == "голубой")
            {
                return quality + 1;
            }
            else if (Color == "желтый")
            {
                return quality - 0.5;
            }
            else
            {
                return quality;
            }
        }
    }
}
