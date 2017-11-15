using Substitution.Factories.Interfaces;
using Substitution.Interfaces;
using Substitution.Models;

namespace Substitution.Factories.Person
{
    public class PersonFactory : IUserFactory<Models.Person, IdentityCard>
    {
        public Models.Person CreateUser(string name1, string name2)
        {
            return new Models.Person(name1, name2);
        }

      //  IUser<IdentityCard> IUserFactory<IUser<IdentityCard>, IdentityCard>.CreateUser(string name1, string name2)
      //      => CreateUser(name1, name2);
    }
}
