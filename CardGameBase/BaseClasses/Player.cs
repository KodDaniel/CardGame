using System;
using System.Collections.Generic;
using System.Text;
using CardGameBase.Interfaces;

namespace CardGameBase.Baseclasses 
{
    /// <summary>
    ///  This class holds the generic behaviors of a player
    /// </summary>
    public class Player:IPlayer
    {
        public int ID { get; }
        public string Name { get; }
        public bool IsFinisihed { get; protected set; }
        public IHand Hand { get; set; }

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

       public override string ToString() =>
           $"ID {ID}, Name: {Name}, NumberOfCards:{Hand.NumberOfCards}," +
           $" Score: {Hand.Score}, Lastcard: {Hand.LastCard}, Is finsihed: {IsFinisihed}";
    }
}
