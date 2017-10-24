using System.Collections;
using System.Collections.Generic;

namespace DesignPattern.Mix.Iterator
{
    class Sequence : IEnumerable<int>
    {
        private readonly int max;
        public Sequence(int max)
        {
            this.max = max;
        }
        public IEnumerator<int> GetEnumerator()
        {
            return new SequenceIterator(this.max);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
