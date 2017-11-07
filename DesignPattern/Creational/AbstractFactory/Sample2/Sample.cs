using System;
using DesignPattern.Creational.AbstractFactory.Sample2.Factories.Interfaces;
using DesignPattern.Creational.AbstractFactory.Sample2.Factories.Person;
using DesignPattern.Creational.AbstractFactory.Sample2.Interfaces;
using DesignPattern.Creational.AbstractFactory.Sample2.Factories.Machine;

namespace DesignPattern.Creational.AbstractFactory.Sample2
{
    public class Sample:ISample
    {

        static void RegisterUser(IUserFactory userFactory)
        {
            IUser user = userFactory.CreateUser("Max", "Planck");
            Console.WriteLine($"Hello {user}, welcome back!");
        }

        public void Run()
        {   
            RegisterUser(new PersonFactory());
            RegisterUser(new MachineFactory(
                new System.Collections.Generic.Dictionary<string, Models.Producer>
                {
                    ["Max"] = new Models.Producer()
                }));
        }
    }
}
