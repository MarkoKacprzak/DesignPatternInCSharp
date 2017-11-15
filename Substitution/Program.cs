﻿using Substitution.Factories.Interfaces;
using Substitution.Factories.Machine;
using Substitution.Factories.Person;
using Substitution.Interfaces;
using Substitution.Models;
using System;

namespace Substitution
{
    class Program
    {
        static void ConfigureUser()
        {
            IUserFactory factory = new PersonFactory();
            IUser user = factory.CreateUser("Max", "Planck");
            IUserIdentity id = factory.CreateIdentity();
            user.SetIdentity(id);

            var factoryM = new MachineFactory(
                new System.Collections.Generic.Dictionary<string, Producer>
                {
                    ["pc"] = new Producer()
                });
            var machine = factoryM.CreateUser("pc", "1000");
            var id2 = factoryM.CreateIdentity();
            machine.SetIdentity(id2);
        }

        static void Main(string[] args)
        {

            ConfigureUser();

            Console.WriteLine("Reached end of demonstration...");
            Console.ReadLine();
        }
    }
}
