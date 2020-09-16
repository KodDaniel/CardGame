using System;
using System.Collections;
using System.Collections.Generic;
using BlackJack;
using CardGameBase;
using CardGameBase.Classes;
using CardGameBase.Interfaces;

namespace UserInterface
{
    class Program
    {
        static void Main(string[] args)
        {

            // Skapa nya spelare 
            var players = new List<IParticipant>
            {
                new BlackJackPlayert(1,"Daniel"),
                new BlackJackPlayert(2,"James"),
                new BlackJackPlayert(3,"Johan"),
                new BlackJackDealer(1)
            };

            // Skapar ny deck 
           IDeck deck = new BlackJackDeck();

             
          

            List<GameRule> gameRules = new List<GameRule> {new GameRule("Det måste finnas en dealer", false)};


             IGame  b = new Game(players, deck, gameRules);


             foreach (var player in b.Players)
             {
                 if (player is Player d)
                 {
                     
                 }
             }
               
        }
    }
}
