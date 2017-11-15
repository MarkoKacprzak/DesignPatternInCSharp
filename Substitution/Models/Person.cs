using System;
using Substitution.Interfaces;

namespace Substitution.Models
{
    public class Person: IUser<IdentityCard>
    {
        private string name;
        private string surname;

        public void SetIdentity(IdentityCard identity)
        {
            this.Identity = identity;
            Console.WriteLine("Accepted person identity card.");
            // do something with idCard.SSN

        }
        

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

        public IdentityCard Identity { get; private set; }

        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

    }
}
