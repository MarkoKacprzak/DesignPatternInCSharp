namespace DesignPattern.Mix.CarShop
{
    interface ICarVisitor: ICarPartVisitor
    {
        void Visit(string make, string model);
    }
}
