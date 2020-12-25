using System;

namespace First_C_code
{
    class Program
    {
        static void Main(string[] args)
        {
            string app_name = "Guess the number";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(app_name);
            Console.ResetColor();
            Console.WriteLine("What's ur name");
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue; 
            Console.WriteLine("Hey {0}! Guess a number",name);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Clue: Number ranges from 0-10");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("You have 3 chances left !");
            int num = 0;
            int guessed = 7;
            int count = 0;
            int tries = 2;
            while(num != guessed)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Now Enter the number");
                Console.ResetColor();
                num = Convert.ToInt32(Console.ReadLine());
                
                if (num ==  guessed)
                {
                    Console.WriteLine("U won the game");
                    break;
                }
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("You have {0} chances left !", tries);
                Console.ResetColor();
                tries -= 1;
                count += 1 ; 
                if (count == 3)
                {
                    Console.WriteLine("U lost the game");
                    break;
                }
            }
        }
    }
}
