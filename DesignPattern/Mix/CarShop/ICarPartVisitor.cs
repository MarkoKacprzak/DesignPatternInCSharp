using DesignPattern.Mix.CarShop.POCO;

namespace DesignPattern.Mix.CarShop
{
    interface ICarPartVisitor
    {
        void VisitEngine(EngineStructure structure, EngineStatus status);
        void VisitSeat(string name, int capacity);
    }
}
