using System;

namespace DesignPattern.Mix.Appointments
{
    internal interface IUser
    {
        IAppointment MakeAppointment(DateTime startTime);
    }
}
