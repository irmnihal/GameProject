using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class CampaignManager: ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi");
        }

      public void Update(Campaign campaign)
          {
            Console.WriteLine("kayıt güncellendi");
        }
        public void Delete(Campaign campaign)
        {
            Console.WriteLine("kayıt silindi");
        }
    }
}
