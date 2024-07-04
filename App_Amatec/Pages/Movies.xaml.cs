using App_Amatec.Model;

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

            imgbtn_uma_ideia_de_voce.Source = ImageSource.FromResource("App_Amatec.Assets.Images.Movies.02.jpg");

            imgbtn_mufasa_o_rei_leao.Source = ImageSource.FromResource("App_Amatec.Assets.Images.Movies.03.jpg");

            imgbtn_venom_03.Source = ImageSource.FromResource("App_Amatec.Assets.Images.Movies.04.jpg");

            imgbtn_operacao_natal.Source = ImageSource.FromResource("App_Amatec.Assets.Images.Movies.05.jpg");

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

            Description description_page = new Description();

            description_page.BindingContext = Examples.movies[0];

            await Navigation.PushAsync(description_page);

        }

        catch (Exception ex)
        {

            await DisplayAlert("Erro!", ex.Message, "OK");

        }

    }

    private async void imgbtn_uma_ideia_de_voce_Clicked(object sender, EventArgs e)
    {

        try
        {

            Description description_page = new Description();

            description_page.BindingContext = Examples.movies[1];

            await Navigation.PushAsync(description_page);

        }

        catch (Exception ex)
        {

            await DisplayAlert("Erro!", ex.Message, "OK");

        }

    }

    private async void imgbtn_mufasa_o_rei_leao_Clicked(object sender, EventArgs e)
    {

        try
        {

            Description description_page = new Description();

            description_page.BindingContext = Examples.movies[2];

            await Navigation.PushAsync(description_page);

        }

        catch (Exception ex)
        {

            await DisplayAlert("Erro!", ex.Message, "OK");

        }

    }

    private async void imgbtn_venom_03_Clicked(object sender, EventArgs e)
    {

        try
        {

            Description description_page = new Description();

            description_page.BindingContext = Examples.movies[3];

            await Navigation.PushAsync(description_page);

        }

        catch (Exception ex)
        {

            await DisplayAlert("Erro!", ex.Message, "OK");

        }

    }

    private async void imgbtn_operacao_natal_Clicked(object sender, EventArgs e)
    {

        try
        {

            Description description_page = new Description();

            description_page.BindingContext = Examples.movies[4];

            await Navigation.PushAsync(description_page);

        }

        catch (Exception ex)
        {

            await DisplayAlert("Erro!", ex.Message, "OK");

        }

    }

}