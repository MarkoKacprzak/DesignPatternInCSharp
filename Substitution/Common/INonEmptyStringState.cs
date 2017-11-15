using System.Collections.Generic;
using System.Text;

namespace Substitution.Common
{
    public interface INonEmptyStringState
    {
        INonEmptyStringState Set(string value);
        string Get();
    }
}
