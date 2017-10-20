using System;
using System.Collections.Generic;

namespace DesignPattern.Mix.Appointments
{
    public static class Program
    {
        static void MassRegister(IEnumerable<IRegistrant> registrants)
        {
            foreach (var item in registrants)
            {
                item.Register();
            }
        }
        static void ScramblePasswords(IEnumerable<IRegistrant> registrants)
        {
            foreach (var item in registrants)
            {
                item.ChangePassword(Guid.NewGuid().ToString().Substring(0, 6));
            }
        }
        public static void Run()
        {
            var dataSvc = new DataService();

            DomainService domain =
                new DomainService(
                    new UserFactory(dataSvc));

            var user = domain.RegisterUser("Marek", "password");
            var joe = domain.RegisterUser("Joe", "pwd");
            Console.WriteLine($"{user}\n");
            Console.WriteLine($"{joe}\n");

            var group = new UserGroup();
            group.AddMember(user);
            group.AddMember(joe);

            var regGroup = new RegistrantGroup(group, "friends", "passwd");
            regGroup.Register();

            IAppointment appointment =
                user.MakeAppointment(DateTime.Now.Date.AddHours(30));
            Console.WriteLine($"{appointment}\n");
            user = domain.ChangePassword("Marek","password","newpassword");
            Console.WriteLine($"{user}\n");

            var registrants = new IRegistrant[]
            {
                new PersistableUser(joe,dataSvc,"pwd"),
                new PersistableUser(user,dataSvc,"password")
            };
            MassRegister(registrants);
            ScramblePasswords(registrants);
            Console.ReadLine();
        }
    }
}
