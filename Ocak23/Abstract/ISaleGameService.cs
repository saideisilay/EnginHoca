using Ocak23.Entitiy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ocak23.Abstract
{
    public interface ISaleGameService
    {
        void SalesToGamer(Game game, Gamer gamer);
        void SalesToGamerViaCampaign(Game game, Gamer gamer,Campaign campaign);

    }
}
