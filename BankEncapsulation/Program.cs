namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {

            BankAccount userAccount = new BankAccount();
            BankPin userPin = new BankPin();


            bool validDeposit;
            bool validWithdraw;
            bool isCorrect;


            int userChoice = 0;

            double userDeposit;
            double userWithdraw;
            double currentBalance;



            //On run - the user will set a valid pin number.

            userPin.NewPin();

            //Then greet the user.

            while (userChoice != 4)
            {
                userChoice = userAccount.Greeting();

                if (userChoice == 4)
                {
                    Console.WriteLine("Have a good day!");
                    System.Environment.Exit(0);
                }
                else
                    
                {
                    isCorrect = userPin.EnterPin();

                    if (isCorrect == true)
                    {
                        if (userChoice == 4)
                        {
                            Console.WriteLine("Have a good day!");
                            System.Environment.Exit(0);
                        }
                        else if (userChoice == 1)

                        {
                            Console.WriteLine($"Your balance is {userAccount.GetBalance()}");
                            
                        }
                        else if (userChoice == 2)
                        {
                            Console.WriteLine("How much do you want deposit?");
                            validDeposit = Double.TryParse(Console.ReadLine(), out userDeposit);


                            while (!validDeposit)
                            {
                                Console.WriteLine("Please enter a valid number for your deposit.");
                                validDeposit = Double.TryParse(Console.ReadLine(), out userDeposit);
                            }

                            userAccount.Deposit(userDeposit);
                           
                        }
                        else if (userChoice == 3)
                        {

                            Console.WriteLine("How much do you want withdraw?");
                            validWithdraw = Double.TryParse(Console.ReadLine(), out userWithdraw);

                            while (!validWithdraw)
                            {
                                Console.WriteLine("Please enter a valid number for your withdrawl.");
                                validWithdraw = Double.TryParse(Console.ReadLine(), out userWithdraw);
                            }

                            currentBalance = userAccount.GetBalance();

                            if (userWithdraw > currentBalance)
                            {
                                Console.WriteLine("Insufficient funds.");
                            }
                            else
                            {

                                userAccount.Withdraw(userWithdraw);
                                

                            }
                        }
                        else
                        {

                           

                        }
                    }



                }













            }
        }


    }







}
