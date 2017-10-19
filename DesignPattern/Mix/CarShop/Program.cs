using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Mix.CarShop
{
    public static class Program
    {
        public static void Run()
        {

           var cars = new CarRepository().GetAll();

            cars.ToList()
                .ForEach(car => car.Accept(
                    () => new SaveCarVisitor()));

            var view = new CarsView(cars);
            view.Render();

            Console.Write("Press ENTER to exit...");
            Console.ReadLine();

        }
    }
}