﻿using OG.PD.Business.Entities;
using OG.PD.Common;
using System;
using System.ServiceModel;

namespace OG.PD.Business.Contracts
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