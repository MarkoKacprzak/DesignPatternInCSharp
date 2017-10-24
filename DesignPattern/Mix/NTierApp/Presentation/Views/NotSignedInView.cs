using System;
using DesignPattern.Mix.NTierApp.Presentation.Interfaces;

namespace DesignPattern.Mix.NTierApp.Presentation.Views
{
    public class NotSignedInView: IView
    {
        public void Render()
        {
            Console.WriteLine("No user is signed in.");
        }
    }
}
