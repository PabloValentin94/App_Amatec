namespace App_Amatec.Pages;

public partial class Animes : ContentPage
{

	public Animes()
	{

		InitializeComponent();

	}

    // O método abaixo, é executado toda vez que a página for carregada.

    protected override async void OnAppearing()
    {

        try
        {

            imgbtn_demon_slayer.Source = ImageSource.FromResource("App_Amatec.Assets.Images.Animes.01.jpg");

            imgbtn_solo_leveling.Source = ImageSource.FromResource("App_Amatec.Assets.Images.Animes.02.jpg");

            imgbtn_kaiju_n8.Source = ImageSource.FromResource("App_Amatec.Assets.Images.Animes.03.jpg");

        }

        catch(Exception ex)
        {

            await DisplayAlert("Erro!", ex.Message, "OK");

        }

    }

    private async void imgbtn_demon_slayer_Clicked(object sender, EventArgs e)
    {

        try
        {



        }

        catch (Exception ex)
        {

            await DisplayAlert("Erro!", ex.Message, "OK");

        }

    }

    private async void imgbtn_solo_leveling_Clicked(object sender, EventArgs e)
    {

        try
        {



        }

        catch (Exception ex)
        {

            await DisplayAlert("Erro!", ex.Message, "OK");

        }

    }

    private async void imgbtn_kaiju_n8_Clicked(object sender, EventArgs e)
    {

        try
        {



        }

        catch (Exception ex)
        {

            await DisplayAlert("Erro!", ex.Message, "OK");

        }

    }

}