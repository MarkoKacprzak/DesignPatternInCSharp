using System;

namespace DesignPattern.Mix.Reservations
{
    public interface IAirplaneService
    {
        IVacationPart SelectFlight(string companyName, string origin, string destination, DateTime travelDate);
    }
}
