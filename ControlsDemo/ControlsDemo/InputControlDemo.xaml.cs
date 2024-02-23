using System.Diagnostics;

namespace ControlsDemo;

public partial class InputControlDemo : ContentPage
{
	public InputControlDemo()
	{
		InitializeComponent();
	}

	private void sliderValueChanged(object sender, ValueChangedEventArgs e)
	{
		lblSlider.Text = slider.Value.ToString();
	}

	private void stepperValueChanged(object sender, ValueChangedEventArgs e) 
	{
		if (stepper != null)
		{
			lblSlider.Text = stepper.Value.ToString();
		}
	}

	private void Entry_TextChanged(object sender, TextChangedEventArgs e)
	{
		Debug.WriteLine(txtName.Text);
	}
}