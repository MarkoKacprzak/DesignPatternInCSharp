using System;
using System.Collections.Generic;

namespace DesignPattern.Mix.CarShop
{
    public static class Program
    {
        public static void Run()
        {

           var cars = new CarRepository().GetAll();

            var view = new CarsView(cars);
            view.Render();

            Console.Write("Press ENTER to exit...");
            Console.ReadLine();

        }
    }
}