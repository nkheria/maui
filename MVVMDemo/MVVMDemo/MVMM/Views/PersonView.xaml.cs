using MVVMDemo.MVMM.Models;
using MVVMDemo.MVMM.ViewModels;

namespace MVVMDemo.MVMM.Views;

public partial class PersonView : ContentPage
{
	public PersonView()
	{
		InitializeComponent();

		BindingContext = new PersonViewModel();
	}
}