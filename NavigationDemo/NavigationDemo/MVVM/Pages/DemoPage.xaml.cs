using NavigationDemo.Utilities;

namespace NavigationDemo.MVVM.Pages;

public partial class DemoPage : ContentPage
{
	public DemoPage()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        NavUtilities.Examine(Navigation);
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }
}