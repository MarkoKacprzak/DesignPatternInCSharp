using Substitution.Interfaces;

namespace Substitution.Builders.Person.Interfaces
{
    public interface IPrimaryContactHolder
    {
        IContanctHolder WithPrimaryContact(IContactInfo contact);
    }
}
