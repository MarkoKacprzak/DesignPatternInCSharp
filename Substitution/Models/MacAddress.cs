using Substitution.Interfaces;

namespace Substitution.Models
{
    public class MacAddress: IUserIdentity
    {
        public MacAddress(string NicPart)
        {
            this.NicPart = NicPart;
        }
        public string NicPart { get; }
    }
}
