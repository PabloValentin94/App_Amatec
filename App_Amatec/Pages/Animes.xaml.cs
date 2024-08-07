using App_Amatec.Model;

namespace App_Amatec.Pages;

public partial class Animes : ContentPage
{

	public Animes()
	{

		InitializeComponent();

	}

    // O m�todo abaixo, � executado toda vez que a p�gina for carregada.

    protected override async void OnAppearing()
    {

        try
        {

            imgbtn_demon_slayer.Source = ImageSource.FromResource("App_Amatec.Assets.Images.Animes.01.jpg");

            imgbtn_solo_leveling.Source = ImageSource.FromResource("App_Amatec.Assets.Images.Animes.02.jpg");

            imgbtn_kaiju_n8.Source = ImageSource.FromResource("App_Amatec.Assets.Images.Animes.03.jpg");

            imgbtn_wind_breaker.Source = ImageSource.FromResource("App_Amatec.Assets.Images.Animes.04.jpg");

            imgbtn_kenka_dokugaku.Source = ImageSource.FromResource("App_Amatec.Assets.Images.Animes.05.jpg");

            imgbtn_fairy_tail_100_years_quest.Source = ImageSource.FromResource("App_Amatec.Assets.Images.Animes.06.jpg");

        }

        catch (Exception ex)
        {

            await DisplayAlert("Erro!", ex.Message, "OK");

        }

    }

    private async void imgbtn_demon_slayer_Clicked(object sender, EventArgs e)
    {

        try
        {

            Description description_page = new Description();

            description_page.BindingContext = Examples.animes[0];

            await Navigation.PushAsync(description_page);

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

            Description description_page = new Description();

            description_page.BindingContext = Examples.animes[1];

            await Navigation.PushAsync(description_page);

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

            Description description_page = new Description();

            description_page.BindingContext = Examples.animes[2];

            await Navigation.PushAsync(description_page);

        }

        catch (Exception ex)
        {

            await DisplayAlert("Erro!", ex.Message, "OK");

        }

    }

    private async void imgbtn_wind_breaker_Clicked(object sender, EventArgs e)
    {

        try
        {

            Description description_page = new Description();

            description_page.BindingContext = Examples.animes[3];

            await Navigation.PushAsync(description_page);

        }

        catch (Exception ex)
        {

            await DisplayAlert("Erro!", ex.Message, "OK");

        }

    }

    private async void imgbtn_kenka_dokugaku_Clicked(object sender, EventArgs e)
    {

        try
        {

            Description description_page = new Description();

            description_page.BindingContext = Examples.animes[4];

            await Navigation.PushAsync(description_page);

        }

        catch (Exception ex)
        {

            await DisplayAlert("Erro!", ex.Message, "OK");

        }

    }

    private async void imgbtn_fairy_tail_100_years_quest_Clicked(object sender, EventArgs e)
    {

        try
        {

            Description description_page = new Description();

            description_page.BindingContext = Examples.animes[5];

            await Navigation.PushAsync(description_page);

        }

        catch (Exception ex)
        {

            await DisplayAlert("Erro!", ex.Message, "OK");

        }

    }

}