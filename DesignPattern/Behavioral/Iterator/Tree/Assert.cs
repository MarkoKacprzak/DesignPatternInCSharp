using System;

namespace DesignPattern.Behavioral.Iterator.Tree
{
    static class Assert
    {
        internal static void IsNull(string value)
        {
            Console.WriteLine($"Assert {value} is null");
        }
        internal static void AreEqual<T>(T expected, T actual)
        {
            Console.WriteLine($"Assert {expected} == {actual}");
        }
    }
}