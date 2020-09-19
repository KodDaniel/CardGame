using System;
using System.Collections.Generic;
using System.Text;
using CardGameBase.Baseclasses;
using CardGameBase.Interfaces;

namespace BlackJack
{
    public class BlackJackCard:Card 
    { 
        public BlackJackCard(EnumSuite suite, EnumFace enumFace) : base(suite,enumFace) { }

        // Inte helt korrekt avseende att ess kan vara 1 ellet 14, men en förbättring
        public override void InitalizeCardValue()
        {
            switch (EnumFace)
            {
                case EnumFace.Jack:
                case EnumFace.Queen:
                case EnumFace.King:
                    Value = 10;
                    break;

                default: 
                    base.InitalizeCardValue();
                    break;
            }
        }

        public override string ToString() =>
            $"(Blackjack card: Suite: {Suite}, Face: {EnumFace}, Value: {Value}, Faceup: {FaceUp})";
    }
}
