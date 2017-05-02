using OG.PD.Business.Entities;
using OG.PD.Common;
using System.Collections.Generic;
using System.ServiceModel;

namespace OG.PD.Business.Contracts
{
    [ServiceContract]
    public interface ISearchService
    {
        [OperationContract]
        IEnumerable<Podcast> SearchPodcastsByKeyword(string keyword);

        [OperationContract]
        [FaultContract(typeof(NotFoundException))]
        IEnumerable<Podcast> SearchPodcastsByCategory(string keyword,string category);

        [OperationContract]
        IEnumerable<Podcast> GetTopPodcasts(int amount);

        [OperationContract]
        IEnumerable<string> GetAllCategories();
    }


}