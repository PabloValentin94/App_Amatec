namespace App_Amatec;

public partial class Home : ContentPage
{

	public Home()
	{

		InitializeComponent();

	}

	// O m�todo abaixo, � executado toda vez que a p�gina for carregada.

    protected override void OnAppearing()
    {

        img_icone.Source = ImageSource.FromResource("App_Amatec.Assets.Icon.png");

    }

}