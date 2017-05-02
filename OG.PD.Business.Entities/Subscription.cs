using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OG.PD.Business.Entities
{
    [DataContract]
    public class Subscription
    {
        [DataMember]
        public int SubscriptionId { get; set; }

        [DataMember]
        public int PodcastId { get; set; }

        [DataMember]
        public DateTime LastRefreshDate { get; set; }
    }
}
