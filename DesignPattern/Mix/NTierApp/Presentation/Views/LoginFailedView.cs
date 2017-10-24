using System;
using DesignPattern.Mix.NTierApp.Presentation.Implementation.CommandResults;
using DesignPattern.Mix.NTierApp.Presentation.Interfaces;

namespace DesignPattern.Mix.NTierApp.Presentation.Views
{
    public class LoginFailedView: IView
    {

        private LoginFailed Data { get; }

        public LoginFailedView(LoginFailed data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            Data = data;
        }

        public void Render()
        {
            Console.WriteLine($"Login failed for user {Data.Username}.");
        }
    }
}
