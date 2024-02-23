namespace StyleDemo;

public partial class DynamicStylesView : ContentPage
{
	public DynamicStylesView()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Resources["dynamicStyle"] =
			Resources["greenStyle"];
    }
}