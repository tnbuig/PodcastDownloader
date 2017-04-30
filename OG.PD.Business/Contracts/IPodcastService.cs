using OG.PD.Business.Entities;
using OG.PD.Common;
using System.Collections.Generic;
using System.ServiceModel;

namespace OG.PD.Business.Contracts
{
    [ServiceContract]
    public interface IPodcastService
    {
        [OperationContract]
        Podcast SubscribeToPodcast(Podcast podcast);

        [OperationContract]
        [FaultContract(typeof(NotFoundException))]
        Podcast UnSubscribeFromPodcast(int podcastId);

        [OperationContract]
        IEnumerable<Podcast> GetAllSubsribedPodcast();

        [OperationContract]
        IEnumerable<Podcast> SearchPodcasts();
    }
}