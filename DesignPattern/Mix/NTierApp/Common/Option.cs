using System;
using System.Collections;
using System.Collections.Generic;

namespace DesignPattern.Mix.NTierApp.Common
{
    public class Option<T> : IEnumerable<T>
    {
        private readonly T[] data;
        private Option(T[] element)
        {
            data = element;
        }

        public static Option<T> Create(T element)
            => new Option<T>(new T[] { element });

        public static Option<T> CreateEmpty()
            => new Option<T>(new T[0]);

        public IEnumerator<T> GetEnumerator()
            => ((IEnumerable<T>)data).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}
