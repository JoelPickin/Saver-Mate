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
using SaverMate.Models;

namespace SaverMate.ViewModels.Dashboard
{
	public class DashboardPageViewModel : ViewModelBase
	{

		public ICommand GoToAccountPageCommand { get; set; }
        public ObservableCollection<Account> Accounts { get; set; }

        public DashboardPageViewModel(INavigationService navigationService)
			: base(navigationService)
        {
			LoadCommands(); 
            Accounts = LoadData();
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

        public ObservableCollection<Account> LoadData()
        {
            return new ObservableCollection<Account>
            {
                new Account
                {
                    Id = 1,
                    Title = "Sell on Ebay",
                    Value = 101.12m,
                    Notes = "Blah Blah Blah",
                    HasPositiveAction = true,
                    HasNegativeAction = true
                },
                new Account
                {
                    Id = 2,
                    Title = "Side Hustle",
                    Value = 12.12m,
                    Notes = "Blah Blah Blah",
                    HasPositiveAction = true,
                    HasNegativeAction = false
                },
                new Account
                {
                    Id = 3,
                    Title = "Savings",
                    Value = 1201.12m,
                    Notes = "Blah Blah Blah",
                    HasPositiveAction = true,
                    HasNegativeAction = true
                }
            };
        }
    }
}
