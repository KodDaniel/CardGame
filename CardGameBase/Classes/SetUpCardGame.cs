using System;
using System.Collections.Generic;
using System.Text;
using CardGameBase.Interfaces;

namespace CardGameBase.Classes
{
    public static class SetUpCardGame
    {
        public static void InitializeGame(IDeck deck, IEnumerable<IPlayer> players, int numberOfTimes = 1 )
        {
            InitializeDeck(deck);
            InitalizeCardValues(deck);
            InitializeHands(deck,players,numberOfTimes);
        }
        
        private static void InitalizeCardValues(IDeck deck)
        {
            foreach (ICard card in deck)
            {
                card.InitalizeCardValue();
            }
        }
        private static void InitializeDeck(IDeck deck) => deck.InitializeDeck();

        private static void InitializeHands(IDeck deck, IEnumerable<IPlayer> players, int numberOfTimes = 1)
        {
            foreach (IPlayer blackJackPlayer in players)
            {
                while (0 < numberOfTimes)
                {
                    blackJackPlayer.Hand.AddCard(deck.DrawNextCard());
                    numberOfTimes--;
                }
            }
        }
    }
}

