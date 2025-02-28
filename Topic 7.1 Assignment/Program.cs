using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace Topic_7._1_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programming assignment part 1 - Average numbers in a loop

            double average;
            double total = 0;
            int count = 0;
            int numbers = 4;
            double input;

            Console.WriteLine("You will be prompted to enter 4 numbers and I will calculate the average.");
            while (count < numbers)
            {
                Console.Write("Please enter a number. ");
                Double.TryParse(Console.ReadLine(), out input);
                total += input;
                count++;
            }
            Console.WriteLine();
            Console.WriteLine("Your average is " + (total / 4));
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();

            //Programming assignment part 2 - Hi Low with Limited Tries
            Random generator = new Random();
            bool done = false;

            int randNum;
            int userGuess = 0;
            int tries = 0;

            randNum = generator.Next(1, 101);

            Console.Write("Try to guess a number from 1-100: ");
            userGuess = Convert.ToInt32(Console.ReadLine());

            tries++;
            while (!done)
            {
                Console.Write("Try again. Enter another number here: ");
                while (!int.TryParse(Console.ReadLine(), out userGuess)) ;
                Console.WriteLine();
                if (userGuess == randNum)
                {
                    Console.WriteLine("Congrats! You guessed the number");
                    done = true;
                }
                else if (userGuess > randNum)
                {
                    Console.Write("Too high, Enter another number. ");
                    while (!int.TryParse(Console.ReadLine(), out userGuess)) ;
                }
                else
                {
                    Console.Write("Too low, Enter another number. ");
                    while (!int.TryParse(Console.ReadLine(), out userGuess)) ;
                }
                if (tries == 7 && userGuess != randNum)
                {
                    Console.WriteLine("Took too many tries, YOU LOSE!");
                    done = true;
                }
            }
        }
    }
}
