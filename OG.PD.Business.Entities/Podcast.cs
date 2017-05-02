using System;
using System.Runtime.Serialization;

namespace OG.PD.Business.Entities
{
    [DataContract]
    public class Podcast
    {
        [DataMember]
        public int PodcastId { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public Uri RssFeed { get; set; }

        [DataMember]
        public Uri LogoUrl { get; set; }

        #region Oevrride
        public override string ToString()
        {
            return Name;
        }
        #endregion Oevrride
    }
}