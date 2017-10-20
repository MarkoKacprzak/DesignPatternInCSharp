using System;

namespace DesignPattern.Mix.Appointments
{
    class Meeting : IAppointment
    {
        private DateTime startTime;
        private TimeSpan duration;

        public Meeting(DateTime startTime, TimeSpan duration)
        {
            this.startTime = startTime;
            this.duration = duration;
        }
        public override string ToString()
        {
            return $"Meeting starting at {startTime}, taking {duration.TotalMinutes} min.";
        }
    }
}
