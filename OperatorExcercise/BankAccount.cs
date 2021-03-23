using System;
namespace OperatorExcercise
{
    public class BankAccount
    {
        public BankAccount()
        {
        }

        //Fields
        private double _balance = 0;

        public void Deposit(double amount)
        {
            _balance += amount;  // _balance = _balance + amount;
        }

        public void GetBalance()
        {
            Console.WriteLine($"Account Balance: {_balance}");
        }

    }
}
