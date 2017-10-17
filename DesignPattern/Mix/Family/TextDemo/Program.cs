using DesignPattern.Mix.Family.Common;
using System;

namespace DesignPattern.Mix.Family.TextDemo
{
    public static class Program
    {
        public static void Run()
        {

            var dad =
                new FamilyMember(
                    new Bearded(
                        new Emotional("Dad", "hoho")));
            var mom =
                new FamilyMember(
                    new Hairy(
                        new Emotional("Mom", "hihi")));
            var boy =
                new FamilyMember(
                    new Emotional("Boy", "haha"));
            var dog =
                new FamilyMember(
                    new Emotional("Dog", "tail waving"));
            var uncle =
                new FamilyMember(
                    new Bearded(
                        new Hairy("Uncle")));
            var granddad =
                new FamilyMember(
                    new Bearded(
                        new Hairy(
                            new Emotional("Granddad", "oyoyo"))));

            var family = new Family(new FamilyMember[] { dad, mom, boy, dog, uncle, granddad });

            family.WinterBegins();
            family.SummerComes();
            Console.ReadLine();

        }
    }
}
