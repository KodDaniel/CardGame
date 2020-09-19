using System;
using System.Collections.Generic;
using System.Text;
using CardGameBase.Interfaces;

namespace CardGameBase.Baseclasses
{
    /// <summary>
    ///  This class holds the generic behaviors of a card
    /// </summary>
    public class Card:ICard 
    {
        public EnumSuite Suite { get; }
        public EnumFace EnumFace { get; }
        public string SuiteString => Suite.ToString();
        public int Value { get; set; }
        public string ValueString => Value.ToString();
        public bool FaceUp { get; set; }

        public Card(EnumSuite suite, EnumFace enumFace)
        {
            Suite = suite;
            EnumFace = enumFace;
        }

        /// <summary>
        ///  Sets the (generic) initial card values
        /// </summary>
        public virtual void InitalizeCardValue() => Value = (int)EnumFace;


        public override string ToString() =>
            $"(Card: Suite: {Suite}, Face: {EnumFace}, Value: {Value}, FaceUp: {FaceUp})";


    }
}
