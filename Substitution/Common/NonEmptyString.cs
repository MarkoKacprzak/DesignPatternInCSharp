using System;

namespace Substitution.Common
{
    public class NonEmptyString : INonEmptyStringState
    {
        private string Value { get;}
        public NonEmptyString(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException();
            Value = value;
        }
        public string Get() => Value;

        public INonEmptyStringState Set(string value)
        => new NonEmptyString(value);
    }
}
