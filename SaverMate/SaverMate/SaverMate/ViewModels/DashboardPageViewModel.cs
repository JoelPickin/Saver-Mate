using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Prism.Navigation;

namespace SaverMate.ViewModels
{
	public class DashboardPageViewModel : ViewModelBase
	{

		public DashboardPageViewModel(INavigationService navigationService)
			: base(navigationService)
		{

		}

	    public override void OnNavigatedFrom(INavigationParameters parameters)
	    {
	        base.OnNavigatedFrom(parameters);
	    }

	    public override void OnNavigatedTo(INavigationParameters parameters)
	    {
	        base.OnNavigatedTo(parameters);

	        var x = 0;
	    }

	    public void LoadData()
	    {

	    }
	}
}
