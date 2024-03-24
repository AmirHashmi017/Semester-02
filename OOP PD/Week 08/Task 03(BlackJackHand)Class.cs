using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class BlackJackHand:Hand
    {
        public int GetBlackJackValue()
        {
            int value = 0;
            for (int i = 0; i < Cards.Count; i++)
            {
                if (Cards[i].GetValue() != 1)
                {
                    if (Cards[i].GetValue() == 11 || Cards[i].GetValue() == 12 || Cards[i].GetValue() == 13)
                    {
                        value += 10;
                    }
                    else
                    {
                        value += Cards[i].GetValue();
                    }
                }
            }
            for (int i = 0; i < Cards.Count; i++)
            {
                if (Cards[i].GetValue() == 1)
                {
                    if (value + 11 <= 21)
                        value += 11;
                    else
                        value += 1;
                }
            }
            return value;
        }
    }
}
