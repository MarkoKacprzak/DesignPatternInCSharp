using DesignPattern.Mix.NTierApp.Application.Implementation;
using DesignPattern.Mix.NTierApp.Domain.Implementation;
using DesignPattern.Mix.NTierApp.Infrastructure.Implementation;
using DesignPattern.Mix.NTierApp.Presentation.Implementation;

namespace DesignPattern.Mix.NTierApp
{
    public static class Program
    {
        public static void Run()
        {

            UserInterface ui = 
                new UserInterface(
                    new ApplicationServices(
                        new DomainServices(
                            new UserRepository(),
                            new ProductRepository())));

            while (ui.ReadCommand())
            {
                ui.ExecuteCommand();
            }
        }
    }

}
