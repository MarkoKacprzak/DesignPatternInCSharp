namespace DesignPattern.Mix.CarShop
{
    interface ICarVisitor : ICarPartVisitor
    {
        void VisitCar(string make, string model);
    }
}
