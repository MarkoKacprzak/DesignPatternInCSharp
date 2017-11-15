namespace Substitution.Interfaces
{
    public interface IUser: ITicketHolder
    {
        void SetIdentity(IUserIdentity identity);
        bool CanAcceptIdentity(IUserIdentity identity);
        void Add(IContactInfo contact);
        void SetPrimaryContact(IContactInfo contact);
    }
}
