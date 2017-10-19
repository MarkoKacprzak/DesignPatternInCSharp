namespace DesignPattern.Mix.CarShop
{
    class CarToStringVisitor: ICarVisitor
    {
        private string carDetails;
        private string report;
        private int seatsCount;

        public void Visit(string make, string model)
        {
            carDetails = $"{make} {model}";
        }

        public void Visit(Engine engine)
        {
            report += $" {engine.CylinderVolume}cc {engine.Power}kW";
        }

        public void Visit(Seat seat)
        {
            seatsCount+=seat.Capacity;
        }

        public string GetCarDescription()
        {
            return $"{carDetails} {report} {seatsCount} seat(s)";
        }
    }
}
