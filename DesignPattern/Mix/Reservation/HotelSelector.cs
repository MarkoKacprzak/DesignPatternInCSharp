using System;

namespace DesignPattern.Mix.Reservations
{
    public class HotelSelector: IHotelSelector
    {
        public HotelInfo SelectHotel(string town, string hotelName)
        {
            Console.WriteLine("Looking up hotel {0} in {1}", hotelName, town);
            return new HotelInfo() { Town = town, HotelName = hotelName };
        }
    }
}
