using System;
class LoopsFunctions {
    static void Main() {
        // For loop (1-10)
        for (int i = 1; i <= 10; i++) 
            Console.WriteLine(i);

        // While loop (exit condition)
        string input = "";
        while (input != "exit") {
            Console.Write("Enter a word (type 'exit' to quit): ");
            input = Console.ReadLine();
        }

        // Factorial function
        Console.Write("Enter a number for factorial: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Factorial: {Factorial(num)}");
    }

    static int Factorial(int n) {
        if (n == 0) return 1;
        return n * Factorial(n - 1);
    }
}
