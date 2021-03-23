using System;

namespace OperatorExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount mine = new BankAccount();

            double deposit;

            Console.WriteLine("How much do you want to deposit?");

            deposit = double.Parse(Console.ReadLine());

            mine.Deposit(deposit);

            mine.GetBalance();


        }
    }
}
