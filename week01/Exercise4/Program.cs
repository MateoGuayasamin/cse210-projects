using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();

         
        int number = -1;
        
        do
        {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        number = int.Parse(input);
        numbers.Add(number);
        }while (number != 0);

        int totalSum = 0;
        float average = 0;
        int max = numbers[0];
        
        foreach (int num in numbers)
        {
            totalSum += num;
            average = (float)totalSum / numbers.Count;
            if(num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"The sum is {totalSum}");  
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The maximum is {max}");

        
       
    }
}    