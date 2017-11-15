using System;
using System.Collections.Generic;
using System.Text;

namespace Substitution.Builders.Person
{
    public class PersonBuilder
    {
        private Func<string> GetValidLastName { get; set; } =
            () => { throw new InvalidOperationException(); };
        private Func<string> GetValidFirstName { get; set; } =
            () => { throw new InvalidOperationException(); };
        public void SetFirstName(string firstName)
        {
            if (string.IsNullOrEmpty(firstName))
                throw new ArgumentException();
            GetValidFirstName = () => firstName;
        }

        public void SetLastName(string lastName)
        {
            if (string.IsNullOrEmpty(lastName))
                throw new ArgumentException();
            GetValidLastName = () => lastName;
        }
        public Models.Person Build()
            => new Models.Person(GetValidFirstName(), GetValidLastName());
    }
}