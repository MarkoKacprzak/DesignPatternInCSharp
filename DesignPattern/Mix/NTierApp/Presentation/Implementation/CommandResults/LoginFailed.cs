using DesignPattern.Mix.NTierApp.Presentation.Interfaces;

namespace DesignPattern.Mix.NTierApp.Presentation.Implementation.CommandResults
{
    public class LoginFailed: ICommandResult
    {
        public string Username { get; }

        public LoginFailed(string username)
        {
            Username = username ?? string.Empty;
        }
    }
}
