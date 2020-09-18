using System;
using System.Collections.Generic;
using System.Text;
using CardGameBase.Classes;

namespace CardGameBase.Interfaces
{
    public interface ICard
    {
        EnumSuite Suite { get; }
        EnumFace EnumFace { get; }
        string SuiteString { get; }
        int Value { get; }
        string ValueString { get; }
        bool FaceUp { get; set; }
        void InitalizeCardValue();
    }
}
