using DesignPattern.Mix.CarShop.POCO;
using System;
using System.Collections.Generic;

namespace DesignPattern.Mix.CarShop
{
    class SaveCarVisitor : ICarVisitor
    {
        private CarPersistence persistence = new CarPersistence();
        private int carId;
        private string make;
        private string model;
        private float power;
        private float cylinderVolume;
        private Queue<Tuple<string, int>> seats = new Queue<Tuple<string, int>>();

        public void VisitCar(string make, string model)
        {
            this.make = make;
            this.model = model;
            ProcessQueue();
        }

        public void VisitEngine(EngineStructure structure, EngineStatus status)
        {
            power = structure.Power;
            cylinderVolume = structure.CylinderVolume;
            ProcessQueue();
        }

        public void VisitSeat(string name, int capacity)
        {
            seats.Enqueue(Tuple.Create(name, capacity));
            ProcessQueue();
        }

        private void ProcessQueue()
        {
            SaveCar();
            SaveEngine();
            SaveSeats();
        }

        private void SaveCar()
        {
            if (carId == 0 && model != null)
                carId = persistence.InsertCar(make, model);
        }

        private void SaveEngine()
        {
            if (carId > 0 && power > 0)
            {
                persistence.InsertEngine(carId, power, cylinderVolume);
                power = 0;
            }
        }

        private void SaveSeats()
        {
            if (carId > 0)
            {
                while (seats.Count > 0)
                {
                    var seat = seats.Dequeue();
                    persistence.InsertSeat(carId, seat.Item1, seat.Item2);
                }
            }
        }

    }
}
