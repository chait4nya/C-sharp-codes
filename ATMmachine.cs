using System;
class FirstProject
{
    static void Main()
    {
        const int pin = 1234;
        int attempts = 0;
        const int maxAttempts = 3;
        double balance = 1000;

        while (attempts < maxAttempts)
        {
            Console.Write("Please enter a 4-digit PIN.");
            string pinInput = Console.ReadLine();
            int enteredPin;

            if (!int.TryParse(pinInput, out enteredPin))
            {
                Console.WriteLine("Invalid input. Please enter a 4-digit number.");
                continue;
            }

            if (enteredPin == pin)
            {
                Console.WriteLine("Pin was correct. Welcome in the ATM!");
                break;
            }
            else
            {
                Console.WriteLine("Incorrect Pin.");
                attempts++;
            }
            if (attempts >= maxAttempts)
            {
                Console.WriteLine("Too many Incorrect attempts. Your card is blocked");
                return;
            }
        }
        bool running = true;
        while (running)
        {
            Console.WriteLine("===Welcome To the ATM!===");
            Console.WriteLine("1. Check Balance.");
            Console.WriteLine("2. Deposit.");
            Console.WriteLine("3. Withdraw.");
            Console.WriteLine("4. Exit!");
            Console.Write("Choose an option (1-4): ");

            string choice = Console.ReadLine();
            int option;

            if (!int.TryParse(choice, out option))
            {
                Console.WriteLine("Invalid Input. Please enter a no between 1-4");
                continue;
            }
            switch (option)
            {
                case 1:
                    Console.WriteLine("Your current Balance is: " + balance);
                    break;

                case 2:
                    Console.Write("Enter the amount to deposit: ");
                    string enteredAmount = Console.ReadLine();
                    double depositAmount;

                    if (!double.TryParse(enteredAmount, out depositAmount))
                    {
                        Console.WriteLine("Invalid amount. Must be positive. ");
                        break;
                    }
                    else if (depositAmount > 0)
                    {
                        balance += depositAmount;
                        Console.WriteLine(enteredAmount + " deposited. New balance: " + balance);
                    }

                    else if (depositAmount <= 0)
                    {
                        Console.WriteLine("Amount should be positive.");
                    }
                    break;

                case 3:
                    Console.Write("Enter the amount you want to withdraw: ");
                    string withdrawAmount = Console.ReadLine();
                    double withdraw;

                    if (!double.TryParse(withdrawAmount, out withdraw))
                    {
                        Console.WriteLine("Invalid Input. The amount should be in numbers.");
                        break;
                    }
                    if (withdraw > balance)
                    {
                        Console.WriteLine("Insufficient funds.");
                        break;
                    }
                    if (withdraw > 0)
                    {
                        balance -= withdraw;
                        Console.WriteLine("Withdrew " + withdraw + " . " + " New Balance: " + balance);
                    }
                    else
                    {
                        Console.WriteLine("Amount should be positive.");
                    }
                    break; 

                case 4:
                    Console.WriteLine("Thank you for using the ATM. Bye!");
                    running = false;
                    return;

                default:
                    Console.Write("Select a no between 1-4.");
                    break;
            }
        }
    }
}
