using OG.PD.Business.Contracts;
using OG.PD.Business.Entities;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

namespace OG.PD.Business.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class PodcastService : ServiceBase, IPodcastService
    {
        public IEnumerable<Podcast> GetAllSubsribedPodcast()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Podcast> SearchPodcasts()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Podcast>> SearchPodcastsAsync()
        {
            throw new NotImplementedException();
        }

        public Podcast SubscribeToPodcast(Podcast podcast)
        {
            throw new NotImplementedException();
        }

        public Podcast UnSubscribeFromPodcast(int podcastId)
        {
            throw new NotImplementedException();
        }
    }
}