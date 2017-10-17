using Microsoft.Practices.Unity;
using System;

namespace DesignPattern.Mix.Reservations
{
    public static class Program
    {
        static IUnityContainer InitializeIoCContainer()
        {
            return
                new UnityContainer()
                .RegisterType<Application, Application>()
                .RegisterType<IVacationPartFactory, VacationPartFactory>(
                    new ContainerControlledLifetimeManager())
                .RegisterType<IHotelSelector, HotelSelector>(
                    new ContainerControlledLifetimeManager())
                .RegisterType<IHotelService, HotelService>(
                    new ContainerControlledLifetimeManager())
                .RegisterType<IAirplaneService, AirplaneService>(
                    new ContainerControlledLifetimeManager());
        }

        public static void Run()
        {
            InitializeIoCContainer()
                .Resolve<Application>()
                .Run();
            Console.ReadLine();

        }
    }
}
