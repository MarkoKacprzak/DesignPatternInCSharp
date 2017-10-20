namespace DesignPattern.Mix.Appointments
{
    class UserFactory: IUserFactory
    {
        private readonly DataService dataService;

        public UserFactory(DataService dataService)
        {
            this.dataService = dataService;
        }

        public IUser CreateUser(string name)
        {
            return new User(name);
        }

        public IRegistrantUser CreateRegistrantUser(IUser user, string password)
        {
            return new PersistableUser(user, dataService, password);
        }

        
    }
    interface IUserFactory
    {
        IUser CreateUser(string name);
        IRegistrantUser CreateRegistrantUser(IUser user, string password);
    }
}
