using System;

class firstProject
{
        static int add (int a, int b){
            return a + b;
        }
        static int sub (int a, int b)
        {
            return a - b;
        }
        static double div (int a, int b)
        {
            return (double)a / b;
        }
        static int multiply (int a, int b)
        {
            return a * b;
        }

    static void Main()
    {
        Console.Write("Enter 1 st no: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter 2nd no: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter a operator: +, -, *, / : " );
        string Choice = Console.ReadLine();

        double result = 0;

        if (Choice == "+")
        {
            result = add(num1, num2);
        }
        else if (Choice == "-")
        {
            result = sub(num1, num2);
        }
        else if (Choice == "*")
        {
            result = multiply(num1, num2);
        }
        else if (Choice == "/")
        {
            result = div(num1, num2);
        }
        else
            Console.WriteLine("Invalid Choice!");

        Console.WriteLine("Result = " + result);
    }
}