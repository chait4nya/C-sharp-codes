using System;
class FirstProject
{
    static void Main()
    {
        Console.Write("Enter 1st no: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter 2nd no: ");
        int num2 = int.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine("Num 1 which is " + num1 + " is bigger than Num 2 which is " + num2);
        }
        else if (num2 > num1)
        {
            Console.WriteLine("Num 2 which is " + num2 + " is bigger than Num 1 which is " + num1);
        }
        else
        {
            Console.WriteLine("Both numbers are equal.");
        }
    }
}
