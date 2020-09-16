using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardGameBase.Classes;
using UtilitiesLib;

namespace CardGameBase.Interfaces
{
    public interface IHand
    {
        bool LastCard { get;}
        int NumberOfCards { get; }
        int Score { get; }
        Card this[int index] { get;}
        void AddCard(Card card);
        void Clear();
    }
}

