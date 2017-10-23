using System;
using System.Collections.Generic;
using System.Linq;
using DesignPattern.Mix.NTierApp.Presentation.Interfaces;
using DesignPattern.Mix.NTierApp.Presentation.Implementation.Commands;

namespace DesignPattern.Mix.NTierApp.Presentation.Implementation
{
    public class UserInterface: IUserInterface
    {

        private readonly IApplicationServices appServices;
        private ICommand currentCommand = new DoNothingCommand();
        private readonly IEnumerable<MenuItem> menu;

        public UserInterface(IApplicationServices appServices)
        {

            this.appServices = appServices;

            menu = new MenuItem[]
            {
                MenuItem.CreateNonTerminal("Register new user", 'R', new RegisterCommand(appServices), () => true),
                MenuItem.CreateNonTerminal("Login", 'L', new LoginCommand(appServices), () => true),
                MenuItem.CreateNonTerminal("LogOut", 'O', new LogoutCommand(appServices), () => appServices.IsUserLoggedIn),
                MenuItem.CreateNonTerminal("Deposit", 'D', new DepositCommand(appServices), () => appServices.IsUserLoggedIn),
                MenuItem.CreateNonTerminal("Purchase", 'P', new PurchaseCommand(appServices), () => true),
                MenuItem.CreateTerminal("Quit", 'Q')
            };

        }

        public bool ReadCommand()
        {

            RefreshDisplay();

            var selectedMenuItem = SelectMenuItem();

            if (selectedMenuItem.IsTerminalCommand)
                return false;

            currentCommand = selectedMenuItem.Command;
            return true;

        }

        private void RefreshDisplay()
        {
            Console.Clear();
            ShowStatus();
            ShowMenu();
        }

        public void ExecuteCommand()
        {
            
            currentCommand.Execute();

            Console.WriteLine();
            Console.Write("Press ENTER to continue...");
            Console.ReadLine();

        }

        private void ShowStatus()
        {
            
            Console.Write("Logged in user: ");
            Highlight(this.LoggedInUserDisplay);
            Console.WriteLine();

            Console.Write("       Balance: ");
            Highlight(BalanceDisplay);
            Console.WriteLine();

            Console.WriteLine();

        }

        private string LoggedInUserDisplay
        {
            get
            {
                if (appServices.IsUserLoggedIn)
                    return appServices.LoggedInUsername;
                return "none";
            }
        }

        private string BalanceDisplay
        {
            get
            {
                if (appServices.IsUserLoggedIn)
                    return appServices.LoggedInUserBalance.ToString("C");
                return "N/A";
            }
        }

        private void Highlight(string message)
        {
            var prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(message);
            Console.ForegroundColor = prevColor;
        }

        private void ShowMenu()
        {
            
            Console.WriteLine("Select operation:");
            Console.WriteLine();

            foreach (var menuItem in menu)
                menuItem.Display();

            Console.WriteLine();

        }

        private MenuItem SelectMenuItem()
        {

            var key = Console.ReadKey(true);

            var selectedItem = menu.Single(item => item.MatchesKey(key.KeyChar));

            return selectedItem;

        }
    }
}
