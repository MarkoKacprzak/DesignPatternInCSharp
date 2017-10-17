using System;
namespace DesignPattern.Mix.Houses
{
    public static class Program
    {
        public static void Run()
        {

            var localPaintersCo =
                new PaintingComposite(
                    new PainterComponent[]
                    {
                        new Painter("Andy", 7),
                        new Painter("Bill", 5)
                    },
                    new WholeHouseScheduler());

            var bestPaintersCo =
                new PaintingComposite(
                    new PainterComponent[]
                    {
                        new Painter("Joe", 4),
                        new Painter("Jill", 5),
                        new Painter("Buster", 3),
                        localPaintersCo
                    },
                    new ProportionalScheduler());

            var owner = new LandOwner(14, bestPaintersCo);

            owner.MaintainHouses();

            Console.WriteLine("Press ENTER to exit...");
            Console.ReadLine();

        }
    }
}
