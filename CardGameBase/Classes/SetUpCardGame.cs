using System;
using System.Collections.Generic;
using System.Text;
using CardGameBase.Interfaces;

namespace CardGameBase.Classes
{
    // https://stackoverflow.com/questions/8925400/cast-listt-to-listinterface
    public static class SetUpCardGame
    {
        public static void InitializeGame(IDeck deck, IEnumerable<IPlayer> players, int numberOfCards = 6 )
        {
            InitializeDeck(deck);
            InitalizeCardValues(deck);
            InitializeHands(deck,players,numberOfCards);
        }
         
        private static void InitalizeCardValues(IDeck deck)
        {
            foreach (ICard card in deck)
            {
                card.InitalizeCardValue();
            }
        }
        private static void InitializeDeck(IDeck deck) => deck.InitializeDeck();

        private static void InitializeHands(IDeck deck, IEnumerable<IPlayer> players, int numberOfCards)
        {
            foreach (IPlayer blackJackPlayer in players)
            {
                for (int i = 0; i < numberOfCards; i++)
                {
                    blackJackPlayer.Hand.AddCard(deck.DrawNextCard());

                }
            }
        }
    }
}

