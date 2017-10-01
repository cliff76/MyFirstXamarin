using Xamarin.Forms;

namespace HelloWorld
{
    public partial class HelloWorldPage : ContentPage
    {
        public HelloWorldPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Ouch!", "You clicked me.", "Go On.");
        }
    }
}
