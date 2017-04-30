using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using OG.PD.Client.Entities;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace PD.OG.Client.Desktop.ViewModels
{
    /// <summary>
    /// The Status View will show the selected podcast episodes.
    /// </summary>
    public class StatusViewModel : ViewModelBase
    {
        public StatusViewModel()
        {
            Episodes = new ObservableCollection<Episode>();
            DownloadEpisodesCommand = new RelayCommand(DownloadEpisodes, () => false);
            MessengerInstance.Register<NotificationMessage<Podcast>>(this, ShowPodcastEpisodes);
        }

        private void ShowPodcastEpisodes(NotificationMessage<Podcast> message)
        {
            Episodes.Add(new Episode()
            {
                Description = "How can competition teach machine learning? Carl and Richard talk to Anthony Goldbloom of Kaggle about competitive machine learning. Kaggle hosts competitions provided by industry and academia to find machine learning solutions on different data sets. While the competitive aspects tend toward only particular types of data sets, Anthony talks about how two very different machine learning algorithms - Gradient Boosting Machine and Deep Recurrent Neural Networks - have risen to the top. Want to learn machine learning in a hurry? Join a competition!",
                DownloadUrl = new Uri("https://s3.amazonaws.com/dnr/dotnetrocks_1307_competitive_machine_learning.mp3"),
                IsDownloaded = false,
                PodcastId = 1,
                EpisodeId = 1,
                Name = "Competitive Machine Learning with Anthony Goldbloom"
            });
            Episodes.Add(new Episode()
            {
                Description = "Where does our sense of right and wrong come from? We watch chimps at a primate research center sharing blackberries, observe 3-year-olds fighting over toys, and tour Eastern State Penitentiary -- the countrys first penitentiary. Plus, a story of land grabbing, indentured servitude, and slumlording in the fourth grade.",
                DownloadUrl = new Uri("http://www.radiolab.org/story/91508-morality/"),
                IsDownloaded = false,
                PodcastId = 1,
                EpisodeId = 2,
                Name = "Morality"
            });
            Episodes.Add(new Episode() {
                Description = "Some Explanation...",
                DownloadUrl = new Uri("http://www.DownlowdUrl"),
                IsDownloaded = false,
                PodcastId = 1,
                EpisodeId = 3,
                Name = "Episode3",
            });
        }

        public ObservableCollection<Episode> Episodes { get; set; }

        public ICommand DownloadEpisodesCommand { get; private set; }

        private void DownloadEpisodes()
        {
            throw new NotImplementedException();
        }
    }
}