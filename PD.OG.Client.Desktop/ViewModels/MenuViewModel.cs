using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace PD.OG.Client.Desktop.ViewModels
{
    /// <summary>
    /// The Menu view will let the user take applicatoin level actions
    /// such as open Download Folder, Refresh, and Exit.
    /// </summary>
    public class MenuViewModel : ViewModelBase
    {
        public MenuViewModel()
        {
            OpenDownloadFolderCommand = new RelayCommand(OpenDownloadFolder);
            UpdateEpisodeListCommand = new RelayCommand(UpdateEpisodeList);
        }

        public ICommand OpenDownloadFolderCommand { get; private set; }

        public ICommand UpdateEpisodeListCommand { get; private set; }

        private void UpdateEpisodeList()
        { }

        private void OpenDownloadFolder()
        { }
    }
}