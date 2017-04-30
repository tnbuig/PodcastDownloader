using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OG.PD.Business.Entities
{
    [DataContract]
    public class Episode
    {
        [DataMember]
        public int EpisodeId { get; set; }

        [DataMember]
        public int PodcastId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public Uri DownloadUrl { get; set; }

        [DataMember]
        public bool IsDownloaded { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}
