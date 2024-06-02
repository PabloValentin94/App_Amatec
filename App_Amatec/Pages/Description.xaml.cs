using App_Amatec.Model;

namespace App_Amatec.Pages;

public partial class Description : ContentPage
{

	public Description()
	{

		InitializeComponent();

	}

    protected override async void OnAppearing()
    {

        try
        {

            Content conteudo = (Content)this.BindingContext;

            img_poster.Source = ImageSource.FromResource(conteudo.poster);

            lbl_meio_consumo.Text = "Meio de\nConsumo:";

            lbl_data_lancamento.Text = "Data de\nLançamento:";

            txt_data_lancamento.Text = conteudo.data_lancamento.ToString("dd/MM/yyyy");

        }

        catch (Exception ex)
        {

            await DisplayAlert("Erro!", ex.Message, "OK");

        }

    }

    private async void btn_voltar_Clicked(object sender, EventArgs e)
    {

		try
		{

            await Navigation.PopAsync();

        }

		catch(Exception ex)
		{

			await DisplayAlert("Erro!", ex.Message, "OK");

		}

    }

}