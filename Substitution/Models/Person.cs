using System;
using Substitution.Interfaces;
using System.Collections.Generic;

namespace Substitution.Models
{
    public class Person: IUser
    {
        private string name;
        private string surname;

        private IList<IContactInfo> Contacts { get; } = new List<IContactInfo>();
        private IContactInfo PrimaryContact { get; set; }
        public void SetIdentity(IUserIdentity identity)
        {

            if (!this.CanAcceptIdentity(identity))
                throw new ArgumentException();

            IdentityCard idCard = identity as IdentityCard;

            Console.WriteLine("Accepted person identity card.");
            // do something with idCard.SSN
        }
        public void Add(IContactInfo contact)
        {
            if (Contacts.Contains(contact))
                throw new ArgumentException();

            Contacts.Add(contact);
        }
        public void SetPrimaryContact(IContactInfo contact)
        {
            if (contact == null)
                throw new ArgumentNullException();
            if (!Contacts.Contains(contact))
                throw new ArgumentException();
            this.PrimaryContact = contact;
        }
        public bool CanAcceptIdentity(IUserIdentity identity) =>
            identity is IdentityCard;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("First name must be non-empty.");
                this.name = value;
            }
        }

        public string Surname
        {
            get { return this.surname; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Last name must be non-empty;");
                this.surname = value;
            }
        }

        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

    }
}
