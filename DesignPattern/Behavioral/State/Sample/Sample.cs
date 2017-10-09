namespace DesignPattern.Behavioral.State.Sample
{
    /// <summary>
    /// MainApp startup class for Real-World 
    /// State Design Pattern.
    /// </summary>
    public class Sample:ISample
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public void Run()
        {
            // Open a new account
            var account = new Account("Jim Johnson");

            // Apply financial transactions
            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(2000.00);
            account.Withdraw(1100.00);
        }
    }
}
