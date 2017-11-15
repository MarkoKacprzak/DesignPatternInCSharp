using Substitution.Common;
using Substitution.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Substitution.Builders.Person
{
    public class PersonBuilder
    {
        private INonEmptyStringState FirstNameState { get; set; }
            = new UninitializedString();
        private INonEmptyStringState LastNameState { get; set; }
            = new UninitializedString();
        private IPrimaryContactState PrimaryContact { get; set; }
        public IList<IContactInfo> Contacts { get; }
        public PersonBuilder()
        {
            Contacts = new List<IContactInfo>();
            PrimaryContact = new UninitializedPrimaryContact(Contacts.Contains);
        }
        public void SetFirstName(string firstName)
        {
            FirstNameState = FirstNameState.Set(firstName);
        }
        public void SetLastName(string lastName)
        {
            LastNameState = LastNameState.Set(lastName);
        }
        public void Add(IContactInfo contact)
        {
            if (Contacts.Contains(contact))
                throw new ArgumentException();

            Contacts.Add(contact);
        }

        public void SetPrimaryContact(IContactInfo contact)
        {
            PrimaryContact = PrimaryContact.Set(contact);
        }

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