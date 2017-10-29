using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteToolbar.DataService;
using TesteToolbar.Entidades;
using TesteToolbar.Telas;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesteToolbar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelaInicial : ContentPage
    {
        UsuarioDataService dataService;
        List<Usuario> usuarios;

        public TelaInicial()
        {
            InitializeComponent();
            dataService = new UsuarioDataService();
        }

        async void OnBuscaDados()
        {
            if (string.IsNullOrEmpty(entEnd.Text))
            {
                DisplayAlert("Error", "Campo Endereço vazio", "Ok");
                return;
            }
            
            Navigation.PushAsync(new TelaLista());
        }

        private void ToolbarItem_Cadastro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TelaCadastro());
        }
        private void ToolbarItem_Login(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TelaLogin());
        }
        private void ToolbarItem_Ultima(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TelaUltimasBuscas());
        }
    }
}