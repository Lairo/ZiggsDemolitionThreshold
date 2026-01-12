
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

            Console.WriteLine($"Outer turret has {turrets[0]:00} health\n" +
                $"Execute at {turrets[0]*levels[0]:00}/{turrets[0]*levels[1]:00}/" +
                $"{turrets[0]*levels[2]:00}/{turrets[0]*levels[3]:00}/{turrets[0]*levels[4]:00}\n");

            Console.WriteLine($"Inner turret has {turrets[1]} health\n" +
               $"Execute at {turrets[1]*levels[0]:00}/{turrets[1]*levels[1]:00}/" +
               $"{turrets[1]*levels[2]:00}/{turrets[1]*levels[3]:00}/{turrets[1]*levels[4]:00}\n");
            Console.WriteLine($"Inhib turret has {turrets[2]} health\n" +
               $"Execute at {turrets[2]*levels[0]:00}/{turrets[2]*levels[1]:00}/" +
               $"{turrets[2]*levels[2]:00}/{turrets[2]*levels[3]:00}/{turrets[2]*levels[4]:00}\n");
            Console.WriteLine($"Nexus turret has {turrets[3]} health\n" +
               $"Execute at {turrets[3]*levels[0]:00}/{turrets[3]*levels[1]:00}/" +
               $"{turrets[3]*levels[2]:00}/{turrets[3]*levels[3]:00}/{turrets[3]*levels[4]:00}\n");

            Console.ReadLine();
        }
    }
}
