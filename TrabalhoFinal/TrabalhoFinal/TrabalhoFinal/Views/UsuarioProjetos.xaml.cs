using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace TrabalhoFinal.Views
{
    public partial class UsuarioRepositorios : ContentPage
    {
        public UsuarioRepositorios()
        {
            InitializeComponent();
        }


        protected async void ListarProjetos(object sender, EventArgs e)
        {
            var gitHubRepositories = new GitHubRepositories();
            var lista = await gitHubRepositories.GetRepositories(usuario.Text);
            repositories.ItemsSource = lista;
        }


    }
}
