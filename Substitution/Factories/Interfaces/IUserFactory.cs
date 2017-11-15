using Substitution.Interfaces;

namespace Substitution.Factories.Interfaces
{
    public interface IUserFactory<out TUser, in TIdentity>
        where TUser:IUser<TIdentity>
        where TIdentity: IUserIdentity
    {
        TUser CreateUser(string name1, string name2);
    }
}
