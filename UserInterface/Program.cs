using System;
using System.Collections.Generic;
using BlackJack;
using CardGameBase.Classes;
using CardGameBase.Interfaces;

namespace UserInterface
{
    class Program
    {
        static void Main(string[] args)
        {

            List<BlackJackPlayer> players = new List<BlackJackPlayer>()
            {
                new BlackJackPlayer(1,"Daniel"),
                new BlackJackPlayer(2,"Ida")
            };

           BlackJackDeck deck = new BlackJackDeck();

            BlackJackDealer dealer = new BlackJackDealer(1,"James the Dealer");

            BlackJack  blackjack = new BlackJack(players,deck,dealer);

            blackjack.D();
            Console.ReadLine();
        }


        
    }



    public class BlackJack
    {
        public static List<BlackJackPlayer> Players { get; private set; }
        public static BlackJackDeck Deck { get; private set; }
        public static BlackJackDealer BlackJackDealer { get; private set; }


        public BlackJack(List<BlackJackPlayer> players, BlackJackDeck deck, BlackJackDealer dealer)
        {
            Players = players;
            Deck = deck;
            BlackJackDealer = dealer;
            SetUpCardGame.InitializeGame(Deck,Players);
            
        }

        public void D()
        {
            foreach (ICard card in Deck)
            {
                Console.WriteLine(card);
            }
        }
       

           
        

        
    }
}
