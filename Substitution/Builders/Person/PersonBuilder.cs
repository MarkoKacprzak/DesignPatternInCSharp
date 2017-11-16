using Substitution.Builders.Interfaces;
using Substitution.Common;
using Substitution.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Substitution.Builders.Person
{
    public class PersonBuilder: IFirstNameHolder, ILastNameHolder, IPrimaryContactHolder, IContanctHolder, IPersonBuilder
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private IContactInfo PrimaryContact { get; set; }
        public IList<IContactInfo> Contacts { get; set; } = new List<IContactInfo>(); 
        public static IFirstNameHolder Person()
            => new PersonBuilder();
        public ILastNameHolder WithFirstName(string firstName)
            => new PersonBuilder
            {
                FirstName = firstName
            };
        public IPrimaryContactHolder WithLastName(string lastName)
            => new PersonBuilder
            {
                FirstName = this.FirstName,
                LastName = lastName
            };
        public IContanctHolder WithSecondaryContact(IContactInfo contact)
        => new PersonBuilder
        {
            FirstName = this.FirstName,
            LastName = this.LastName,
            Contacts = new List<IContactInfo>(Contacts) { contact },
            PrimaryContact = this.PrimaryContact
        };

        public IContanctHolder WithPrimaryContact(IContactInfo contact)
        => new PersonBuilder
        {
            FirstName = this.FirstName,
            LastName = this.LastName,
            Contacts = new List<IContactInfo>(this.Contacts) { contact },
            PrimaryContact = contact
        };
        public IPersonBuilder AndNoMoreContacts()
            => this;

        public Models.Person Build()
        {
            var person = new Models.Person(FirstName, LastName);
            foreach (var contact in Contacts)
                person.Add(contact);
            person.SetPrimaryContact(PrimaryContact);
            return person;
        }
    }
}