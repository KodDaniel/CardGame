using System;
using System.Collections.Generic;
using System.Text;
using CardGameBase.Baseclasses;
using CardGameBase.Interfaces;

namespace CardGameBase.BaseClasses
{
    /// <summary>
    ///  This class holds the generic behaviors of a player
    /// </summary>
    public class Dealer:IDealer
    {
        public int ID { get; }
        public string Name { get; }

        public Dealer(int Id, string name)
        {
            ID = Id;
            Name = name;
        }
     
        public virtual void DealHand(IDeck deck, IEnumerable<IPlayer> players, int numberOfCardsForEachPlayer)
        {
            foreach (IPlayer player in players)
            {
                for (int i = 0; i < numberOfCardsForEachPlayer; i++)
                {
                    player.Hand.AddCard(deck.DrawNextCard());

                }
            }
        }

        public override string ToString() =>
            $"ID {ID}, Name: {Name}";

    }
}
