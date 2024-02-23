using Person = DataBindingDemo.Models.Person;

namespace DataBindingDemo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            var person = new Person
            {
                Name = "John",
                Phone = "987654321",
                Address = "X Address"
            };

            txtName.BindingContext = person;
            txtName.SetBinding(Label.TextProperty, "Name");

            BindingContext = person;

            //Binding personBinding = new Binding();

            //personBinding.Source = person;
            //personBinding.Path = "Name";
            
            //txtName.SetBinding(Label.TextProperty, personBinding);

        }
    }

}
