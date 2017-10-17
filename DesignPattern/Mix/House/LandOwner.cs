using System;

namespace DesignPattern.Mix.Houses
{
    public class LandOwner
    {
        private int totalHouses;
        private PainterComponent painter;

        public LandOwner(int totalHouses, PainterComponent painter)
        {
            this.totalHouses = totalHouses;
            this.painter = painter;
        }

        public void MaintainHouses()
        {

            double days = this.painter.Paint(this.totalHouses);

            Console.WriteLine("\nPainted {0:0} houses in {1:0.00} days.",
                              this.totalHouses, days);

        }
    }
}
