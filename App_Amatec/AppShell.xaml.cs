using App_Amatec.Pages;

namespace App_Amatec
{

    public partial class AppShell : Shell
    {

        public AppShell()
        {

            InitializeComponent();

            Load();

        }

        private async void Load()
        {

            try
            {

                // Ícones - Abas inferiores:

                tab_about.Icon = ImageSource.FromResource("App_Amatec.Assets.Images.Icons.About.png");

                tab_content.Icon = ImageSource.FromResource("App_Amatec.Assets.Images.Icons.Content.png");

                // Páginas - Abas superiores:

                page_animes.Content = new Animes();

                page_movies.Content = new Movies();

                page_series.Content = new Series();

            }

            catch(Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

    }

}