using Microsoft.Maui;

namespace TP01___PDM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnSubmit(object sender, EventArgs e)
        {
            if (IdEntry.Text == "admin" && PasswordEntry.Text == "senha@dmin")
            {
                await DisplayAlert("Alert", "Logado com sucesso!", "OK");
                OnClear(sender, e);
            } else
            {
                await DisplayAlert("Alert", "Login não autorizado!", "OK");
            }
        }


        private  void OnClear(object sender, EventArgs e)
        {
            IdEntry.Text = string.Empty;
            PasswordEntry.Text = string.Empty;
            IdEntry.Focus();
        }

        private async void OnViewCredits(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Creditos());
        }

        private void ShowPassword_Clicked(object sender, EventArgs e)
        {
            PasswordEntry.IsPassword = !PasswordEntry.IsPassword;
        }
    }
}