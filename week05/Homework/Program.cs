using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        MathAssigment assigment1 = new MathAssigment("Samuel Bennett","Multiplication","7.3", "8-19");
   
        Console.WriteLine(assigment1.GetHomeworkList());
    }
}