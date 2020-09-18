using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardGameBase.Classes;
using UtilitiesLib;

namespace CardGameBase.Interfaces
{
    public interface IHand:IEnumerable
    {
        bool LastCard { get;}
        int NumberOfCards { get; }
        int Score { get; }
        ICard this[int index] { get;}
        void AddCard(ICard card);
        void Clear();
    }
}

