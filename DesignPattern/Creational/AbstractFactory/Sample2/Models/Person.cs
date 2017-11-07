using System;
using DesignPattern.Creational.AbstractFactory.Sample2.Interfaces;

namespace DesignPattern.Creational.AbstractFactory.Sample2.Models
{
    public class Person : IUser
    {

        public string Name { get; }
        public string Surname { get; }

        public Person(string name, string surname)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("First name must be non-empty.");
            if (string.IsNullOrEmpty(surname))
                throw new ArgumentException("Last name must be non-empty.");

            Name = name;
            Surname = surname;
        }

        public void SetIdentity(IUserIdentity identity)
        {
        }

        public override string ToString() => $"{this.Name} {this.Surname}";
    }
}
