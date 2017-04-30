using NUnit.Framework;
using OG.PD.Client.Entities;
using PD.OG.Client.Desktop.ViewModels;
using System;

namespace OG.PD.Client.Desktop.Tests
{
    [TestFixture()]
    public class StatusViewModelTests
    {
        [Test]
        public void Episodes_PodcastHasBeenSelected_EpisodesCollectionIsNotEmpty()
        {
            var statusViewModel = new StatusViewModel();
            var headerViewModel = new HeaderViewModel();

            headerViewModel.SelectedPodcast = new Podcast();

            Assert.NotNull(statusViewModel.Episodes);
            CollectionAssert.IsNotEmpty(statusViewModel.Episodes);
        }
    }
}
