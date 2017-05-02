using OG.PD.Client.Entities;
using OG.PD.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OG.PD.Client.Proxies.Contracts
{
    [ServiceContract]
    public interface ISubscriptionService
    {
        [OperationContract]
        [FaultContract(typeof(NotFoundException))]
        Podcast SubscribeToPodcast(int podcastId, Uri rssFeed);

        [OperationContract]
        [FaultContract(typeof(NotFoundException))]
        Podcast UnSubscribeFromPodcast(int podcastId);
    }
}
