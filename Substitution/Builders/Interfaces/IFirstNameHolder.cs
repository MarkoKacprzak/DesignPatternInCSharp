using Substitution.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Substitution.Builders.Interfaces
{
    public interface IFirstNameHolder
    {
        ILastNameHolder SetFirstName(string name);
    }
    public interface ILastNameHolder
    {
        IPrimaryContactHolder SetLastName(string name);
    }
    public interface IPrimaryContactHolder
    {
        IContanctHolder SetPrimaryContact(IContactInfo contact);
    }
    public interface IContanctHolder
    {
        IContanctHolder Add(IContactInfo contact);
        IPersonBuilder NoMoreContacts();
    }
    public interface IPersonBuilder
    {
        Models.Person Build();
    }
}
