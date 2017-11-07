using DesignPattern.Creational.AbstractFactory.Sample2.Factories.Interfaces;
using DesignPattern.Creational.AbstractFactory.Sample2.Interfaces;
using DesignPattern.Creational.AbstractFactory.Sample2.Models;

namespace DesignPattern.Creational.AbstractFactory.Sample2.Factories.Person
{
    public class PersonFactory : IUserFactory
    {
        public IUser CreateUser(string name1, string name2)
        {
            return new Models.Person(name1, name2);
        }

        public IUserIdentity CreateIdentity()
        {
            return new IdentityCard();
        }
    }
}
