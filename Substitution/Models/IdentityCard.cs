using Substitution.Interfaces;

namespace Substitution.Models
{
    public class IdentityCard: IUserIdentity
    {
        public IdentityCard(string SSN)
        {
            this.SSN = SSN;
        }

        public string SSN { get; }
    }
}
