using System;
using System.Collections;
using System.Collections.Generic;

namespace DesignPattern.Mix.Iterator
{
    class SequenceIterator : IEnumerator<int>
    {
        private readonly int max;
        private int current;
        public SequenceIterator(int max)
        {
            this.max = max;
        }
        public int Current
        {
            get
            {
                if (current <= 0)
                    throw new InvalidOperationException();
                return current;
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (current >= this.max)
                return false;
            current++;
            return true;
        }

        public void Reset()
        {
            this.current = 0;
        }
    }
}
