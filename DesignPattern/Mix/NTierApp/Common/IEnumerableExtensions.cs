using System;
using System.Collections.Generic;

namespace DesignPattern.Mix.NTierApp.Common
{
    public static class IEnumerableExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> source,
            Action<T> action)
        {
            foreach (T obj in source)
                action(obj);
        }
    }
}
