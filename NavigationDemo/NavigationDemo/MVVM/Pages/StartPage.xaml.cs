using NavigationDemo.Utilities;
using NavigationDemo.ViewModels;

namespace NavigationDemo.MVVM.Pages;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
		BindingContext = new StartPageViewModel();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        NavUtilities.Examine(Navigation);
    }

    private void Button_Clicked(object sender, EventArgs e)
	{
		var currentViewModel = 
			((StartPageViewModel)BindingContext).Name;
		Navigation.PushAsync(new Page2
		{
			BindingContext = new Page2ViewModel
			{
				Name = currentViewModel
			}
		};
		
	}
}