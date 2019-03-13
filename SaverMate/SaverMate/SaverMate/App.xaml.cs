using System;
using Account;
using Authentication;
using Prism;
using Prism.Ioc;
using Prism.Modularity;
using SaverMate.Data;
using SaverMate.Models;
using SaverMate.ViewModels;
using SaverMate.ViewModels.Accounts;
using SaverMate.ViewModels.Achievements;
using SaverMate.ViewModels.Dashboard;
using SaverMate.ViewModels.Navigation;
using SaverMate.ViewModels.Rewards;
using SaverMate.Views;
using SaverMate.Views.Accounts;
using SaverMate.Views.Achievements;
using SaverMate.Views.Dashboard;
using SaverMate.Views.Navigation;
using SaverMate.Views.Rewards;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SaverMate
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("MasterDetailNavPage/TabNavPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<RewardShopPage, RewardShopPageViewModel>();
            containerRegistry.RegisterForNavigation<DashboardPage, DashboardPageViewModel>();
            containerRegistry.RegisterForNavigation<TabNavPage, TabNavPageViewModel>();
            containerRegistry.RegisterForNavigation<AchievementPage, AchievementPageViewModel>();
            containerRegistry.RegisterForNavigation<MasterDetailNavPage, MasterDetailNavPageViewModel>();
            containerRegistry.RegisterForNavigation<ViewAccountPage, ViewAccountPageViewModel>();
            containerRegistry.RegisterForNavigation<CreateAccountPage, CreateAccountPageViewModel>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);

            Type  module1 = typeof(AuthenticationModule);
            moduleCatalog.AddModule(new ModuleInfo()
            {
                ModuleName = module1.Name,
                ModuleType = module1,
                InitializationMode = InitializationMode.WhenAvailable
            });

            Type module2 = typeof(AccountModule);
            moduleCatalog.AddModule(new ModuleInfo()
            {
                ModuleName = module2.Name,
                ModuleType = module2,
                InitializationMode = InitializationMode.OnDemand
            });
        }
    }
}
