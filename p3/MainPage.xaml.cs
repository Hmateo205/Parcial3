namespace p3
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnBoton1Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layouts.ChuckNorris);
        }

        private void OnBoton2Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layouts.Listas());
        }
        private void OnBoton3Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layouts.Imagen());
        }

    }

}
