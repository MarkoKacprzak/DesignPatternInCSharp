using DesignPattern.Mix.Family.Common;
using System;

namespace DesignPattern.Mix.Family.TextDemo
{
    public class Emotional : ChainElement, IEmotional
    {
        private readonly string laughingSound;

        public Emotional(string laughingSound, ChainElement next): base(next)
        {
            this.laughingSound = laughingSound;
        }
        public Emotional(string owner, string laughingSound, ChainElement next): base(owner,next)
        {
            this.laughingSound = laughingSound;
        }
        public Emotional(string owner, string laughingSound): this(owner,laughingSound, NullValue)
        {
        }

        public void BeHappy()
        {
            Console.WriteLine("{0}: {1}", this.Owner, this.laughingSound);
        }

        public void BeContent()
        {
        }
    }
}
