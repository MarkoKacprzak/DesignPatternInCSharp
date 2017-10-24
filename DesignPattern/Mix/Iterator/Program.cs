using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace DesignPattern.Mix.Iterator
{
    public static class Program
    {
        public static void Run()
        {
            int n = 10000000;
            long sum = 0;
            Stopwatch sw = Stopwatch.StartNew();
            /*
            int stopAt = 10000000;
            //foreach (var item in Populates(n))
            foreach (var item in Populates(n))
                //foreach (var item in new Sequence(n))
            {
                sum += item;
                if (item % stopAt == 0)
                {
                    Console.WriteLine($"{item/1000000}M\t" +
                        $"Mem={GC.GetTotalMemory(false) / 1024 / 1024}Mbyte\t" +
                        $"Time={sw.ElapsedMilliseconds}msec");
                }
            }
            */
            sum = InfiniteLoop().TakeWhile(x => x <= n).Sum(x => (long)x);
            long expectedSum = (long)n * ((long)n + 1) / 2;
            Console.WriteLine($"Sum {{1..{n:0:#,##0} = {sum:#,##0} }}" +
                $" = {sum:#,##0}; expected {expectedSum:#,##0}");

            Console.ReadLine();
        }


        private static IEnumerable<int> Populate(int max)
        {
            var list = new List<int>();
            for (int i = 1; i <= max; i++)
                list.Add(i);
            return list;
        }
        private static IEnumerable<int> Populates(int max)
        {
            for (int i = 1; i <= max; i++)
                yield return i;
        }
        private static IEnumerable<int> InfiniteLoop()
        {
            int current = 0;
            while (true)
                yield return ++current;
        }
    }
}
