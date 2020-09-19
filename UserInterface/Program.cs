using System;
using System.Collections.Generic;
using BlackJack;
using CardGameBase.Baseclasses;
using CardGameBase.BaseClasses;
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

            blackjack.Print();
            Console.ReadLine();
        }


        
    }


  // Glöm inte att implementera att vi alltid behöver en dealer
  // Fast eftersom man måste göra det i konstruktor när väl det gjort? 
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
            SetUpCardGame.InitializeGame(dealer,Deck,Players,2);
        }

        
        public void Print()
        {

            foreach (ICard card in Deck)
            {
                Console.WriteLine(card);
            }

            Console.WriteLine("----------------------------------------------------------");
            foreach (var blackJackPlayer in Players)
            {
                Console.WriteLine(blackJackPlayer);
            }
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine(Deck.CardCount);

            Dealer dealer = new Dealer(2,"Oskar the man");

          
        }






    }
}
