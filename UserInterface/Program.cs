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
            var players = new List<IPlayer>
            {
                new BlackJackPlayer(1,"Daniel"),
                new BlackJackPlayer(2,"James"),
                new BlackJackPlayer(3,"Johan"),


            };

            // Skapar ny deck 
           IDeck deck = new BlackJackDeck();
          

            List<GameRule> gameRules = new List<GameRule> {new GameRule("Det måste finnas en dealer", false)};


             IGame  b = new Game(players, deck, gameRules);

             b.Players.ForEach(Console.WriteLine);
             Console.ReadLine();
        }
    }
}
