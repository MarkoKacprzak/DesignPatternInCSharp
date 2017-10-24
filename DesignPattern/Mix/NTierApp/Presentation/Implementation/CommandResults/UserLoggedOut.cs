using DesignPattern.Mix.NTierApp.Presentation.Interfaces;

namespace DesignPattern.Mix.NTierApp.Presentation.Implementation.CommandResults
{
    public class UserLoggedOut: ICommandResult
    {
        public string Username { get; }

        public UserLoggedOut(string username)
        {
            Username = username ?? string.Empty;
        }
    }
}
