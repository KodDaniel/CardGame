using System;
using System.Collections.Generic;
using System.Text;
using CardGameBase.Classes;

namespace BlackJack
{
    public class BlackJackCard:Card
    {
        public BlackJackCard(EnumSuite suite, EnumFace enumFace) : base(suite, enumFace) { }
        public override void InitalizeCardValue()
        {
            switch (EnumFace)
            {
                case EnumFace.Jack:
                case EnumFace.King:
                case EnumFace.Queen:
                    Value = 10;
                    break;
            }
        }

       
    }
}
