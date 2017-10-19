using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Mix.CarShop
{
    class Car
    {

        private readonly string make;
        private readonly string model;
        private readonly Engine engine;
        private readonly Seat[] seats;
        public Car(string make, string model, Engine engine, IEnumerable<Seat> seats)
        {
            this.make = make;
            this.model = model;
            this.engine = engine;
            this.seats = new List<Seat>(seats).ToArray();
        }

        public void Accept(ICarVisitor visitor)
        {
            visitor.Visit(make, model);
            this.engine.Accept(visitor);
            foreach (Seat seat in seats)
                seat.Accept(visitor);
        }
    }
}