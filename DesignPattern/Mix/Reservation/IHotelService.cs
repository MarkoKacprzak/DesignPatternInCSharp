using System;

namespace DesignPattern.Mix.Reservations
{
    public interface IHotelService
    {
        IVacationPart MakeBooking(HotelInfo hotel, DateTime checkin, DateTime checkout);
    }
}
