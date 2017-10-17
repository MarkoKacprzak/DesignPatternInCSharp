using DesignPattern.Mix.Family.Common;
using System;

namespace DesignPattern.Mix.Family.TextDemo
{
    public class Emotional : ChainElement, IEmotional
    {

        private readonly string owner;
        private readonly string laughingSound;

        public Emotional(string owner, string laughingSound, ChainElement next)
            : base(next)
        {
            this.owner = owner;
            this.laughingSound = laughingSound;
        }
        public Emotional(string owner, string laughingSound): this(owner,laughingSound, NullValue)
        {
        }

        public void BeHappy()
        {
            Console.WriteLine("{0}: {1}", this.owner, this.laughingSound);
        }

        public void BeContent()
        {
        }
    }
}
