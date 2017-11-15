namespace Substitution.Interfaces
{
    public interface IUser<in TIdentity>: ITicketHolder
        where TIdentity: IUserIdentity
    {
        void SetIdentity(TIdentity identity);
    }
}
