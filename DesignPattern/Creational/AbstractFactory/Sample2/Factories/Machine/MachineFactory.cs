using System;
using System.Collections.Generic;
using DesignPattern.Creational.AbstractFactory.Sample2.Factories.Interfaces;
using DesignPattern.Creational.AbstractFactory.Sample2.Interfaces;
using DesignPattern.Creational.AbstractFactory.Sample2.Models;

namespace DesignPattern.Creational.AbstractFactory.Sample2.Factories.Machine
{
    public class MachineFactory : IUserFactory
    {

        private Dictionary<string, Producer> NameToProducer { get; }

        public MachineFactory(Dictionary<string, Producer> nameToProducer)
        {
            NameToProducer = nameToProducer ?? throw new ArgumentNullException(nameof(nameToProducer));
        }

        private Producer GetProducer(string name)
        {
            if (!NameToProducer.TryGetValue(name, out Producer producer))
                throw new ArgumentException();
            return producer;
        }

        public IUser CreateUser(string name1, string name2)
        {
            var producer = GetProducer(name1);
            return new Models.Machine(producer, name2);
        }

        public IUserIdentity CreateIdentity()
        {
            return new MacAddress();
        }
    }
}
