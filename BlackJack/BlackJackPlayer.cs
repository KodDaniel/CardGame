using System;
using System.Collections.Generic;
using System.Text;
using CardGameBase.Classes;

namespace BlackJack
{
    public class BlackJackPlayer : Player
    {
        public bool IsThick => (Hand.Score > 21);

        public BlackJackPlayer(int Id, string name) : base(Id, name) { }

        public override string ToString() =>
            $"ID {ID},Name:{Name}, Is finsihed: {IsFinisihed}, Is thick: {IsThick}";
    }
}
