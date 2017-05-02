using OG.PD.Client.Entities;
using OG.PD.Client.Proxies.Contracts;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

namespace OG.PD.Client.Proxies
{
    public class SearchServiceClient : ClientBase<ISearchService>, ISearchService
    {
        public IEnumerable<string> GetAllCategories()
        {
            return Channel.GetAllCategories();
        }

        public IEnumerable<Podcast> GetTopPodcasts(int amount)
        {
            return Channel.GetTopPodcasts(amount);
        }

        public IEnumerable<Podcast> SearchPodcastsByKeyword(string keyword)
        {
            return Channel.SearchPodcastsByKeyword(keyword);
        }

        public IEnumerable<Podcast> SearchPodcastsByCategory(string keyword, string category)
        {
            return Channel.SearchPodcastsByCategory(keyword, category);
        }

        #region Async operations

        public Task<IEnumerable<Podcast>> SearchPodcastsByKeywordAsync(string keyword)
        {
            return Channel.SearchPodcastsByKeywordAsync(keyword);
        }

        public Task<IEnumerable<Podcast>> GetTopPodcastsAsync(int amount)
        {
            return Channel.GetTopPodcastsAsync(amount);
        }

        public Task<IEnumerable<Podcast>> SearchPodcastsByCategoryAsync(string keyword, string category)
        {
            return Channel.SearchPodcastsByCategoryAsync(keyword, category);
        }

        #endregion Async operations
    }
}