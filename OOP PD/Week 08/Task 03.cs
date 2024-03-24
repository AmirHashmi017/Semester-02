using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task_02
{
    internal class Program
    {
        static Deck deck = new Deck();
        static void Main(string[] args)
        {
            
            deck.ShuffleCards();
            BlackJackHand player = new BlackJackHand();
            BlackJackHand dealer = new BlackJackHand();

            player.AddCard(getCard());

            Card dealerCardToShow = getCard();
            dealer.AddCard(dealerCardToShow);

            player.AddCard(getCard());
            dealer.AddCard(getCard());
            if (getHandValue(player) == 21)
            {
                Console.WriteLine("Player Wins!!!");
                goto end;
            }
            while (true)
            {
                Console.WriteLine($"Dealer Card Value: {dealerCardToShow.GetValue()}");
                Console.WriteLine("Player Turn");
                Console.WriteLine($"Current Hand Value: {getHandValue(player)}");

                int choice = getInput();

                if (choice == 0)
                {
                    player.AddCard(getCard());
                    if (getHandValue(player) > 21)
                    {
                        Console.WriteLine("Player Bust");
                        Console.WriteLine("Dealer Wins!!!");
                        goto end;
                    }
                }      
         else
                {
                    break;
                }
            }
            while (true)
            {
                Console.WriteLine("Dealer Turn");
                Console.WriteLine($"Current Hand Value: {getHandValue(dealer)}");

                if (getHandValue(dealer) < 17)
                {
                    dealer.AddCard(getCard());
                    if (getHandValue(dealer) > 21)
                    {
                        Console.WriteLine("Dealer Bust");
                        Console.WriteLine("Player Wins!!!");
                        goto end;
                    }
                }
                else
                {
                    break;
                }
            }
            if (getHandValue(dealer) > getHandValue(player))
            {
                Console.WriteLine("Dealer Wins!!!");
            }
            else if (getHandValue(dealer) == getHandValue(player))
            {
                Console.WriteLine("Draw");
            }
            else
            {
                Console.WriteLine("Player Wins!!!");
            }
        end:
            Console.ReadKey();
        }
        static int getHandValue(BlackJackHand hand)
        {
            return hand.GetBlackJackValue();
        }
        static Card getCard()
        {
            return deck.DealCard();
        }
        static int getInput()
        {
            Console.Write("Hit(0) or Stand(1): ");
            int input = int.Parse(Console.ReadLine());
            return input;
        }
    }
}

