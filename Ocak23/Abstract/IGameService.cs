using Ocak23.Entitiy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ocak23.Abstract
{
    public interface IGameService
    {
        void Add(Game game);
        void UpDate(Game game);
        void Delete(Game game);
    }
}
