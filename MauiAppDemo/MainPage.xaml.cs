namespace MauiAppDemo
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
            //count++;

            //if (count == 1)
            //    CounterBtn.Text = $"Clicked {count} time";
            //else
            //    CounterBtn.Text = $"Clicked {count} times";

            //SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void Click_Tapped(object sender, TappedEventArgs e)
        {
            //DisplayAlert("Tıklandı", "Label üstüne tıkladınız", "OK");
            // btnLorem.Text = "Butona Tıklandı";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //DisplayAlert("Butona Tıklandı", "Tıklama Başarılı", "Klar");
        }
    }
}
