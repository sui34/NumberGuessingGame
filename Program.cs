using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class program
    {
        static void Main(string[] args)
        {
            //when you want to generate "random" number
            Random r = new Random();

            int winNum = r.Next(0, 100);

            bool win = false;

            do
            {
                Console.Write("Guess a number inbetween 0 and 100 : ");

                string s = Console.ReadLine();
                //when you want to convert "s" to "i"
                int i = int.Parse(s);

                if (i > winNum)
                {
                    Console.WriteLine("Too High!! Guess Lower ....");
                }
                else if (i < winNum)
                {
                    Console.WriteLine("Too Low!! Guess Higher ....");
                }
                else if (i == winNum)
                {
                    Console.WriteLine("Brilliant!! Congratulation!!");
                    win = true;
                }
                Console.WriteLine();
            } while (win == false);

            Console.WriteLine("You have done well!!!");
            Console.Write("Press any key to finish...");
            Console.ReadKey(true);


        }
    }
}
