using System;
using System.Collections.Generic;
using System.Text;
using CardGameBase.Interfaces;

namespace CardGameBase.Classes
{
    public class Card:ICard 
    {
        public EnumSuite Suite { get; }
        public EnumFace EnumFace { get; }
        public string SuiteString => Suite.ToString();
        public int Value { get; protected set; }
        public string ValueString => Value.ToString();
        public bool FaceUp { get; set; }

        public Card(EnumSuite suite, EnumFace enumFace)
        {
            Suite = suite;
            EnumFace = enumFace;
        }

        // Sätt det ursprungliga värdet
        public virtual void InitalizeCardValue() => Value = (int)EnumFace;

        // Möjligt att ändra värdet
        public void SetCardValue(int newValue) => Value = newValue;
            
        

        public override string ToString() =>
            $"(Suite: s Face: {EnumFace}, Value: {Value})";


    }
}
