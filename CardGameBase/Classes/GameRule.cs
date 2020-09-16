using System;
using System.Collections.Generic;
using System.Text;

namespace CardGameBase.Classes
{
    public class GameRule
    {
        public string Description { get; set; }
        public bool FulFilled { get; set; }

        public GameRule(string description,bool fulFilled)
        {
            Description = description;
            FulFilled = fulFilled;
        }

    }

}
