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

namespace SaverMate.ViewModels
{
	public class DashboardPageViewModel : ViewModelBase
	{

        public ICommand ClickedCommand { get; set; }
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
            ClickedCommand = new Command(() => FireCommand());
        }

        private void FireCommand()
        {
            NavigationService.NavigateAsync("ViewA");
        }

        public void LoadData()
	    {

	    }
	}
}
