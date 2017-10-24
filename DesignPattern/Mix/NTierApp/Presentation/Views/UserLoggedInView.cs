using System;
using DesignPattern.Mix.NTierApp.Presentation.Implementation.CommandResults;
using DesignPattern.Mix.NTierApp.Presentation.Interfaces;

namespace DesignPattern.Mix.NTierApp.Presentation.Views
{
    public class UserLoggedInView: IView
    {
        private UserLoggedIn Data { get; }

        public UserLoggedInView(UserLoggedIn data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            Data = data;
        }

        public void Render()
        {
            Console.WriteLine($"User {Data.Username} logged in; {Data.Balance:C2} available");
        }
    }
}
