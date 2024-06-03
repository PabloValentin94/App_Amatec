using App_Amatec.Model;

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

            imgbtn_ninja_kamui.Source = ImageSource.FromResource("App_Amatec.Assets.Images.Animes.04.jpg");

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

    private async void imgbtn_ninja_kamui_Clicked(object sender, EventArgs e)
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

}