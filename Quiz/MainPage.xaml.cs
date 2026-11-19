namespace Quiz
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnIniciarClicked(object sender, EventArgs e)
        {
            //PUSH TO NEXT PAGE
            await Navigation.PushAsync(new Q1());
        }
    }
}
