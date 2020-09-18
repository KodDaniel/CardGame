using System;
using System.Collections.Generic;
using System.Text;
using CardGameBase.Classes;
using CardGameBase.Interfaces;

namespace BlackJack
{
    public class BlackJackCard:Card 
    { 
        public BlackJackCard(EnumSuite suite, EnumFace enumFace) : base(suite,enumFace) { }
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
            $"(BlackjackCard: Suite: {Suite}, Face: {EnumFace}, Value: {Value})";
    }
}
