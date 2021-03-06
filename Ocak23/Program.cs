using Ocak23.Concrete;
using Ocak23.Entitiy;
using System;

namespace Ocak23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("///////////OYUNCU EKLEME///////////");
            DateTime tarih = new DateTime(1988, 07, 05);
            Gamer gamer1 = new Gamer
            {
                Id = 1,
                NationalId = 31187118752,
                FirstName = "Saide Işılay".ToUpper(),
                LastName = "Baykal".ToUpper(),
                DateOfBirth=tarih
            };
            GamerService gamerService = new GamerService(new GamerValidation());
            gamerService.Add(gamer1);

            Console.WriteLine("///////////OYUN EKLEME///////////");
            Game game1 = new Game
            {
                Id = 1,
                GameName = "The Talos Principle",
                GameCategory = "Stategy",
                GameUnitPrice = 60
            };

            GameService gameService = new GameService();
            gameService.Add(game1);

            Console.WriteLine("///////////KAMPANYA EKLEME///////////");
            Campaign campaign = new Campaign
            {
                Id = 1,
                CampaignName = "Arkadaş kampanyası",
                Description = "1-7 Mart tarihlerde geçerli olan bu kampanyada kendine ve seçtiğin bir arkadaşına 'Jammer' ve 'Reflector' ENVANTERLERİNİ veriyoruz!!!"
            };
            CampaignService campaignService = new CampaignService();
            campaignService.Add(campaign);

            Console.WriteLine("///////////SATIŞ EKLEME///////////");
            SaleGameService saleGameService = new SaleGameService();
            saleGameService.SalesToGamer(game1, gamer1);
            Console.WriteLine("///////////KAMPANYALI SATIŞ EKLEME///////////");
            saleGameService.SalesToGamerViaCampaign(game1, gamer1, campaign);
           
        }
    }
}
