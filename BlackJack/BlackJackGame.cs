using System;
using System.Collections.Generic;
using System.Text;
using CardGameBase.Classes;
using CardGameBase.Interfaces;

namespace BlackJack
{
    public class BlackJackGame:Game
    {
        public BlackJackGame(List<IPlayer> players, IDeck deck, List<GameRule> gameRules) : base(players, deck, gameRules)
        {
        }
    }
}
