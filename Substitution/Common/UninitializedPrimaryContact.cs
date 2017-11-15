using Substitution.Interfaces;
using System;

namespace Substitution.Common
{
    public class UninitializedPrimaryContact : IPrimaryContactState
    {
        public UninitializedPrimaryContact(Func<IContactInfo,bool> predicate)
        {
            Predicate = predicate;
        }

        public Func<IContactInfo, bool> Predicate { get; }

        public IContactInfo Get()
        {
            throw new InvalidOperationException();
        }

        public IPrimaryContactState Set(IContactInfo contact)
            => new ValidPrimaryContact(contact, Predicate);
    }
}
