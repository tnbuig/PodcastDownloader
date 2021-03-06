﻿using OG.PD.Business.Entities;
using OG.PD.Common;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

namespace OG.PD.Business.Contracts
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
    }
}