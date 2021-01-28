using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OrderManager//satışın gerçekleştirileceği sınıf
    {
        //constructor yaptık
        CampaignManager _campaignManager;
        public OrderManager(CampaignManager campaignManager)
        {
            _campaignManager = campaignManager;
        }

        public void PressScreen(Campaign campaign)
        {
            campaign.CampaignId = 1;
            campaign.CampaignName = "2+1(2 Oyun Alana 1 Oyun Hediye)";

            Console.WriteLine("Campaign 1 \nId: " + campaign.CampaignId + "\nCampaign Name :" + campaign.CampaignName);
        }
    }
}
