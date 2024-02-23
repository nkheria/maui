using MVVMDemo.MVMM.ViewModels;

namespace MVVMDemo.MVMM.Views;

public partial class ConverterDemo : ContentPage
{
	public ConverterDemo()
	{
		InitializeComponent();

		BindingContext = new ConverterViewModel();
	}
}