using System;

namespace DesignPattern.Mix.Appointments
{
    class User: IUser
    {
        private string name;
        private readonly string password;

        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
        public IAppointment MakeAppointment(DateTime startTime)
        {
            return new Meeting(startTime, TimeSpan.FromHours(1));
        }
        public override string ToString()
        {
            return $"User(name={name} password={password})";
        }
    }
}
