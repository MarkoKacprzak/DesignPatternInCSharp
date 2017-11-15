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
        private INonEmptyStringState FirstNameState { get; set; }
            = new UninitializedString();
        private INonEmptyStringState LastNameState { get; set; }
            = new UninitializedString();
        private IPrimaryContactState PrimaryContact { get; set; }
        public IList<IContactInfo> Contacts { get; }
        private PersonBuilder()
        {
            Contacts = new List<IContactInfo>();
            PrimaryContact = new UninitializedPrimaryContact(Contacts.Contains);
        }
        public static IFirstNameHolder Person()
            => new PersonBuilder();
        public ILastNameHolder WithFirstName(string firstName)
        {
            FirstNameState = FirstNameState.Set(firstName);
            return this;
        }
        public IPrimaryContactHolder WithLastName(string lastName)
        {
            LastNameState = LastNameState.Set(lastName);
            return this;
        }
        public IContanctHolder WithSecondaryContact(IContactInfo contact)
        {
            if (Contacts.Contains(contact))
                throw new ArgumentException();

            Contacts.Add(contact);
            return this;
        }

        public IContanctHolder WithPrimaryContact(IContactInfo contact)
        {
            WithSecondaryContact(contact);
            PrimaryContact = PrimaryContact.Set(contact);
            return this;
        }
        public IPersonBuilder AndNoMoreContacts()
            => this;

        public Models.Person Build()
        {
            var person = new Models.Person(FirstNameState.Get(), LastNameState.Get());
            foreach (var contact in Contacts)
                person.Add(contact);
            person.SetPrimaryContact(PrimaryContact.Get());
            return person;
        }
    }
}