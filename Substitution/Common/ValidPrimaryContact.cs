using Substitution.Interfaces;
using System;

namespace Substitution.Common
{
    public class ValidPrimaryContact : IPrimaryContactState
    {
        public ValidPrimaryContact(IContactInfo contact, Func<IContactInfo, bool> predicate)
        {
            if (contact == null || predicate == null)
                throw new ArgumentNullException();
            if (!predicate(contact))
                throw new ArgumentException();
            this.Contact = contact;
            this.Predicate = predicate;
        }

        public IContactInfo Contact { get; }
        public Func<IContactInfo, bool> Predicate { get; }

        public IContactInfo Get()
            => Contact;
        public IPrimaryContactState Set(IContactInfo contact)
            => new ValidPrimaryContact(contact, Predicate);
    }
}
