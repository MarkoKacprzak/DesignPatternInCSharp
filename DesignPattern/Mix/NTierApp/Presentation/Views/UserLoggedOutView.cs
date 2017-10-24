using System;
using DesignPattern.Mix.NTierApp.Presentation.Implementation.CommandResults;
using DesignPattern.Mix.NTierApp.Presentation.Interfaces;

namespace DesignPattern.Mix.NTierApp.Presentation.Views
{
    public class UserLoggedOutView: IView
    {

        private UserLoggedOut Data { get; }

        public UserLoggedOutView(UserLoggedOut data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            Data = data;
        }

        public void Render()
        {
            Console.WriteLine($"User {Data.Username} logged out.");
        }
    }
}
