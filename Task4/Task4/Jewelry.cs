using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Jewelry
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int CuttingQuality { get; set; }

        public Jewelry(string name, double weight, int cuttingQuality)
        {
            Name = name;
            Weight = weight;
            CuttingQuality = cuttingQuality;
        }

        public double CalculateQuality()
        {
            return 0.4 * Weight + 0.6 * CuttingQuality;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Название: {Name}");
            Console.WriteLine($"Вес: {Weight} карат");
            Console.WriteLine($"Качество огранки: {CuttingQuality} баллов");
            Console.WriteLine($"Качество: {CalculateQuality()}");
        }
    }
}
