using Microsoft.VisualStudio.TestTools.UnitTesting;
using PD.OG.Client.Desktop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD.OG.Client.Desktop.ViewModels.Tests
{
    [TestClass()]
    public class HeaderViewModelTests
    {
        [TestMethod()]
        public void HeaderViewModelTest()
        {
            var headerViewModel = new HeaderViewModel();

            headerViewModel.SearchPodcastCommand.Execute("Keyword to search");

            Assert.Fail();
        }
    }
}