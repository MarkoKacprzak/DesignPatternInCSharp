namespace DesignPattern.Mix.CarShop
{
    interface ICarVisitor<T> : ICarVisitor
    {
        T ProduceResult();
    }
}
