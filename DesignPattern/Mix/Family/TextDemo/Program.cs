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
                    new Bearded("Dad",
                        new Emotional("Dad", "hoho")));
            var mom =
                new FamilyMember(
                    new Hairy("Mom",
                        new Emotional("Mom", "hihi")));
            var boy =
                new FamilyMember(
                    new Emotional("Boy", "haha"));
            var dog =
                new FamilyMember(
                    new Emotional("Dog", "tail waving"));
            var uncle =
                new FamilyMember(
                    new Bearded("Uncle",
                        new Hairy("Uncle")));
            var granddad =
                new FamilyMember(
                    new Bearded("Granddad",
                        new Hairy("Granddad",
                            new Emotional("Granddad", "oyoyo"))));

            var family = new Family(new FamilyMember[] { dad, mom, boy, dog, uncle, granddad });

            family.WinterBegins();
            family.SummerComes();
            Console.ReadLine();

        }
    }
}
