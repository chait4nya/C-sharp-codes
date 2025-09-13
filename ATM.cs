using System;
class FirstProject
{
    static void Main()
    {
        const int pin = 1234;
        double balance = 1000.0;
        int attempts = 0;
        const int attemptsPin = 3; 

        while (attempts < attemptsPin)
        {
            Console.Write("Enter your 4 digit atm PIN: ");
            string pinInput = Console.ReadLine();
            int enteredPin;

            if(!int.TryParse(pinInput, out enteredPin))
            {
                Console.WriteLine("Pin must be in Number format. ");
                attempts++;
                continue;
            }
            else if (enteredPin == pin)
            {
                Console.WriteLine("Login  successful! \n");
                break;
            }
            else
            {
                Console.WriteLine("Incorrect pin");
                attempts++;
            }
            if ( attempts == attemptsPin)
            {
                Console.WriteLine("Too many wrong attemots. Card blocked! ");
                return;
            }
        }

        bool running = true;
        while (running)
        {
            Console.WriteLine("--ATM menu--");
            Console.WriteLine("1: Check Balance");
            Console.WriteLine("2: Deposit");
            Console.WriteLine("3: Withdraw");
            Console.WriteLine("4: Exit");
            Console.Write("Choose an option: ");

            string choiceInput = Console.ReadLine();
            int choice;

            if (!int.TryParse(choiceInput, out choice))
            {
                Console.WriteLine("Invalid Choice. Enter no bw 1-4! ");
                continue;
            }
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Your balance is: " + balance);
                    break;

                case 2:
                    Console.Write("Enter the amount you want to deposit: ");
                    if (double.TryParse(Console.ReadLine(), out double depositAmount))
                    {
                        balance += depositAmount;
                        Console.WriteLine("Deposited amount which is " + depositAmount + " is added to the total balance that is: " + balance);
                    }
                    else
                    {
                        Console.WriteLine("Deposited ammount should be positive. ");
                    }
                    break;

                case 3:
                    Console.Write("Enter the amount which you want to withdraw: ");
                    if (double.TryParse(Console.ReadLine(), out double withdrawAmount))
                    {
                        if (withdrawAmount > balance)
                        {
                            Console.WriteLine("Insufficient Balance");
                        }
                        else if (withdrawAmount <= 0)
                        {
                            Console.WriteLine("Withdrawal must be positive.");
                        }
                        else
                        {
                            balance -= withdrawAmount;
                            Console.WriteLine(withdrawAmount + " is withdrawn, now the total balance is " + balance);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Amount. ");
                    }
                    break;

                case 4:
                    Console.Write("Thank you for using the ATM. ");
                    running = false;
                    break;

                default:
                    Console.Write("Please select the no between 1 and 4: \n");
                    Console.Write("Please select the no between 1 and 4: \n");
                    break;
            
            }

        }
    }
}
