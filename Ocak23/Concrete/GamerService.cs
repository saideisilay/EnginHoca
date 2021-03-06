using Ocak23.Abstract;
using Ocak23.Entitiy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ocak23.Concrete
{
    public class GamerService : BaseGamerManager
    {
        IGamerValidation _gamerValidation;

        public GamerService(IGamerValidation gamerValidation)
        {
            _gamerValidation = gamerValidation;
        }
        public override void Add(Gamer gamer)
        {
            if(_gamerValidation.Validate(gamer))
            {
                base.Add(gamer);
            }
            else
            {
                throw new Exception("Identity Number cannot validation.");
            }
        }
    }
}
