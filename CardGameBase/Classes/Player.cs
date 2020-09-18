using System;
using System.Collections.Generic;
using System.Text;
using CardGameBase.Interfaces;

namespace CardGameBase.Classes
{
    public class Player:IPlayer
    {
        public int ID { get; }
        public string Name { get; }
        public bool IsFinisihed { get; protected set; }
        public Hand Hand { get; set; }

       public Player (int Id, string name)
        {
            ID = Id;
            Name = name;
            Hand = new Hand();
        }

       public virtual void Reset()
       {
           Hand = new Hand();
           IsFinisihed = false;
        } 

        
    }
}
