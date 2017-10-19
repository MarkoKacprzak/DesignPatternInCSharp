using DesignPattern.Mix.CarShop.POCO;
using System;

namespace DesignPattern.Mix.CarShop
{
    class Engine
    {

        private float power;
        private float cylinderVolume;

        private const float WorkingTemperatureC = 90.0F;
        private float temperatureC = 20.0F;

        public Engine(float power, float cylinderVolume)
        {
            this.power = power;
            this.cylinderVolume = cylinderVolume;
        }
        public void Accept(Func<ICarPartVisitor> visitorFactory)
        {
            var structure = new EngineStructure(this.power, this.cylinderVolume);
            var status = new EngineStatus(this.temperatureC, 0);
            visitorFactory().VisitEngine(structure, status);
        }
        public void Run(TimeSpan time)
        {

            var heatingTime = GetHeatingTime();

            if (time > heatingTime)
            {
                temperatureC = WorkingTemperatureC;
            }
            else
            {
                var temperatureDelta = WorkingTemperatureC - temperatureC;
                var timeRatio = time.TotalMinutes / heatingTime.TotalMinutes;
                temperatureC += (float)(temperatureDelta * timeRatio);
            }
        }
        private TimeSpan GetHeatingTime()
        {
            double meanPower = 180.0;
            double nominalHeatingTimeSec = 300.0;

            int seconds = (int)(nominalHeatingTimeSec * meanPower / power);
            return new TimeSpan(0, 0, seconds);
        }
    }
}
