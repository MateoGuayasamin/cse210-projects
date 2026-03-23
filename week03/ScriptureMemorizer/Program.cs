using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference = new Reference("Jhon",14,15);
        
        string text = "Fíate de Jehová de todo tu corazón y no te apoyes en tu propia prudencia";
        Scripture scripture = new Scripture(reference, text);
        string input = "";

        while (input.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplay());
            Console.WriteLine();
            Console.WriteLine("Presiona Enter para ocultar palabras o escribe 'quit' para salir:");

            input = Console.ReadLine();
            if (input.ToLower() != "quit")
            {
               
                scripture.HideRandomWords(3);
            }
        Console.Clear();
        Console.WriteLine(scripture.GetDisplay());
        Console.WriteLine("\n¡Programa finalizado!");
        }
    }    
}