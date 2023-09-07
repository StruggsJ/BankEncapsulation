using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {

        private double _balance = 0;
        

        public void Deposit (double ammount)
        {
            _balance += ammount;
        }

        public void Withdraw(double amount)
        {
            _balance -= amount;
        }

        public double GetBalance () 
        {
            return _balance; 
        }

        public int Greeting ()
        {
            int userChoice;
            bool validChoice = true;

            Console.WriteLine("How can I help you today?");
            Console.WriteLine("1. Show Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Exit");
            Console.WriteLine("");

            validChoice = Int32.TryParse(Console.ReadLine(), out userChoice);
            

            while (!validChoice || userChoice > 4 || userChoice == 0)
            {
                Console.WriteLine("Invalid input.");
                Console.WriteLine("");

                Console.WriteLine("How can I help you today?");
                validChoice = Int32.TryParse(Console.ReadLine(), out userChoice);
            }

            return userChoice;
        }

    }
}
