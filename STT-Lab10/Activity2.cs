using System;
class Calculator {
    static void Main() {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2;
        Console.WriteLine($"Sum: {sum}");

        if (sum % 2 == 0) 
            Console.WriteLine("Sum is even.");
        else 
            Console.WriteLine("Sum is odd.");
    }
}
