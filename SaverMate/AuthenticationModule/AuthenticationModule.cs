using Prism.Ioc;
using Prism.Modularity;
using AuthenticationModule.ViewModels;
using AuthenticationModule.Views;

namespace Authentication
{
    public class AuthenticationModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA, ViewAViewModel>();
        }
    }
}
