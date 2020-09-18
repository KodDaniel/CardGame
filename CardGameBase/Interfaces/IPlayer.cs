using System;
using System.Collections.Generic;
using System.Text;
using CardGameBase.Classes;

namespace CardGameBase.Interfaces
{
   public interface IPlayer
   {
     int ID { get; }
     string Name { get; } 
     IHand Hand { get; }
   }

}
