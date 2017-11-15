using Substitution.Interfaces;

namespace Substitution.Common
{
    public interface IPrimaryContactState
    {
        IPrimaryContactState Set(IContactInfo contact);
        IContactInfo Get();
    }
}
