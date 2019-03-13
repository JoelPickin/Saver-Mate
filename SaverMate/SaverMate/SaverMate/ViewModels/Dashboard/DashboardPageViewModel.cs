using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Prism.Modularity;
using Prism.Navigation;
using Xamarin.Forms;

namespace SaverMate.ViewModels.Dashboard
{
	public class DashboardPageViewModel : ViewModelBase
	{

		public ICommand GoToAccountPageCommand { get; set; }

		public DashboardPageViewModel(INavigationService navigationService)
			: base(navigationService)
        {
			LoadCommands();  
		}

		public override void OnNavigatedFrom(INavigationParameters parameters)
		{
			base.OnNavigatedFrom(parameters);
		}

		public override void OnNavigatedTo(INavigationParameters parameters)
		{
			base.OnNavigatedTo(parameters);
		}

		private void LoadCommands()
		{
			GoToAccountPageCommand = new Command(() => GoToAccountPage());
		}

        private void GoToAccountPage()
        {
            NavigationService.NavigateAsync("AccountPage", useModalNavigation: true);
        }
	}
}
