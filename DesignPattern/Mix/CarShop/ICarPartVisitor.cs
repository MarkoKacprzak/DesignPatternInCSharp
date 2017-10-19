namespace DesignPattern.Mix.CarShop
{
    interface ICarPartVisitor
    {
        void VisitEngine(float power, float cylinderVolume, float temperatureC);
        void VisitSeat(string name, int capacity);
    }
}
