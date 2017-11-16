using Substitution.Builders.Person.Interfaces;
using Substitution.Interfaces;
using System.Collections.Generic;

namespace Substitution.Builders.Person
{
    public class PersonBuilder : IFirstNameHolder, ILastNameHolder, IPrimaryContactHolder, IContanctHolder, IPersonBuilder
    {
        private string FirstName { get; }
        private string LastName { get; }
        private IContactInfo PrimaryContact { get; }
        public IList<IContactInfo> Contacts { get; }
        public static IFirstNameHolder Person()
            => new PersonBuilder();
        public PersonBuilder()
        {
        }
        public PersonBuilder(string firstName) : this(firstName, null)
        {
        }
        public PersonBuilder(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Contacts = new List<IContactInfo>();
        }
        public PersonBuilder(string firstName, string lastName, IList<IContactInfo> contacts, IContactInfo primary)
        {
            Contacts = new List<IContactInfo>(contacts) { primary };
            PrimaryContact = primary;
            FirstName = firstName;
            LastName = lastName;
        }
        public PersonBuilder(string firstName, string lastName, IList<IContactInfo> contacts, IContactInfo primary, IContactInfo secondary)
        {
            Contacts = new List<IContactInfo>(contacts) { secondary };
            FirstName = firstName;
            LastName = lastName;
            PrimaryContact = primary;
        }

        public ILastNameHolder WithFirstName(string firstName)
            => new PersonBuilder(firstName);
        public IPrimaryContactHolder WithLastName(string lastName)
            => new PersonBuilder(this.FirstName, lastName);
        public IContanctHolder WithSecondaryContact(IContactInfo contact)
            => new PersonBuilder(FirstName, LastName, Contacts, PrimaryContact, contact);

        public IContanctHolder WithPrimaryContact(IContactInfo contact)
            => new PersonBuilder(FirstName, LastName, Contacts, contact);
        public IPersonBuilder AndNoMoreContacts()
            => this;
        public Models.Person Build()
            => new Models.Person(FirstName, LastName, Contacts, PrimaryContact);
    }
}