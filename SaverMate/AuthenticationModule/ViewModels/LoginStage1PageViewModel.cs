using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Authentication.Views;
using Prism.Navigation;
using Xamarin.Forms;

namespace Authentication.ViewModels
{
	public class LoginStage1PageViewModel : BindableBase
	{
        public INavigationService NavigationService { get; set; }
        public ICommand LoginCommand { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        
        public LoginStage1PageViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
            LoadCommands();     
        }

        private void LoadCommands()
        {
            LoginCommand = new Command(() => GoToNextLoginStage());
        }

        private void GoToNextLoginStage()
        {
            var x = Username;
            var y = Password;
            NavigationService.NavigateAsync("LoginStage2");
        }
    }
}
