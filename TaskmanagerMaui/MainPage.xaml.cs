namespace TaskmanagerMaui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        

        private async void GoMembersPage(object sender, EventArgs e)
        {
           
            await Navigation.PushAsync(new MembersPage());
        }
    }
}
