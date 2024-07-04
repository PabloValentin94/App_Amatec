namespace App_Amatec;

public partial class Home : ContentPage
{

	public Home()
	{

		InitializeComponent();

	}

    // O método abaixo, é executado toda vez que a página for carregada.

    protected override async void OnAppearing()
    {

        try
        {

            img_icone.Source = ImageSource.FromResource("App_Amatec.Assets.Images.Image.png");

        }

        catch (Exception ex)
        {

            await DisplayAlert("Erro!", ex.Message, "OK");

        }

    }

}