using System;
using System.Collections.Generic;
using System.Text;
using CardGameBase.Classes;

namespace BlackJack
{
    public class BlackJackPlayert:Player
    {
        public bool IsThick => (Hand.Score > 21);

        public BlackJackPlayert(int Id, string name) : base(Id, name) { }

        public override string ToString() =>
            $"ID {ID},Name:{Name}, Is finsihed: {IsFinisihed}, Is thick: {IsThick}";
    }
}
