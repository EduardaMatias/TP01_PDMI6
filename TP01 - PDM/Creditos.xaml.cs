/* Eduarda Matias e Stefany  */
namespace TP01___PDM;

public partial class Creditos : ContentPage
{
	public Creditos()
	{
		InitializeComponent();
	}

    async void OnBack(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new MainPage());
    }
}