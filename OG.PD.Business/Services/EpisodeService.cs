using OG.PD.Business.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OG.PD.Business.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class EpisodeService : ServiceBase, IEpisodeService
    {
        public bool DeleteEpisode(string podcastName, string episodeName, string downloadFolder)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEpisode(int episodeId)
        {
            throw new NotImplementedException();
        }

        public bool DownloadEpisode(string podcastName, string episodeName, string downloadFolder)
        {
            throw new NotImplementedException();
        }

        public bool DownloadEpisode(int episodeId, string downloadFolder)
        {
            throw new NotImplementedException();
        }

        public bool GetEpisodes(int podcastId)
        {
            throw new NotImplementedException();
        }
    }
}
