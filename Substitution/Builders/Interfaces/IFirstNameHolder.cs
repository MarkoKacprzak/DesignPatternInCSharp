using Substitution.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Substitution.Builders.Interfaces
{
    public interface IFirstNameHolder
    {
        ILastNameHolder WithFirstName(string name);
    }
    public interface ILastNameHolder
    {
        IPrimaryContactHolder WithLastName(string name);
    }
    public interface IPrimaryContactHolder
    {
        IContanctHolder WithPrimaryContact(IContactInfo contact);
    }
    public interface IContanctHolder
    {
        IContanctHolder WithSecondaryContact(IContactInfo contact);
        IPersonBuilder AndNoMoreContacts();
    }
    public interface IPersonBuilder
    {
        Models.Person Build();
    }
}
