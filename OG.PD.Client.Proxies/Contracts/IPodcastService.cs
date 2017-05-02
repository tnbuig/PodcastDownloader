using OG.PD.Client.Entities;
using OG.PD.Common;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

namespace OG.PD.Client.Proxies.Contracts
{
    [ServiceContract]
    public interface IPodcastService
    {
        [OperationContract]
        [FaultContract(typeof(NotFoundException))]
        IEnumerable<Episode> GetPodcastEpisodes(int podcastId);

        [OperationContract]
        IEnumerable<Episode> GetAllEpisodes();

        [OperationContract]
        IEnumerable<Podcast> GetAllPodcasts();

        #region Async operations

        Task<IEnumerable<Episode>> GetAllEpisodesAsync();

        Task<IEnumerable<Podcast>> GetAllPodcastsAsync();

        #endregion Async operations
    }
}