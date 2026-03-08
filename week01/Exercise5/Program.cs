using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        int PromptUserNumber()
        {
            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            return number;
        }
        int SquareNumber (int number)
        {
            number = number * number;
            return number;
        }

        DisplayWelcome();
        string UserName =PromptUserName();
        int userNumber = PromptUserNumber();
        int squared = SquareNumber(userNumber);
        Console.WriteLine($"{UserName}, the square of your number is {squared}");
    }
}