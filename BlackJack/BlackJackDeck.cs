using System;
using System.Collections.Generic;
using System.Text;
using CardGameBase.Classes;

namespace BlackJack
{
    public class BlackJackDeck : Deck
    {
        public override void FillDeckWithCards()
        {
            while (NumberOfDecks > 0)
            {
                for (int face = 1; face < 14; face++)
                {
                    for (int color = 0; color < 4; color++)
                    {
                        _cards.Add(new BlackJackCard((EnumSuite) color, (EnumFace) face));
                    }


                }

                NumberOfDecks--;
            }
        }
    }
}
