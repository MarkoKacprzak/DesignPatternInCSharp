using Substitution.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Substitution.Models
{
    public class PersonalManager
    {
        private Func<IUser> UserFactory { get; }
        public PersonalManager(Func<IUser> userFactory)
        {
            UserFactory = userFactory;
        }
        public void Notify(string message)
        {
            this.Enqueue(this.GetPrimaryContact(), message);
        }

        private void Enqueue(IContactInfo contactInfo, string message)
            => Console.WriteLine($"Sending '{message}' to {contactInfo}");

        private IContactInfo GetPrimaryContact()
            => UserFactory().PrimaryContact;
        
    }
}
