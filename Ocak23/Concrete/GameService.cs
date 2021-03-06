using Ocak23.Abstract;
using Ocak23.Entitiy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ocak23.Concrete
{
    public class GameService : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("{0} nolu {1} adlı oyun sisteme eklenmiştir.", game.Id, game.GameName);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("{0} nolu {1} adlı oyun sistemden silinmiştir.", game.Id, game.GameName);
        }

        public void UpDate(Game game)
        {
            Console.WriteLine("{0} nolu {1} adlı oyun sistemde güncellenmiştir.", game.Id, game.GameName);
        }
    }
}
