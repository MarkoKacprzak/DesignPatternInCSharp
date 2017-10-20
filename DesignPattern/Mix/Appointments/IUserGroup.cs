using System;

namespace DesignPattern.Mix.Appointments
{
    interface IUserGroup
    {
        void AddMember(IUser user);
        void Accept(Func<IUserGroupVisitor> visitorFactory);
    }
}
