using System;
using System.Collections.Generic;
using System.Text;
using CardGameBase.Classes;
using CardGameBase.Interfaces;

namespace BlackJack
{
    public class BlackJackDealer
    { 
        public int ID { get; set; }
        public string Name { get; set; }
        public Hand Hand { get; set; }

        public BlackJackDealer(int id, string name)
        {
            ID = id;
            Name = name;
            Hand = new Hand();
        }
    }
}
