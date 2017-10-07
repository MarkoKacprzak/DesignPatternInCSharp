using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern
{
    public static class Get
    {
        public static IEnumerable<IDemo> All(string patternNamespace) =>
            AppDomain.CurrentDomain.GetAssemblies().ToList()
            .SelectMany(a => a.GetTypes())
            .Where(t => typeof(IDemo).IsAssignableFrom(t))
            .Where(t => t.IsClass)
            .Where(t => t.Namespace.Contains(patternNamespace))
            .OrderBy(t => t.Namespace)
            .Select(t => (IDemo)System.Activator.CreateInstance(t));

        public static void Run(this IEnumerable<IDemo> list)
        {
            list.ToList().ForEach(demo =>
            {
                Console.WriteLine($"\n{demo.Name}");
                demo.Run();
            });
        }

        static private int countPattern=1;
        public static void Run(string patternNamespace)
        {
            Console.WriteLine($"\n{countPattern++} {patternNamespace} patterns:");
            All(patternNamespace).ToList().ForEach(demo =>
            {
                Console.WriteLine($"\n{demo.Name}");
                demo.Run();
            });
        }
    }
}
