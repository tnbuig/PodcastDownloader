using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using OG.PD.Client.Entities;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System;
using GalaSoft.MvvmLight.Messaging;

namespace PD.OG.Client.Desktop.ViewModels
{
    /// <summary>
    /// The Header view will provide "Podcast Search Option" and 
    /// Will present the results.
    /// </summary>
    public class HeaderViewModel : ViewModelBase
    {
        private Podcast _podcast;

        public HeaderViewModel()
        {
            SearchPodcastCommand = new RelayCommand(SerachPodcast, () => true);
            Podcasts = new ObservableCollection<Podcast>(){};
        }

        public Podcast SelectedPodcast
        {
            get { return _podcast; }
            set
            {
                if (_podcast != value && value != null)
                {
                    _podcast = value;
                    MessengerInstance.Send(new NotificationMessage<Podcast>(SelectedPodcast,SelectedPodcast?.Name));
                }
            }
        }

        public ObservableCollection<Podcast> Podcasts { get; set; }

        public ICommand SearchPodcastCommand { get; private set; }

        private void SerachPodcast()
        {
            Podcasts.Add(new Podcast()
            {
                Name = "Podcast Name",
                Description = "Podcast Description usually few lines with all kind of stuff going on there pretty cool stuff advertisment etc...",
                LogoUrl = new Uri("http://is1.mzstatic.com/image/thumb/Music1/v4/80/19/99/8019999e-738b-530e-8de4-2e970048bd02/source/100x100bb.jpg"),
                PodcastId = 1,
                RssFeed = new Uri("http://feeds.wnyc.org/radiolab"),
            });
        }
    }
}