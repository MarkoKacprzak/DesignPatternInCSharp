using Substitution.Interfaces;

namespace Substitution.Models
{
    public class MacAddress: IUserIdentity
    {
        public string NicPart { get; set; }
    }
}
