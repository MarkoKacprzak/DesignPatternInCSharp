using System;
namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var demo in Behavioral.Patterns.All())
            //foreach (var demo in Behavioral.Patterns.List)
            {
                Console.WriteLine($"\n{demo.Name}");
                demo.Run();
            }
        }
    }
}
