namespace App_Amatec.Pages;

public partial class Movies : ContentPage
{

	public Movies()
	{

		InitializeComponent();

	}

    // O método abaixo, é executado toda vez que a página for carregada.

    protected override async void OnAppearing()
    {

        try
        {

            imgbtn_deadpool_03.Source = ImageSource.FromResource("App_Amatec.Assets.Images.Movies.01.jpg");

            imgbtn_como_eu_era_antes_de_voce.Source = ImageSource.FromResource("App_Amatec.Assets.Images.Movies.02.jpg");

            imgbtn_o_rei_leao.Source = ImageSource.FromResource("App_Amatec.Assets.Images.Movies.03.jpg");

        }

        catch (Exception ex)
        {

            await DisplayAlert("Erro!", ex.Message, "OK");

        }

    }

    private async void imgbtn_deadpool_03_Clicked(object sender, EventArgs e)
    {

        try
        {



        }

        catch (Exception ex)
        {

            await DisplayAlert("Erro!", ex.Message, "OK");

        }

    }

    private async void imgbtn_como_eu_era_antes_de_voce_Clicked(object sender, EventArgs e)
    {

        try
        {



        }

        catch (Exception ex)
        {

            await DisplayAlert("Erro!", ex.Message, "OK");

        }

    }

    private async void imgbtn_o_rei_leao_Clicked(object sender, EventArgs e)
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