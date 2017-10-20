using System;
using System.Linq;

namespace DesignPattern.Mix.Appointments
{
    class UserGroup : IUserGroup
    {
        IUser[] members = new IUser[0];

        public void Accept(Func<IUserGroupVisitor> visitorFactory)
        {
            var visitor = visitorFactory();
            foreach (var user in members)
                user.Accept(() => visitor);
        }

        public void AddMember(IUser user)
        {
            var list = members.ToList();
            list.Add(user);
            members = list.ToArray();
        }
    }
}
