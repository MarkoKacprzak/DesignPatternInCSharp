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
            IUser user = domain.RegisterUser("Marek", "password");
            Console.WriteLine($"{user}\n");

            IAppointment appointment =
                user.MakeAppointment(DateTime.Now.Date.AddHours(30));
            Console.WriteLine($"{appointment}\n");
            user = domain.ChangePassword("Marek","password","newpassword");
            Console.WriteLine($"{user}\n");
            Console.ReadLine();
        }
    }
}
