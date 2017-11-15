using Substitution.Interfaces;

namespace Substitution.Models
{
    class EmailAdress : IContactInfo
    {
        public string Mail { get; }
        public EmailAdress(string mail)
        {
            Mail = mail;
        }

        public override string ToString()
            => Mail;
        
        public override int GetHashCode()
            => Mail.GetHashCode();
    }
}
