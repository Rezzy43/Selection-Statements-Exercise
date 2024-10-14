using System.ComponentModel;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Set the favorite number to 42
            int favNumber = 42;
            
            Console.WriteLine("Try to guess my favorite number:");
            int userInput;

            // Loop until the user guesses the corret number
            while (true)
            {
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine("Too Low!");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("Too High!");
                }
                else
                {
                    Console.WriteLine("You guessed it!!!");
                    break; // Exit the loop if guessed correctly
                }
            }
        }
    }
}
