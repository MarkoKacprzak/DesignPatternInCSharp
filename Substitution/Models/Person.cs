using System;
using Substitution.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Substitution.Models
{
    public class Person: IUser
    {
        public IList<IContactInfo> Contacts { get; } 
        public IContactInfo PrimaryContact { get; }
        public string Name { get; }
        public string Surname { get; }
        public void SetIdentity(IUserIdentity identity)
        {

            if (!this.CanAcceptIdentity(identity))
                throw new ArgumentException();

            IdentityCard idCard = identity as IdentityCard;

            Console.WriteLine("Accepted person identity card.");
            // do something with idCard.SSN
        }
        public bool CanAcceptIdentity(IUserIdentity identity) =>
            identity is IdentityCard;

        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public Person(string name, string surname, IEnumerable<IContactInfo> contacts, IContactInfo primary)
        {
            if (contacts == null || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || primary==null)
                throw new ArgumentNullException();
            if (!contacts.Contains(primary))
                throw new ArgumentException();
            this.Contacts = new List<IContactInfo>(contacts);
            this.PrimaryContact = primary;
            this.Name = name;
            this.Surname = surname;
        }
        public override string ToString() 
            => $"{Name} {Surname} [{AllContactsLabel}]";

        private string AllContactsLabel 
            => string.Join(", ", this.AllContactLabels.ToArray());
        private IEnumerable<string> AllContactLabels 
            => Contacts.Select(this.GetLabelFor);
        private string GetLabelFor(IContactInfo contact) 
            => $"{GetUiMarkFor(contact)}{contact}";
        private string GetUiMarkFor(IContactInfo contact) 
            => IsPrimary(contact) ? "*" : string.Empty;
        private bool IsPrimary(IContactInfo contact) 
            => contact.Equals(this.PrimaryContact);


    }
}
