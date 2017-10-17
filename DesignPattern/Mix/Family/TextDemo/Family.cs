using DesignPattern.Mix.Family.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Mix.Family.TextDemo
{
    public class Family
    {

        private readonly IEnumerable<FamilyMember> members;

        public Family(IEnumerable<FamilyMember> members)
        {
            this.members = members;
        }

        public void WinterBegins()
        {
            Console.WriteLine("Winter just came...");
            foreach (FamilyMember member in members)
            {
                member.As<IHairy>(NullHairy.Instance).GrowHair();
                member.As<IBearded>(NullBearded.Instance).GrowBeard();
            }
            Console.WriteLine(new string('-', 20));
        }

        public void SummerComes()
        {
            Console.WriteLine("Summer is here...");
            members.ToList().ForEach(member => member.As(NullEmotional.Instance).BeHappy());
           //foreach (FamilyMember member in members)
            //{
             //   member.As(NullEmotional.Instance).BeHappy();
            //}
            Console.WriteLine(new string('-', 20));
        }
    }
}
