using System;

namespace DesignPattern.Mix.Reservations
{
    public class VacationPartFactory: IVacationPartFactory
    {

        private IHotelSelector hotelSelector;
        private IHotelService hotelService;
        private IAirplaneService airplaneService;

        public VacationPartFactory(IHotelSelector hotelSelector,
                                   IHotelService hotelService,
                                   IAirplaneService airplaneService)
        {
            this.hotelSelector = hotelSelector;
            this.hotelService = hotelService;
            this.airplaneService = airplaneService;
        }

        public IVacationPart CreateHotelReservation(string town, string hotelName,
                                                    DateTime arrivalDate,
                                                    DateTime leaveDate)
        {
            HotelInfo hotel = this.hotelSelector.SelectHotel(town, hotelName);
            return this.hotelService.MakeBooking(hotel, arrivalDate, leaveDate);
        }

        public IVacationPart CreateFlight(string companyName, string source,
                                          string destination, DateTime date)
        {
            return
                this.airplaneService
                .SelectFlight(companyName, source, destination, date);
        }

        public IVacationPart CreateFerryBooking(string lineName, bool fromMainland,
                                                DateTime date)
        {
            throw new NotImplementedException();
        }

        public IVacationPart CreateDailyTrip(string tripName, DateTime date)
        {
            throw new NotImplementedException();
        }

        public IVacationPart CreateMassage(string salon, DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}
