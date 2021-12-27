using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_a_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 20;
            int guess_number;
            int number;
            int guesses;
            String Response;
            Console.WriteLine("I am thinking of a number between 1-20, can you guess it?");
            Console.WriteLine("Enter your Number:");
            while (playAgain)
            {
                guess_number = 0;
                guesses = 0;
                number = random.Next(min, max + 1);
                Response = "";


                while (guess_number != number)
                {


                    guess_number = Convert.ToInt32(Console.ReadLine());

                    if (guess_number < number)
                    {
                        Console.WriteLine("The number I'm thinking of is higher than that, guess again");
                        Console.WriteLine("Enter another guess:");
                    }
                    else if (guess_number > number)
                    {
                        Console.WriteLine("The number I'm thinking of is lower than that, guess again");
                        Console.WriteLine("Enter another guess:");


                    }
                    guesses++;
                }
                Console.WriteLine("The number I was thinking of was " + number + "!");
                Console.WriteLine("You win!");
                Console.WriteLine(guesses);
                Console.WriteLine("Would you like to play again? Answer with yes or no.");
                Response = Console.ReadLine();
                if (Response == "yes")
                {
                    Console.Write("Ok, lets go!");
                    playAgain = true;


                }

                else
                {
                    Console.WriteLine("Thanks for playing");
                    playAgain = false;
                }
            }
            Console.ReadKey();
        }
    }
}