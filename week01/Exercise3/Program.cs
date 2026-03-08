using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Whats the magic number?");
        string input = Console.ReadLine();
        int magicNumber = int.Parse(input);
        int guess = 0;
        do
        {
            
            Console.Write("What is your guess?");
            string guessInput = Console.ReadLine();
            guess = int.Parse(guessInput);
            if (guess > magicNumber)
            {
              Console.WriteLine("Lower");  
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
        } while (guess != magicNumber);

        Console.WriteLine("You guessed it!");

    }
}