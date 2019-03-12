using System;
using Prism;
using Prism.Ioc;
using Prism.Modularity;
using SaverMate.Data;
using SaverMate.ViewModels;
using SaverMate.Views;
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
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<RewardShopPage, RewardShopPageViewModel>();
            containerRegistry.RegisterForNavigation<DashboardPage, DashboardPageViewModel>();
            containerRegistry.RegisterForNavigation<TabNavPage, TabNavPageViewModel>();
            containerRegistry.RegisterForNavigation<AchievementPage, AchievementPageViewModel>();
            containerRegistry.RegisterForNavigation<MasterDetailNavPage, MasterDetailNavPageViewModel>();


        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);

            Type moduleCType = typeof(Authentication.AuthenticationModule);
            moduleCatalog.AddModule(new ModuleInfo()
            {
                ModuleName = moduleCType.Name,
                ModuleType = moduleCType,
                InitializationMode = InitializationMode.WhenAvailable
            });
        }
    }
}
