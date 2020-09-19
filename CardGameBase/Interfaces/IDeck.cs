using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using CardGameBase.Baseclasses;

namespace CardGameBase.Interfaces
{
    public interface IDeck:IEnumerable
    {
        int NumberOfDecks { get; }
        int CardCount { get; }
        ICard this[int index] { get; }
        void InitializeDeck();
        void DisCardCards();
        ICard DrawNextCard();
        void FillDeckWithCards();
        void Shuffle();

    }
}
