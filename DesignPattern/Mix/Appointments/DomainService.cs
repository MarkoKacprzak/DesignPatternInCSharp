namespace DesignPattern.Mix.Appointments
{
    class DomainService
    {
        private readonly DataService dataService;

        public DomainService(DataService dataService)
        {
            this.dataService = dataService;
        }
        public IUser RegisterUser(string name, string password)
        {
            dataService.RegisterUser(name, password);
            return new User(name, password);
        }
        public IUser ChangePassword(string name, string password, string newPassword)
        {
            dataService.ChangePassword(name, password, newPassword);
            return new User(name, newPassword);
        }
    }
}
