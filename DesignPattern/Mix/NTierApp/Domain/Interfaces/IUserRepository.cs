namespace DesignPattern.Mix.NTierApp.Domain.Interfaces
{
    public interface IUserRepository
    {
        void Add(IUser user);
        IUser Find(string username);
    }
}
