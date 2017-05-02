using System;

namespace OG.PD.Client.Entities
{
    public class Subscription
    {
        public int SubscriptionId { get; set; }

        public int PodcastId { get; set; }

        public DateTime LastRefreshDate { get; set; }
    }
}
