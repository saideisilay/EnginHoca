using Ocak23.Abstract;
using Ocak23.Entitiy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ocak23.Concrete
{
    class SaleGameService : ISaleGameService
    {
        public void SalesToGamer(Game game, Gamer gamer)
        {
            Console.WriteLine("{0} adlı oyunu {1} TL fiyatına {2} adlı oyuncu satın almıştır.", game.GameName,game.GameUnitPrice, gamer.FirstName);
        }

        public void SalesToGamerViaCampaign(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine("{0} adlı oyunu '{1}' ile {2} adlı oyuncu satın almıştır.\nAÇIKLAMA: {3}", game.GameName, campaign.CampaignName, gamer.FirstName + " " +gamer.LastName,campaign.Description);
        }
    }
}
