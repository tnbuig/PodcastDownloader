using Microsoft.Practices.ServiceLocation;
using OG.PD.Client.Bootstrapper;
using PD.OG.Client.Desktop.ViewModels;

namespace PD.OG.Client.Desktop
{
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            IServiceLocator serviceLocator = BootStrapperLoader.Init();
            ServiceLocator.SetLocatorProvider(() => serviceLocator);
        }

        public HeaderViewModel Header => ServiceLocator.Current.GetInstance<HeaderViewModel>();

        public MenuViewModel Menu => ServiceLocator.Current.GetInstance<MenuViewModel>();

        public StatusViewModel Status => ServiceLocator.Current.GetInstance<StatusViewModel>();
    }
}