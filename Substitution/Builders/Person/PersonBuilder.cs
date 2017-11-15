using Substitution.Common;
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
        public void SetFirstName(string firstName)
        {
            FirstNameState = FirstNameState.Set(firstName);
        }
        public void SetLastName(string lastName)
        {
            LastNameState = LastNameState.Set(lastName);
        }
        public Models.Person Build()
            => new Models.Person(FirstNameState.Get(), LastNameState.Get());
    }
}