using System;

namespace DesignPattern.Mix.CarShop
{
    class CarPersistence
    {
        public int InsertCar(string make, string model)
        {

            Console.WriteLine("INSERT INTO CarShop.Car(Make, Model)");
            Console.WriteLine("VALUES ('{0}', '{1}');", make, model);
            Console.WriteLine("SELECT SCOPE_IDENTITY()");

            int carId = new Random().Next(100);

            Console.WriteLine();
            Console.WriteLine("CarId = {0}", carId);
            Console.WriteLine();

            return carId;
        }

        public void InsertEngine(int carId, float power, float cylinderVolume)
        {
            Console.WriteLine("INSERT INTO CarShop.Engine(CarID, Power, CylinderVolume)");
            Console.WriteLine("VALUES ({0}, {1}, {2})", carId, power, cylinderVolume);
            Console.WriteLine();
        }

        public void InsertSeat(int carId, string name, int capacity)
        {
            Console.WriteLine("INSERT INTO CarShop.Seat(CarID, Name, Capacity)");
            Console.WriteLine("VALUES ({0}, '{1}', {2})", carId, name, capacity);
            Console.WriteLine();
        }
    }
}