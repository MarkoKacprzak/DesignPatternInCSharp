using System;

namespace DesignPattern.Mix.Appointments
{
    public static class Program
    {
        public static void Run()
        {
            DomainService domain =
                new DomainService(
                    new UserFactory(
                        new DataService()));
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
            Console.ReadLine();
        }
    }
}
