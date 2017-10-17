using DesignPattern.Mix.Family.Common;
using System;

namespace DesignPattern.Mix.Family.TextDemo
{
    public class Hairy : ChainElement, IHairy
    {

        public Hairy(string owner, ChainElement next) : base(owner, next) 
        {
        }
        public Hairy(ChainElement next) : base(next)
        {
        }
        public Hairy(string owner) : this(owner, NullValue)
        {
        }
        public void GrowHair()
        {
            Console.WriteLine("{0}: hair gets long", this.Owner);
        }

        public void CutHair()
        {
            Console.WriteLine("{0}: visited the hair dresser", this.Owner);
        }
    }
}
