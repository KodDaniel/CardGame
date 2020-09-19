using System;
using System.Collections.Generic;
using System.Text;

namespace CardGameBase.Interfaces
{

    public interface IDealer
    {
        int ID { get; }
        string Name { get; }
        void DealHand(IDeck deck, IEnumerable<IPlayer> players, int numberOfCardsForEachPlayer);

    }
}
