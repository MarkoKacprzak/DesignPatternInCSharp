using Substitution.Factories.Interfaces;
using Substitution.Factories.Machine;
using Substitution.Factories.Person;
using Substitution.Models;
using System;

namespace Substitution
{
    class Program
    {
        static void RegisterUser(IUserFactory<Person, IdentityCard> userFactory)
        {
            IUserFactory<Person, BillMurrayCard> lessDerivedFact = userFactory;
            var holder = lessDerivedFact.CreateUser("Max", "Planc");
            holder.SetIdentity(new BillMurrayCard());
        }
        static void ConfigureUser()
        {
            var factory = new PersonFactory();
            Person user = factory.CreateUser("Max", "Planck");
            user.SetIdentity(new BillMurrayCard());
            var factoryM = new MachineFactory(
                new System.Collections.Generic.Dictionary<string, Producer>
                {
                    ["pc"] = new Producer()
                });
            var machine = factoryM.CreateUser("pc", "1000");
            machine.SetIdentity(new MacAddress("122313"));
        }

        static void Main(string[] args)
        {

            ConfigureUser();

            Console.WriteLine("Reached end of demonstration...");
            Console.ReadLine();
        }
    }
}
