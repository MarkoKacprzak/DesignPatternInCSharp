using DesignPattern.Mix.Family.Common;
using System;

namespace DesignPattern.Mix.Family.TextDemo
{
    class Bearded : ChainElement, IBearded
    {       
        public Bearded(ChainElement next) : base(next)
        {
        }
        public Bearded(string owner, ChainElement next) : base(owner, next)
        {
        }
        public Bearded(string owner) : this(owner,NullValue)
        {
        }
        public void GrowBeard()
        {
            Console.WriteLine("{0}: beard grows", this.Owner);
        }

        public void Shave()
        {
            Console.Write("{0}: shaved", this.Owner);
        }

    }
}
