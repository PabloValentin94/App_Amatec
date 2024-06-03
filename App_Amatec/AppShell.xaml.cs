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