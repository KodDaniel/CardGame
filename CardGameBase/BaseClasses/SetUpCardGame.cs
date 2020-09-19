using System;
using System.Collections.Generic;
using System.Text;
using CardGameBase.BaseClasses;
using CardGameBase.Interfaces;

namespace CardGameBase.Baseclasses
{
    // https://stackoverflow.com/questions/8925400/cast-listt-to-listinterface

    /// <summary>
    ///  Helper class to start a card game. The interface parameters makes it possible
    ///  for the class to operate on different data types as long as they implement these interfaces
    /// </summary>
    public static class SetUpCardGame
    {
        public static void InitializeGame(IDealer dealer,IDeck deck, IEnumerable<IPlayer> players, int numberOfCardsForEachPlayer)
        {
            InitializeDeck(deck);
            InitalizeCardValues(deck);
            DealHand(dealer,deck,players,numberOfCardsForEachPlayer);
        }

        private static void InitalizeCardValues(IDeck deck)
        {
            foreach (ICard card in deck)
            {
                card.InitalizeCardValue();
            }
        }
        private static void InitializeDeck(IDeck deck) => deck.InitializeDeck();

        
        private static void DealHand(IDealer dealer, IDeck deck, IEnumerable<IPlayer> players, int numberOfCardsForEachPlayer)
        {
            dealer.DealHand(deck, players, numberOfCardsForEachPlayer);
        }
    }
}

