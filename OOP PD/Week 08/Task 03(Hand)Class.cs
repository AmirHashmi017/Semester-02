using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class Hand
    {
        protected List<Card> Cards;
        public Hand()
        {
            Cards = new List<Card>();
    
    }
        public void Clear()
        {
            Cards.Clear();
        }
        public void AddCard(Card c)
        {
            if (c != null)
            {
                Cards.Add(c);
            }
        }
        public void RemoveCard(Card c)
        {
            for (int i = 0; i < Cards.Count; i++)
            {
                if (Cards[i] == c)
                {
                    Cards.RemoveAt(i);
                }
            }
        }
        public void RemoveCard(int position)
        {
            if (position >= 0 && position <= Cards.Count)
            {
                Cards.RemoveAt(position);
            }
        }
        public int GetCardCount()
        {
            return Cards.Count;
        }
        public Card GetCard(int position)
        {
            if (position >= 0 && position <= Cards.Count)
            {
                return Cards[position];
            }
            return null;
        }
        public void SortByValue()
        {
            Cards=Cards.OrderBy(o => o.GetValue()).ToList();
        }
        public void SortBySuit()
        {
            Cards = Cards.OrderBy(o => o.GetValue()).ToList();
        }
    }
}
