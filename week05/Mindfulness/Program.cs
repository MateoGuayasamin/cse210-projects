using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        string option = "";

        while(option != "4")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1.Start breathing activity");
            Console.WriteLine("2.Start Reflecting activity");
            Console.WriteLine("2.Start Listing activity");
            Console.WriteLine("4.Quit");
            Console.WriteLine("Select a choise from menu:");
            option = Console.ReadLine();
            if(option == "1")
            {
                BreathingActivity act1 = new BreathingActivity("Breating Activity", "this activty is cool");
                act1.Run();
            }
            else if(option == "2")
            {
                ReflectingActivity act2 = new ReflectingActivity("Reflecting activity","THIS ACTIVITY IS COOL ");
                act2.Run();
            }

        }
    }
}