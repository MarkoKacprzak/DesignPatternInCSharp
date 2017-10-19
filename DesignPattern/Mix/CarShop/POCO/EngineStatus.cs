namespace DesignPattern.Mix.CarShop.POCO
{
    class EngineStatus
    {
        public float TemperatureC { get; private set; }
        public float OilPressure { get; private set; }

        public EngineStatus(float temperatureC, float oilPressure)
        {
            TemperatureC = temperatureC;
            OilPressure = oilPressure;
        }
    }
}
