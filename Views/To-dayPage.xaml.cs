using Xamarin.Forms;

namespace Today.Views
{
    public partial class To_dayPage : ContentPage
    {
        public To_dayPage()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Items());
            Application.Current.MainPage = new Items();
        }
    }
}
