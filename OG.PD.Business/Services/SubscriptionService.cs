using OG.PD.Business.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using OG.PD.Business.Entities;

namespace OG.PD.Business.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class SubscriptionService : ServiceBase, ISubscriptionService
    {
        public Podcast SubscribeToPodcast(int podcastId, Uri rssFeed)
        {
            throw new NotImplementedException();
        }

        public Podcast UnSubscribeFromPodcast(int podcastId)
        {
            throw new NotImplementedException();
        }
    }
}
