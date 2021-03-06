using Ocak23.Concrete;
using Ocak23.Entitiy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ocak23.Abstract
{
    public abstract class BaseGamerManager : IGamerService
    {
        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine("{0} {1} adlı oyuncu sisteme eklenmiştir.", gamer.FirstName, gamer.LastName);
        }

        public virtual void Delete(Gamer gamer)
        {
            Console.WriteLine("{0} adlı oyuncu sistemden silinmiştir.", gamer.FirstName, gamer.LastName);
        }

        public virtual void UpDate(Gamer gamer)
        {
            Console.WriteLine("{0} adlı oyuncu sistemde güncellenmiştir.", gamer.FirstName, gamer.LastName);
        }
    }
}
