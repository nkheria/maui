using NavigationDemo.Utilities;

namespace NavigationDemo.MVVM.Pages;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

  //  public Page2(string name)
  //  {
  //      InitializeComponent();
		//txtName.Text = name;
  //  }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        NavUtilities.Examine(Navigation);
    }
    private void Button_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Page3());
	}

	private void Button_Clicked_1(object swnder, EventArgs e)
	{
		Navigation.PopAsync();
	}
}