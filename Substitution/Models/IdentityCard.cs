using Substitution.Interfaces;

namespace Substitution.Models
{
    public class IdentityCard: IUserIdentity
    {
        public string SSN => "imagine one";
    }
}
