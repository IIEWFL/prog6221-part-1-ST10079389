using System;
namespace ST10079389_Kaushil_Dajee_PROG6221
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This is the entry point of the program.
            // It initializes a new instance of the RecipeBook class and calls its Menu_Options() method to display the options to the user.
            // The Console.ForegroundColor property is set to green to give a better visual experience to the user.
            Console.WriteLine("Welcome to the Royal Recipe Book!!");
            Console.ForegroundColor = ConsoleColor.Green;
            RecipeBook book = new RecipeBook();
            book.Menu_Options();
        }
    }
}
