using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using SaverMate.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace SaverMate.ViewModels.Overview
{
    public class OverviewPageViewModel : ViewModelBase
    {
        public ICommand GoToCreateAccountPageCommand { get; set; }
        public ICommand GoToAccountPageCommand { get; set; }
        public ObservableCollection<Account> Accounts { get; set; }
        public OverviewPageViewModel(INavigationService navigationService)
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
            GoToAccountPageCommand = new Command(async ()=> await NavigationService.NavigateAsync("AccountPage", useModalNavigation: true));
            GoToCreateAccountPageCommand = new Command(async ()=> await NavigationService.NavigateAsync("CreateAccountPage"));
            
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
