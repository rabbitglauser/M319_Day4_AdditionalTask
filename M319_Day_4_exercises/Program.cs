using System;
using Console = System.Console;
using Convert = System.Convert;

/* .
 Task one 
 
 class MainClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Give me your first number");
        string firstNumberInput = Console.ReadLine();
        
        Console.WriteLine("Give me your second number");
        string secondNumberInput = Console.ReadLine();

        // Check if the inputs are valid integers
        if (int.TryParse(firstNumberInput, out int firstNumber) && int.TryParse(secondNumberInput, out int secondNumber))
        {
            Console.WriteLine(secondNumber + firstNumber);
        }
        else
        {
            Console.WriteLine("One or both inputs are not valid integers.");
        }
    }
}*/

using System;

class OddOrEvenChecker
{
    public void CheckNumber()
    {
        Console.WriteLine("Type in a number to check if your number is even or odd:");
        string userInput = Console.ReadLine();

        if (int.TryParse(userInput, out int number))
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"The number {number} is even.");
            }
            else
            {
                Console.WriteLine($"The number {number} is odd.");
            }
        }
        else
        {
            Console.WriteLine("The input is not a valid number.");
        }
    }    
}