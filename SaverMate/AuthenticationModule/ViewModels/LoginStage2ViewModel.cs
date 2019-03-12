using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Prism.Navigation;
using Xamarin.Forms;

namespace Authentication.ViewModels
{
	public class LoginStage2ViewModel : BindableBase
	{
        public ICommand LoginCommand { get; set; }
        public INavigationService NavigationService { get; set; }
        public LoginStage2ViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
            LoadCommands();
        }

        private void LoadCommands()
        {
            LoginCommand = new Command(() => Login());
        }

        private void Login()
        {
            NavigationService.NavigateAsync("MasterDetailNavPage/TabNavPage");
        }
    }
}
