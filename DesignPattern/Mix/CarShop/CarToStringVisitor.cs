namespace DesignPattern.Mix.CarShop
{
    class CarToStringVisitor: ICarVisitor<string>
    {
        private string carDetails;
        private string engineDetails;
        private int seatsCount;

        public void VisitCar(string make, string model)
        {
            carDetails = $"{make} {model}";
        }

        public void VisitEngine(float power, float cylinderVolume,
                                 float temperatureC)
        {
            engineDetails = $"{cylinderVolume}cc {power}kW";
        }


        public void VisitSeat(string name, int capacity)
        {
            seatsCount +=capacity;
        }

        public string ProduceResult()
        {
            return $"{carDetails} {engineDetails} {seatsCount} seat(s)";
        }
    }
}
