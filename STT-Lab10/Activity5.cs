using System;

namespace BasicCalcWithExceptionHandling
{
    class Calculator
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double sum = num1 + num2;
                double difference = num1 - num2;
                double product = num1 * num2;
                double quotient = num2 != 0 ? num1 / num2 : throw new DivideByZeroException();

                Console.WriteLine($"Sum: {sum}");
                Console.WriteLine($"Difference: {difference}");
                Console.WriteLine($"Product: {product}");
                Console.WriteLine($"Quotient: {quotient}");

                if (((int)sum) % 2 == 0)
                    Console.WriteLine("The sum is even.");
                else
                    Console.WriteLine("The sum is odd.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter numeric values.");
            }
        }
    }
}

