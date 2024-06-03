using App_Amatec.Model;

namespace App_Amatec.Pages;

public partial class Series : ContentPage
{

	public Series()
	{

		InitializeComponent();

	}

    // O método abaixo, é executado toda vez que a página for carregada.

    protected override async void OnAppearing()
    {

        try
        {

            imgbtn_bridgerton.Source = ImageSource.FromResource("App_Amatec.Assets.Images.Series.01.jpg");

            imgbtn_bebe_rena.Source = ImageSource.FromResource("App_Amatec.Assets.Images.Series.02.jpg");

            imgbtn_fallout.Source = ImageSource.FromResource("App_Amatec.Assets.Images.Series.03.jpg");

            imgbtn_avatar_a_lenda_de_aang_2024.Source = ImageSource.FromResource("App_Amatec.Assets.Images.Series.04.jpg");

        }

        catch (Exception ex)
        {

            await DisplayAlert("Erro!", ex.Message, "OK");

        }

    }

    private async void imgbtn_bridgerton_Clicked(object sender, EventArgs e)
    {

        try
        {

            Description description_page = new Description();

            description_page.BindingContext = Examples.series[0];

            await Navigation.PushAsync(description_page);

        }

        catch (Exception ex)
        {

            await DisplayAlert("Erro!", ex.Message, "OK");

        }

    }

    private async void imgbtn_bebe_rena_Clicked(object sender, EventArgs e)
    {

        try
        {

            Description description_page = new Description();

            description_page.BindingContext = Examples.series[1];

            await Navigation.PushAsync(description_page);

        }

        catch (Exception ex)
        {

            await DisplayAlert("Erro!", ex.Message, "OK");

        }

    }

    private async void imgbtn_fallout_Clicked(object sender, EventArgs e)
    {

        try
        {

            Description description_page = new Description();

            description_page.BindingContext = Examples.series[2];

            await Navigation.PushAsync(description_page);

        }

        catch (Exception ex)
        {

            await DisplayAlert("Erro!", ex.Message, "OK");

        }

    }

    private async void imgbtn_avatar_a_lenda_de_aang_2024_Clicked(object sender, EventArgs e)
    {

        try
        {

            Description description_page = new Description();

            description_page.BindingContext = Examples.series[3];

            await Navigation.PushAsync(description_page);

        }

        catch (Exception ex)
        {

            await DisplayAlert("Erro!", ex.Message, "OK");

        }

    }

}