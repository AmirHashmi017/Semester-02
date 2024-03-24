using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class Card
    {
        private int Suit;
        private int Value;

        public Card(int suit, int value)
        {
            this.Suit = suit;
            this.Value = value;
        }
        public int GetSuit()
        {
            return Suit;
        }
        public int GetValue()
        {
            return Value;
        }
        public string GetSuitAsString()
        {
            if (Suit == 1)
                return "Clubs";
            else if (Suit == 2)
                return "Diamonds";
            else if (Suit == 3)
                return "Spades";
            else if (Suit == 4)
                return "Hearts";
            return " ";
        }
        public string GetValueAsString()
        {
            if (Value == 1)
                return "Ace";
            else if (Value == 11)
                return "Jack";
            else if (Value == 12)
                return "Queen";
            else if (Value == 13)
                return "King";
            return Value.ToString();
        }
        public string To_String()
        {
            return GetValueAsString() + " of " + GetSuitAsString();
        }
    }
}

