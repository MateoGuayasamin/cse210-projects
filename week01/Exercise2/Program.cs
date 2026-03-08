using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your score? ");
        string scoreInput = Console.ReadLine();
        int score = int.Parse(scoreInput); 
        String letter = "";
        
        if (score >= 90)
        {
            letter = "A";
        }
        else if (score >= 80)
        {
            letter = "B";               
        }
        else if (score >= 70)
        {
            letter = "C";
        }
        else if (score >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";   
        }
        
        if (score >= 70)
        {
            Console.WriteLine($"Congratulations! Your grade is {letter}. You passed the course.");
        }
        else
        {
            Console.WriteLine($"Unfortunately, you did not pass the course. Your grade is {letter}. Better luck next time!");
        }
      

    
    }
}