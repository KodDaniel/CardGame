using System;
using System.Collections.Generic;
using System.Text;
using CardGameBase.Interfaces;

namespace BlackJack
{
    public class BlackJackDealer:IParticipant
    { 
        public int ID { get; set; }
        public string Name { get; set; }

        public BlackJackDealer(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
