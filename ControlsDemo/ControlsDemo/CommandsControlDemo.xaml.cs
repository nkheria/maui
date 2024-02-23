namespace ControlsDemo;

public partial class CommandsControlDemo : ContentPage
{
	public CommandsControlDemo()
	{
		InitializeComponent();
	}

	private void btnTest_Clicked(object sender, EventArgs e)
	{
		DisplayAlert("Example Alert", "Welcome to sample alert box!", "OK");
	}

	private void RadioButton_Change(object sender, CheckedChangedEventArgs e)
	{
		DisplayAlert("Radio Button Alert", $"Changed: {e.Value}", "OK");
	}

	private void SearchControlPressed(object sender, EventArgs e)
	{
		DisplayAlert("Search Box Alert", $"Searching: {searchControl.Text}", "OK");
	}
}