using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TrabalhoFinal.Views
{
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }

        protected async void Cadastro(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.UsuarioCadastro());
        }

        protected async void Projetos(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.UsuarioRepositorios());
        }

    }
}
