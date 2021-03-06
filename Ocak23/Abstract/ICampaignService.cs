using Ocak23.Entitiy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ocak23.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void UpDate(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
