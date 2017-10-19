using System;

namespace DesignPattern.Mix.CarShop
{
    interface ICar
    {
        CarRegistration Register();
        void Accept(Func<ICarVisitor> visitorFactory);
        T Accept<T>(Func<ICarVisitor<T>> visitorFactory);
    }
}
