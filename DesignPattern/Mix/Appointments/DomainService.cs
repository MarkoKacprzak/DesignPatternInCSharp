namespace DesignPattern.Mix.Appointments
{
    class DomainService
    {
        private readonly IUserFactory userFactory;

        public DomainService(IUserFactory userFactory)
        {
            this.userFactory = userFactory;
        }
        public IUser RegisterUser(string name, string password)
        {
            var user = CreateUser(name, password);
            user.Register();
            return user;
        }
        public IUser ChangePassword(string name, string password, string newPassword)
        {
            var user = CreateUser(name, password);
            user.ChangePassword(newPassword);
            return user;
        }
        private IRegistrantUser CreateUser(string name, string password)
        {
            IUser user = userFactory.CreateUser(name);
            return userFactory.CreateRegistrantUser(user, password);
        }
    }
}
