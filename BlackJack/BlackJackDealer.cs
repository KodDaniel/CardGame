using System;
using System.Collections.Generic;
using System.Text;
using CardGameBase.Baseclasses;
using CardGameBase.BaseClasses;
using CardGameBase.Interfaces;

namespace BlackJack
{
    public class BlackJackDealer : Dealer
    {
        public Hand Hand { get; set; }
        public bool IsThick => (Hand.Score > 21);

        public BlackJackDealer(int id, string name) : base(id, name)
        {
            Hand = new Hand();
        }

        public override void DealHand(IDeck deck, IEnumerable<IPlayer> players, int numberOfCardsForEachPlayer)
        {
            base.DealHand(deck,players,2);

            //Dealern inleder med två kort
            Hand.AddCard(deck.DrawNextCard());
            Hand.AddCard(deck.DrawNextCard());

            // Varav ett är dolt
            var firstCardInDealerHand = Hand[0];
            firstCardInDealerHand.FaceUp = false;

        }

        public void Reset() => Hand = new Hand();

        public override string ToString() =>
            $"ID {ID}, Name: {Name}, NumberOfCards:{Hand.NumberOfCards}," + $" Score: {Hand.Score}, Is thick: {IsThick}";

    }
}
