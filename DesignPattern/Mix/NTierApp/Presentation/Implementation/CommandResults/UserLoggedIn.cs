using DesignPattern.Mix.NTierApp.Presentation.Interfaces;

namespace DesignPattern.Mix.NTierApp.Presentation.Implementation.CommandResults
{
    public class UserLoggedIn: ICommandResult
    {
        public string Username { get; }
        public decimal Balance { get; }

        public UserLoggedIn(string username, decimal balance)
        {
            Username = username ?? string.Empty;
            Balance = balance;
        }
    }
}
