using DesignPattern.Mix.CarShop.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Mix.CarShop
{
    class CarRegistrationBuilder : ICarVisitor<CarRegistration>
    {

        private ICar car;
        private string make;
        private string model;
        private float engineCapacity;
        private int seatsCount;

        public CarRegistrationBuilder(ICar car)
        {
            this.car = car;
        }

        public void VisitCar(string make, string model)
        {
            this.make = make;
            this.model = model;
        }

        public void VisitEngine(EngineStructure structure, EngineStatus status)
        {
            this.engineCapacity = structure.CylinderVolume;
        }

        public void VisitSeat(string name, int capacity)
        {
            this.seatsCount += capacity;
        }

        public CarRegistration ProduceResult()
        {
            this.car.Accept(() => (ICarVisitor)this);
            return new CarRegistration(this.make.ToUpper(), this.model,
                                       this.engineCapacity,
                                       this.seatsCount);
        }

    }

}
