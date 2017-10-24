using DesignPattern.Mix.NTierApp.Presentation.Interfaces;

namespace DesignPattern.Mix.NTierApp.Presentation.Implementation.CommandResults
{
    public class UserRegistered: ICommandResult
    {
        public string Username { get; }

        public UserRegistered(string username)
        {
            Username = username ?? string.Empty;
        }
    }
}
