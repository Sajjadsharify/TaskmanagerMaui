namespace TaskmanagerMaui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            MainPage = new NavigationPage(new MainPage());
            MembersPage = new NavigationPage(new MembersPage());

        }

        public NavigationPage MembersPage { get; private set; }
    }
}
