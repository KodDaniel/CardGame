using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardGameBase.Interfaces;
using UtilitiesLib;

namespace CardGameBase.Baseclasses
{
    /// <summary>
    ///  This class holds the generic behaviors of a Hand
    /// </summary>
    public class Hand : IHand
    {
        private readonly List<ICard> _cards;
        public bool LastCard => _cards.Count == 1;
        public int NumberOfCards => _cards.Count;
        public int Score  =>  _cards.Sum(a => a.Value);

        // Om index faller utanför listan, undvik exception och returna null istället
        public ICard this[int index] => _cards.OutOfRange(index) ? null : _cards[index];
        public Hand() => _cards = new List<ICard>();

        public void AddCard(ICard card) => _cards.Add(card);

        public void Clear() => _cards.Clear();

        public IEnumerator GetEnumerator() => _cards.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public override string ToString() =>
            $"LastCard:{LastCard}, NumberOfCards: {NumberOfCards}, Score:{Score}";

    }
}
