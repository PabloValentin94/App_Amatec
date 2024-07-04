namespace App_Amatec;

public partial class Home : ContentPage
{

	public Home()
	{

		InitializeComponent();

	}

    // O m�todo abaixo, � executado toda vez que a p�gina for carregada.

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