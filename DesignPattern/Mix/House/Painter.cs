using System;

namespace DesignPattern.Mix.Houses
{
    public class Painter: PainterComponent
    {
        private string name;
        private int daysPerHouse;

        public Painter(string name, int daysPerHouse)
        {
            this.name = name;
            this.daysPerHouse = daysPerHouse;
        }

        public override double Paint(double houses)
        {

            double days = this.EstimateDays(houses);

            Console.WriteLine("{0} painting {1:0.00} houses for {2:0.00} days.",
                              this.name, houses, days);

            return days;

        }

        public override double EstimateDays(double housesCount)
        {
            return housesCount * this.daysPerHouse;
        }
    }
}
