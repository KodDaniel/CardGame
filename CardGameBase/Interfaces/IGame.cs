using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardGameBase.Classes;

namespace CardGameBase.Interfaces
{
   public interface IGame
   {
        List<IPlayer> Players { get; }
        IDeck Deck { get;}
        List<GameRule> GameRules { get;}
        bool GameRulesFulFilled { get;}
    }
}
