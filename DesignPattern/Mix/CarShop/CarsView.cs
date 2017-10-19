using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Mix.CarShop
{
    class CarsView
    {
        private Car[] cars;

        public CarsView(IEnumerable<Car> cars)
        {
            this.cars = new List<Car>(cars).ToArray();
        }

        public void Render()
        {
            foreach (Car car in this.cars)
            {
                CarToStringVisitor converter = new CarToStringVisitor();
                car.Accept(converter);
                Console.WriteLine(converter.GetCarDescription());
            }
        }
    }
}
