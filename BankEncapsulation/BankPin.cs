using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankPin
    {

        private int _accountPin;

        public void NewPin ()
        {
            int inputPin;
            bool validInputPin;
            bool validPin = true;

            Console.WriteLine("Thank you for creating a new account. Please enter your new four digit pin number for your account.");
            validInputPin = Int32.TryParse(Console.ReadLine(), out inputPin);

            while (!validInputPin || !validPin) 
            {
                Console.WriteLine("Please enter a valid four digit pin");
                validInputPin = Int32.TryParse(Console.ReadLine(), out inputPin);
            }

            validPin = ValidPin(inputPin);

            if (validPin == true)
            {
                _accountPin = inputPin;
                Console.WriteLine("Pin set!");
            }
           

        }
        public bool EnterPin ()
        {
            int inputPin;
            bool validInputPin;
            bool isCorrectPin;
            
            Console.WriteLine("Please enter your four digit pin number for your account.");
            validInputPin = Int32.TryParse(Console.ReadLine(), out inputPin);

            while (!validInputPin) 
            {
                Console.WriteLine("Please enter a valid four digit pin");
                validInputPin = Int32.TryParse(Console.ReadLine(), out inputPin);
            }

            isCorrectPin = CheckPin(inputPin);

            while(!isCorrectPin) 
            {
                Console.WriteLine("Incorrect Pin. Please enter your four digit pin number for your account.");
                validInputPin = Int32.TryParse(Console.ReadLine(), out inputPin);
                
                if (isCorrectPin == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (isCorrectPin == true)
            {
                return true;
            }
            else
            { 
                return false;  
            }
            

        }

        private static bool ValidPin (int pin)
        {
            int number = pin; 
            int count = 0;  

            while (number > 0)
            {
                number = number / 10;
                count++;
            }

            if (count == 4)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        private bool CheckPin (int pin)
        {
         if (pin  == _accountPin)
            {
                return true;
            }
         else 
            {
                return false; 
            }

        }



    }
}
