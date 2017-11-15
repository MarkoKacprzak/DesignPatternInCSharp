using Substitution.Factories.Interfaces;
using Substitution.Interfaces;
using Substitution.Models;

namespace Substitution.Factories.Person
{
    public class PersonFactory: IUserFactory
    {
        public IUser CreateUser(string name1, string name2)
        {
            return new Models.Person(name1, name2);
        }

        public IUserIdentity CreateIdentity()
        {
            return new IdentityCard();
        }
    }
}
