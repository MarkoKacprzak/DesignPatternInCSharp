using System.Collections.Generic;

namespace DesignPattern.Mix.NTierApp.Domain.Interfaces
{
    public interface IUserRepository
    {
        void Add(IUser user);
        IEnumerable<IUser> Find(string username);
    }
}
