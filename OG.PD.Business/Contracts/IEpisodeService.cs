using OG.PD.Common;
using System.ServiceModel;
using System.Threading.Tasks;

namespace OG.PD.Business.Contracts
{
    [ServiceContract]
    internal interface IEpisodeService
    {
        [OperationContract]
        [FaultContract(typeof(NotFoundException))]
        bool GetEpisodes(int podcastId);

        [OperationContract]
        [FaultContract(typeof(NotFoundException))]
        bool DeleteEpisode(string podcastName, string episodeName, string downloadFolder);

        [OperationContract]
        [FaultContract(typeof(NotFoundException))]
        bool DeleteEpisode(int episodeId);

        [OperationContract]
        bool DownloadEpisode(string podcastName, string episodeName, string downloadFolder);

        [OperationContract]
        bool DownloadEpisode(int episodeId, string downloadFolder);
    }
}