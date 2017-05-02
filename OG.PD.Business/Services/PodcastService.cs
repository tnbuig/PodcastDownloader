using OG.PD.Business.Contracts;
using OG.PD.Business.Entities;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace OG.PD.Business.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class PodcastService : ServiceBase, IPodcastService
    {
        public IEnumerable<Episode> GetAllEpisodes()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Podcast> GetAllPodcasts()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Episode> GetPodcastEpisodes(int podcastId)
        {
            throw new NotImplementedException();
        }
    }
}