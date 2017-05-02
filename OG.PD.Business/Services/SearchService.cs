using OG.PD.Business.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using OG.PD.Business.Entities;

namespace OG.PD.Business.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class SearchService : ServiceBase, ISearchService
    {
        public IEnumerable<string> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Podcast> GetTopPodcasts(int amount)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Podcast> SearchPodcastsByCategory(string keyword, string category)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Podcast> SearchPodcastsByKeyword(string keyword)
        {
            throw new NotImplementedException();
        }
    }
}
