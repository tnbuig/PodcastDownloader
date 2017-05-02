using OG.PD.Client.Entities;
using OG.PD.Common;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

namespace OG.PD.Client.Proxies.Contracts
{
    [ServiceContract]
    public interface ISearchService
    {
        [OperationContract]
        IEnumerable<Podcast> SearchPodcastsByKeyword(string keyword);

        [OperationContract]
        [FaultContract(typeof(NotFoundException))]
        IEnumerable<Podcast> SearchPodcastsByCategory(string keyword, string category);

        [OperationContract]
        IEnumerable<Podcast> GetTopPodcasts(int amount);

        [OperationContract]
        IEnumerable<string> GetAllCategories();

        #region Async operations

        Task<IEnumerable<Podcast>> SearchPodcastsByKeywordAsync(string keyword);

        Task<IEnumerable<Podcast>> SearchPodcastsByCategoryAsync(string keyword, string category);

        Task<IEnumerable<Podcast>> GetTopPodcastsAsync(int amount);

        #endregion Async operations

    }
}