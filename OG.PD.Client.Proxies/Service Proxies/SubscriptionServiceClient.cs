using OG.PD.Client.Proxies.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using OG.PD.Client.Entities;

namespace OG.PD.Client.Proxies
{
    public class SubscriptionServiceClient : ClientBase<ISubscriptionService>, ISubscriptionService
    {
        public Podcast SubscribeToPodcast(int podcastId, Uri rssFeed)
        {
            return Channel.SubscribeToPodcast(podcastId, rssFeed);
        }

        public Podcast UnSubscribeFromPodcast(int podcastId)
        {
            return Channel.UnSubscribeFromPodcast(podcastId);
        }
    }
}
