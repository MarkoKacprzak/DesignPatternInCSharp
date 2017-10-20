using System;

namespace DesignPattern.Mix.Appointments
{
    class RegistrantGroup :IRegistrantGroup, IUserGroupVisitor
    {
        private IUserGroup group;
        private string groupName;
        private string password;
        public RegistrantGroup(IUserGroup group, string groupName, string password)
        {
            this.group = group;
            this.groupName = groupName;
            this.password = password;
        }

     
        public void AddMember(IUser user)
        {
            group.AddMember(user);
        }

        public void ChangePassword(string newPassword)
        {
            Console.WriteLine($"Changing '{groupName}' group password " +
                $"from '{password}' to '{newPassword}'");
            this.password = newPassword;
        }

        public void Register()
        {
            Console.WriteLine($"Registering group '{groupName}' with password '{password}'");
            this.group.Accept(() => this);
        }

        public void Accept(Func<IUserGroupVisitor> visitorFactory)
        {
            this.group.Accept(visitorFactory);
        }
        public void VisitUser(string name)
        {
            Console.WriteLine($"\tAssociating {name} with group '{groupName}'");
        }
    }
}
