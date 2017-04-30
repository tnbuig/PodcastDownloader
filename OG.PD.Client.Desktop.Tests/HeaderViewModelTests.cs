using NUnit.Framework;
using PD.OG.Client.Desktop.ViewModels;
using System;

namespace OG.PD.Client.Desktop.Tests
{
    [TestFixture()]
    public class HeaderViewModelTests
    {
        [Test]
        public void SearchPodcastCommand_ValidKeyword_ResultIsNotNull()
        {
            var headerViewModel = new HeaderViewModel();

            headerViewModel.SearchPodcastCommand.Execute("Keyword To Search");

            Assert.NotNull(headerViewModel.Podcasts);
        }
    }
}
