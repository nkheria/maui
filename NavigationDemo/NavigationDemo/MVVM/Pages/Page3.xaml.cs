using NavigationDemo.Utilities;

namespace NavigationDemo.MVVM.Pages;

public partial class Page3 : ContentPage
{
	public Page3()
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
		Navigation.PopAsync();
	}

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        //Navigation.PopToRootAsync();
        NavUtilities.InsertPage(Navigation);
    }
}
