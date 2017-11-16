using Substitution.Interfaces;

namespace Substitution.Builders.Person.Interfaces
{
    public interface IContanctHolder
    {
        IContanctHolder WithSecondaryContact(IContactInfo contact);
        IPersonBuilder AndNoMoreContacts();
    }
}
