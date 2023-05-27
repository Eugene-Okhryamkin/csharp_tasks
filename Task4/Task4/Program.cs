

using Task4;

namespace Application 
{
    public static class App
    {
        public static void Main(string[] args)
        {
            Jewelry gemstone = new Jewelry("Алмаз", 12.0, 8);
            gemstone.PrintInfo();

            Console.WriteLine();

            ColoredJewelry coloredGemstone = new ColoredJewelry("Алмаз", 12.0, 8, "голубой");
            coloredGemstone.PrintInfo();

            Console.ReadLine();
        }
    }
}