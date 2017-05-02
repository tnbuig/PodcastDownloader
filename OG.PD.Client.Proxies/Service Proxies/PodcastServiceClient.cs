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
    public class PodcastServiceClient : ClientBase<IPodcastService>, IPodcastService
    {
        public IEnumerable<Episode> GetAllEpisodes()
        {
            return Channel.GetAllEpisodes();
        }

        public IEnumerable<Podcast> GetAllPodcasts()
        {
            return Channel.GetAllPodcasts();
        }

        public IEnumerable<Episode> GetPodcastEpisodes(int podcastId)
        {
            return Channel.GetPodcastEpisodes(podcastId);
        }

        #region Async operations

        public Task<IEnumerable<Episode>> GetAllEpisodesAsync()
        {
            return Channel.GetAllEpisodesAsync();
        }

        public Task<IEnumerable<Podcast>> GetAllPodcastsAsync()
        {
            return Channel.GetAllPodcastsAsync();
        }

        #endregion
    }
}
