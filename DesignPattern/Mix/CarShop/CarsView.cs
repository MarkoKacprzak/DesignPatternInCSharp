using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Mix.CarShop
{
    class CarsView
    {
        private IEnumerable<Car> cars;
        public Car Car=>cars.ToList()[0];

        public CarsView(IEnumerable<Car> cars)
        {
            this.cars = new List<Car>(cars);
        }

        public void Render()
        {
            foreach (Car car in cars)
                Console.WriteLine($"{car.Make} {car.Model} " +
                    $"{car.Engine.CylinderVolume}cc " +
                    $"{car.Engine.Power}kW " +
                    $"{car.Seats.Sum(seat => seat.Capacity)} seat(s)");
        }
    }
}
