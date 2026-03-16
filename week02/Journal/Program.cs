using System;
using System.Net;
using System.Threading.Tasks.Dataflow;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Project."); 
        string option = "";
        PrompGenerator myPrompgenerator = new PrompGenerator();
        myPrompgenerator._prompts.Add("Who was the most interesting person I interacted with today?");
        myPrompgenerator._prompts.Add("What was the best part of my day?");
        myPrompgenerator._prompts.Add("How did I see the hand of the Lord in my life today?");
        myPrompgenerator._prompts.Add("What was the strongest emotion I felt today?");

        Journal myJournal = new Journal();



        while (option != "5")
        {
            Console.WriteLine("Please, select one of the following choises:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do ?");
            option = Console.ReadLine();
            
            if (option == "5")
            {
                Console.WriteLine("¡Adiós! Gracias por escribir hoy.");
            }
            else if (option == "1")
            {
                string prompt = myPrompgenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                string response = Console.ReadLine();

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._prompText = prompt;
                entry._entrytext = response;

                myJournal._entries.Add(entry);

            }   
            else if (option == "2")
            {
                myJournal.DisplayAll();
            } 
            else if (option == "3")
            {
                Console.WriteLine("Whats the filename");
                string filename = Console.ReadLine();
                
                myJournal.LoadFromFile(filename);
                myJournal.DisplayAll();


            }
            else if (option =="4")
            {
                Console.WriteLine("Whats the filename");
                string filename = Console.ReadLine();
                
                myJournal.SaveToFile(filename);
                
                
                
            }
          
        }

        
        
        




        /*if ( Iwannado == 1)
        {
            Console.WriteLine(myPrompgenerator.GetRandomPrompt());
            response = Console.ReadLine();
            
        }
        else if (Iwannado == 5)
        {
            return;
        }
        else
        {
            Console.WriteLine("write something firstable");
            DisplayItemsToDo();
        }
        ;



        if ( Iwannado == 2)
        {
            entry.Display();
        }*/
        
        

        

        


        
        
        

       
        

        
    }
}