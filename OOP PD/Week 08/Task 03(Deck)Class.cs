using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class Deck
    {
        private List<Card> Cards;

        public Deck()
        {
            Cards = new List<Card>();
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    Card card = new Card(i, j);
                    Cards.Add(card);
                }
            }
        }
        public void ShuffleCards()
        {
            Random random = new Random();
            for (int i = 0; i < Cards.Count; i++)
            {
                int j = random.Next(i, Cards.Count);
                Card temp = Cards[i];
                Cards[i] = Cards[j];
                Cards[j] = temp;
            }
        }
        public int CardsLeft()
        {
            return Cards.Count;
        }
        public Card DealCard()
        {
            if (Cards.Count > 0)
            {
                Card card = Cards[0];
                Cards.RemoveAt(0);
                return card;
            }
            return null;
        }
    }
}
