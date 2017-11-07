using DesignPattern.Creational.AbstractFactory.Sample2.Interfaces;

namespace DesignPattern.Creational.AbstractFactory.Sample2.Factories.Interfaces
{
    public interface IUserFactory
    {
        IUser CreateUser(string name1, string name2);
        IUserIdentity CreateIdentity();
    }
}
