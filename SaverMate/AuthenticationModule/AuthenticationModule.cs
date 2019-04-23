using Authentication.ViewModels;
using Authentication.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace Authentication
{
    public class AuthenticationModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<LoginStage1Page, LoginStage1PageViewModel>();
            containerRegistry.RegisterForNavigation<LoginStage2Page, LoginStage2PageViewModel>();
        }
    }
}
