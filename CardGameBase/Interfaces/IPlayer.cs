using System;
using System.Collections.Generic;
using System.Text;
using CardGameBase.Baseclasses;

namespace CardGameBase.Interfaces
{
   public interface IPlayer
   {
     int ID { get; }
     string Name { get; }
     bool IsFinisihed { get;}
     IHand Hand { get; }
     void Reset();
   }

}
