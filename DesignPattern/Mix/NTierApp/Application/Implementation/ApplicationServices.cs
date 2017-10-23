using DesignPattern.Mix.NTierApp.Application.Interfaces;
using DesignPattern.Mix.NTierApp.Presentation.Interfaces;
using System;
using System.Collections.Generic;

namespace DesignPattern.Mix.NTierApp.Application.Implementation
{
    public class ApplicationServices: IApplicationServices
    {

        private readonly IDomainServices domainServices;
        private string loggedInUsername;

        public ApplicationServices(IDomainServices domainServices)
        {
            this.domainServices = domainServices;
            this.loggedInUsername = string.Empty;
        }

        public void RegisterUser(string username)
        {
            domainServices.CreateUser(username);
        }

        public bool Login(string username)
        {   
            bool loggedIn = this.domainServices.IsRegistered(username);

            if (loggedIn)
                loggedInUsername = username;

            return loggedIn;
        }

        public bool IsUserLoggedIn=> !string.IsNullOrEmpty(this.loggedInUsername);

        public string LoggedInUsername
        {
            get
            {
                AssertUserLoggedIn();
                return loggedInUsername;
            }
        }

        public void Logout()
        {
            loggedInUsername = string.Empty;
        }

        public void Deposit(decimal amount)
        {
            AssertUserLoggedIn();
            domainServices.Deposit(this.loggedInUsername, amount);
        }

        public decimal LoggedInUserBalance
        {
            get
            {
                AssertUserLoggedIn();
                return domainServices.GetBalance(this.loggedInUsername);
            }
        }

        private void AssertUserLoggedIn()
        {
            if (!IsUserLoggedIn)
                throw new InvalidOperationException("No user logged in.");
        }

        public IEnumerable<StockItem> GetAvailableItems() => domainServices.GetAvailableItems();

        public Receipt Purchase(string itemName)
        { 
            if (!IsUserLoggedIn)
                return null;
            
            return domainServices.Purchase(this.loggedInUsername, itemName);
        }
    }
}
