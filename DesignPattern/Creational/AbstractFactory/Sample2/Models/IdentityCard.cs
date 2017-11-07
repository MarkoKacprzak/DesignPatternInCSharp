using DesignPattern.Creational.AbstractFactory.Sample2.Interfaces;

namespace DesignPattern.Creational.AbstractFactory.Sample2.Models
{
    class IdentityCard: IUserIdentity
    {
        public string SSN { get; set; }
    }
}
