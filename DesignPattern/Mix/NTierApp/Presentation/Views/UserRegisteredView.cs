using System;
using DesignPattern.Mix.NTierApp.Presentation.Implementation.CommandResults;
using DesignPattern.Mix.NTierApp.Presentation.Interfaces;

namespace DesignPattern.Mix.NTierApp.Presentation.Views
{
    public class UserRegisteredView: IView
    {

        private UserRegistered Data { get; }

        public UserRegisteredView(UserRegistered data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            Data = data;
        }

        public void Render()
        {
            Console.WriteLine($"User {Data.Username} is now registered.");
        }
    }
}
