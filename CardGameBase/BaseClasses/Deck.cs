using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using CardGameBase.Interfaces;
using UtilitiesLib;

namespace CardGameBase.Baseclasses
{
    /// <summary>
    ///  This class holds the generic behaviors of a deck
    /// </summary>
    public class Deck : IDeck
    {
        protected readonly List<ICard> _cards;
        public int NumberOfDecks { get; protected set; } = 1;
        public int CardCount => _cards.Count;

        // Om index faller utanför listan, undvik exception och returna null istället
        public ICard this[int index] => _cards.OutOfRange(index) ? null : _cards[index];

        public Deck() => _cards = new List<ICard>();

        public Deck(int numberOfDecks)
        {
            _cards = new List<ICard>();
            NumberOfDecks = numberOfDecks;
        }

        public void InitializeDeck()
        {
            FillDeckWithCards();
            Shuffle();
        }

        //public void SwapCards()
        //{
        //    throw new NotImplementedException();
        //}

        public void DisCardCards() => _cards.Clear();

        public ICard DrawNextCard() =>_cards.RemoveAndReturnFirst();


        // Virutal eftersom det är troligt att olika kortspel vill göra detta på olika sätt
        public virtual void FillDeckWithCards()
        {
            while (NumberOfDecks > 0)
            {
                for (int face = 1; face < 14; face++)
                {
                    for (int color = 0; color < 4; color++)
                    {
                        _cards.Add(new Card((EnumSuite)color, (EnumFace)face));
                    }


                }
                NumberOfDecks--;
            }
        }

        public void Shuffle() => _cards.Shuffle();

        public IEnumerator GetEnumerator() => _cards.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();




    }
}
