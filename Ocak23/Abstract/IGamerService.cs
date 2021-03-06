using Ocak23.Entitiy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ocak23.Abstract
{
    public interface IGamerService
    {
        void Add(Gamer gamer);
        void UpDate(Gamer gamer);
        void Delete(Gamer gamer);

    }
}
