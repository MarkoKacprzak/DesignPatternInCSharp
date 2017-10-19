using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Mix.CarShop
{
    class Car: ICar
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

        public void Accept(Func<ICarVisitor> visitorFactory)
        {
            ICarVisitor visitor = visitorFactory();
            engine.Accept(()=>visitor);
            foreach (Seat seat in seats)
                seat.Accept(()=>visitor);
            visitor.VisitCar(make, model);
        }
        public T Accept<T>(Func<ICarVisitor<T>> visitorFactory)
        {
            ICarVisitor<T> visitor = visitorFactory();
            Accept(() => (ICarVisitor)visitor);
            return visitor.ProduceResult();
        }

        public CarRegistration Register()
        {
            return new CarRegistrationBuilder(this).ProduceResult();
        }
    }
}