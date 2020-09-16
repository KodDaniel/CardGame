using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardGameBase.Interfaces;
using UtilitiesLib;

namespace CardGameBase.Classes
{
    public class Game:IGame
    {
        public List<IParticipant> Players { get;}
        public IDeck Deck { get; }
        public List<GameRule> GameRules { get; protected set; }
        // Blir sant antingen om alla villkor i listan är uppfyllda, eller om listan inte innehåller några r
        public bool GameRulesFulFilled => GameRules.All(a => a.FulFilled) || !GameRules.Any();


        public Game(List<IParticipant> players, IDeck deck, List<GameRule> gameRules)
        {
         
            Players = players;
            Deck = deck;
            GameRules = gameRules;
        }

       
    }
}
