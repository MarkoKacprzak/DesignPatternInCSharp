namespace DesignPattern.Mix.CarShop
{
    class CarToStringVisitor: ICarVisitor
    {
        private string carDetails;
        private string engineDetails;
        private int seatsCount;

        public void Visit(string make, string model)
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

        public string GetCarDescription()
        {
            return $"{carDetails} {engineDetails} {seatsCount} seat(s)";
        }
    }
}
