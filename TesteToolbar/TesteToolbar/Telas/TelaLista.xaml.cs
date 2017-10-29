using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteToolbar.DataService;
using TesteToolbar.Entidades;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesteToolbar.Telas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelaLista : ContentPage
    {
        UsuarioDataService dataService;
        List<Usuario> usuarios;
        private Usuario usuario;

        public TelaLista()
        {
            InitializeComponent();
            //CarouselPage();
            usuario = new Usuario();
        }

        private async Task CarregarListaAsync()
        {
            usuarios = await dataService.GetListUsuario();
            listUsuario.ItemsSource = usuarios.OrderBy(item => item.Nome).ToList();
        }

        void OnUsuarioClicado(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new TelaExibeUsuario());
        }


        private void ToolbarItem_Busca(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TelaInicial());
        }
        private void ToolbarItem_Ultimas(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TelaUltimasBuscas());
        }
        private void ToolbarItem_Cadastro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TelaCadastro());
        }
        private void ToolbarItem_Login(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TelaLogin());
        }
    }
}