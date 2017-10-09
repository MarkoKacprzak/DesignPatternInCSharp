using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern
{
    public static class Get<T> where T : class
    {
        public static IEnumerable<T> All(string patternNamespace) =>
              AppDomain.CurrentDomain.GetAssemblies().ToList()
              .SelectMany(a => a.GetTypes())
              .Where(t => typeof(T).IsAssignableFrom(t))
              .Where(t => t.IsClass)
              .Where(t => t.Namespace.Contains(patternNamespace))
              .OrderBy(t => t.Namespace)
              .Select(t => (T)System.Activator.CreateInstance(t));
    }
    public static class Get
    {
        public static IEnumerable<IDemo> All(string patternNamespace) =>
            Get<IDemo>.All(patternNamespace);
        public static IEnumerable<ISample> AllSample(string patternNamespace) =>
          Get<ISample>.All(patternNamespace);

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
            Console.WriteLine($"\n------------- {countPattern++} {patternNamespace} patterns:");
            All(patternNamespace).ToList().ForEach(demo =>
            {
                Console.WriteLine($"\n---{demo.Name}:---");
                demo.Run();
            });
        }
        public static void Sample(string patternNamespace)
        {
            Console.WriteLine($"\n------------- {patternNamespace} sample:");
            AllSample(patternNamespace).ToList().ForEach(sample =>
            {
                Console.WriteLine($"\n---{sample.GetType()}:---");
                sample.Run();
            });
        }
    }
}
