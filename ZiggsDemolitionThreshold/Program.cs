
namespace ZiggsDemolitionThreshold
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Title = "Ziggs Demolition Threshold";
            double[] levels = [0.25, 0.275, 0.3, 0.325, 0.35];
            int[] turrets = [9000,5000,4750,3500];

            Console.WriteLine("Ziggs Demolition Threshold\n");

            int x = 0;
            string turretPosition = "";            
            while (x < 4)
            {
                if (x == 0)
                {
                    turretPosition = "Outer";
                }
                if (x == 1)
                {
                    turretPosition = "Inner";
                }
                if (x == 2)
                {
                    turretPosition = "Inhib";
                }
                if (x == 3)
                {
                    turretPosition = "Nexus";
                }
                Console.Write($"{turretPosition} turret has {turrets[x]:00} health\nExecute at ");

                for (int i = 0; i < 5; i++) {

                    Console.Write($"{turrets[x] * levels[i]:00}");
                    if (i < 4)
                    {
                        Console.Write("/");
                    }
                }
                Console.WriteLine("\n");

                if (x == 4)
                {
                    return;
                }
                    x++;
            }
            Console.ReadLine();
        }
    }
}
