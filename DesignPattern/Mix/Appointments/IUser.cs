using System;

namespace DesignPattern.Mix.Appointments
{
    interface IUser
    {
        IAppointment MakeAppointment(DateTime startTime);
        void Accept(Func<IUserVisitor> visitorFactory);
    }
}
