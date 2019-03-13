using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Prism.Navigation;
using Xamarin.Forms;

namespace SaverMate.ViewModels.Accounts
{
	public class ViewAccountPageViewModel : ViewModelBase
	{
        public ICommand GoBackCommand { get; set; }

		public ViewAccountPageViewModel(INavigationService navigationService) : base(navigationService)
		{
            LoadCommands();
		}
	
        private void LoadCommands()
        {
            GoBackCommand = new Command(() => GoBack());
        }

        private void GoBack()
        {
            NavigationService.GoBackAsync(useModalNavigation: true);
        }
	}
}
