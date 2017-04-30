using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OG.PD.Client.Bootstrapper
{
    public static class BootStrapperLoader
    {
        public static IServiceLocator Init()
        {
            return Init(new UnityContainer());
        }

        public static IServiceLocator Init(IUnityContainer container)
        {
            return new UnityServiceLocator(container);
        }
    }

}
