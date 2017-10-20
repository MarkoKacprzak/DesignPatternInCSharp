using System;

namespace DesignPattern.Mix.Appointments
{
    /// <summary>
    /// Augmented class - mixin interface
    /// IRegistrant and IUser
    /// </summary>
    class PersistableUser : IRegistrantUser, IUserVisitor
    {
        private readonly IUser user;
        private readonly IRegistrationService registrationService;
        private string password;
        private string userName;
        public PersistableUser(IUser user, 
            IRegistrationService registrationService,
            string password)
        {
            this.user = user;
            this.registrationService = registrationService;
            this.password = password;
            this.user.Accept(() => this);
        }
        public IAppointment MakeAppointment(DateTime startTime)
        {
            return user.MakeAppointment(startTime);
        }
        public void ChangePassword(string newPassword)
        {
            registrationService.ChangePassword(userName, password, newPassword);
            password = newPassword;
        }

        public void Register()
        {
            registrationService.Register(userName, password);
        }

        public void Accept(Func<IUserVisitor> visitorFactory)
        {
            this.user.Accept(visitorFactory);
        }

        public void VisitUser(string name)
        {
            this.userName = name;
        }
        public override string ToString()
        {
            return $"PersistableUser(name={userName}, password={password})";
        }
    }
}
