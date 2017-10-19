using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Mix.CarShop
{
    class Car
    {

        public string Make { get; private set; }
        public string Model { get; private set; }
        public Engine Engine { get; private set; }
        public IEnumerable<Seat> Seats { get; private set; }
        public Seat Seat => Seats.ToList()[0];

        public Car(string make, string model, Engine engine, IEnumerable<Seat> seats)
        {
            this.Make = make;
            this.Model = model;
            this.Engine = engine;
            this.Seats = new List<Seat>(seats);
        }

    }
}