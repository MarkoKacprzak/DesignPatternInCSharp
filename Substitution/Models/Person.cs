using System;
using Substitution.Interfaces;

namespace Substitution.Models
{
    public class Person: IUser
    {
        private string name;
        private string surname;

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
