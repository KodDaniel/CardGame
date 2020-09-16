using System;
using System.Collections.Generic;
using System.Text;
using CardGameBase.Classes;

namespace CardGameBase.Interfaces
{
    public interface IDeck
    {
        int NumberOfDecks { get; }
        int CardCount { get; }
        Card this[int index] { get; }
        void InitializeDeck();
        void DisCardCards();
        Card DrawNextCard();
        void FillDeckWithCards();
        void Shuffle();

    }
}
