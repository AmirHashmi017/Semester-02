using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int noofgames = 0;
            double avgscore = 0;
            int score = 0;
            int finalscore = 0;
            string input;
            Deck d1 = new Deck();
            d1.ShuffleCards();
            Card nextcard = d1.DealCard();
            for (int i = 0; i < d1.CardsLeft() - 1; i++)
            {
                Console.Clear();
                    Card currentcard = nextcard;
                Console.WriteLine("Score: {0}", score);
                Console.WriteLine(currentcard.To_String());
                Console.Write(" Guess the next card is High or Low.Enter '1' For High and '0' For Low: ");
                input = Console.ReadLine();
                 nextcard = d1.DealCard();
                if (input == "1")
                {
                    if (nextcard.GetValue() >= currentcard.GetValue())
                    {
                        Console.WriteLine(" Congratulations!!  Correct Guess.");
        
                        score += 100;
                       Console.WriteLine("Now Your Score is: {0}", score);
                       Console.WriteLine(" Press any key to continue..");
                       Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine(" Wrong Guess. YOU LOST!!");
                        finalscore += score;
                        noofgames++;
                        score = 0;
                        Console.WriteLine("Now Your Score is: {0}", score);
                        Console.WriteLine(" Press any key to continue..");
                        Console.ReadKey();
                    }
                }
                else if (input == "0")
                {
                    if (nextcard.GetValue() <= currentcard.GetValue())
                    {
                        Console.WriteLine(" Congratulations!!  Correct Guess. \nYour Score is: {0}", score);
                        score += 100;
                        Console.WriteLine("Now Your Score is: {0}", score);
                        Console.WriteLine(" Press any key to continue..");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine(" Wrong Guess. YOU LOST!!");
                        finalscore += score;
                        noofgames++;
                        score = 0;
                        Console.WriteLine("Now Your Score is: {0}", score);
                        Console.WriteLine(" Press any key to continue..");
                        Console.ReadKey();
                    }
                }
            }
            Console.Clear();
            avgscore = (finalscore / noofgames);
            Console.WriteLine(" GAME OVER...\n Your Average Score is: {0}", avgscore);
            Console.ReadKey();
        }
    }
}
