namespace App_Amatec;

public partial class Home : ContentPage
{

	public Home()
	{

		InitializeComponent();

	}

	// O método abaixo, é executado toda vez que a página for carregada.

    protected override void OnAppearing()
    {

        img_icone.Source = ImageSource.FromResource("App_Amatec.Assets.Icon.png");

    }

}