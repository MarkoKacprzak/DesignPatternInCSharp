using DesignPattern.Creational.AbstractFactory.Sample2.Interfaces;

namespace DesignPattern.Creational.AbstractFactory.Sample2.Models
{
    class MacAddress: IUserIdentity
    {
        public string RawAddress { get; set; }
    }
}
