using System;

namespace DesignPattern.Mix.Reservations
{
    public class Application
    {
        private IVacationPartFactory partFactory;

        public Application(IVacationPartFactory partFactory)
        {
            this.partFactory = partFactory;
        }

        public void Run()
        {

            VacationSpecificationBuilder builder = 
                new VacationSpecificationBuilder(
                    this.partFactory,
                    new DateTime(2015, 7, 11), 14,
                    "Crouded City", "Seatown");

            builder.SelectHotel("Small one");
            builder.SelectAirplane("Noisy one");

            VacationSpecification spec = builder.BuildVacation();

        }
    }
}
