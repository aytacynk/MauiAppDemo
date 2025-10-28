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

        private void Entry_Completed(object sender, EventArgs e)
        {
            Entry entry = (Entry)sender;// sender'ı Entry olarak tanımladık
            DisplayAlert("Entry Tamamlandı", $"Girdiğiniz metin:  {entry.Text}", "OK");// Entry içindeki Text değerini aldık

        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value == true)
            {
                RadioButton radioButton = (RadioButton)sender;
                selectedColorLabel.Text = $"Seçilen renk: {radioButton.Content}";
            }
        }

        //private void GirisYap_Clicked(object sender, EventArgs e)
        //{
        //    //Kullanıcı giriş yaptıktan sonra alanları temizle
        //    if (string.IsNullOrEmpty(entryPassword.Text) || string.IsNullOrEmpty(entryEmail.Text))
        //    {
        //        DisplayAlert("Hata", "Email veya Parola boş olamaz", "OK");
        //        return;
        //    }

        //    if (entryEmail.Text.ToString() == "aytacyanik@" && entryPassword.Text.ToString() == "123456")
        //    {
        //        DisplayAlert("Giriş Yapıldı", $"Email: {entryEmail.Text} \nPassword: {entryPassword.Text}", "OK");
        //    }
        //    else
        //    {
        //        DisplayAlert("Hata", "Email veya Parola Hatalı", "OK");
        //    }

        //}
    }
}
