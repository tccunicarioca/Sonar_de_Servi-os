using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteToolbar.Telas;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesteToolbar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelaLogin : ContentPage
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        void OnEntrar(object sender, EventArgs args)
        {
            if (string.IsNullOrEmpty(entEmail.Text))
            {
                DisplayAlert("Error", "Campo Email vazio", "Ok");
                return;
            }
            if (string.IsNullOrEmpty(entSenha.Text))
            {
                DisplayAlert("Error", "Campo Senha vazio", "Ok");
                return;
            }
            
        }

        private void ToolbarItem_Busca(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TelaInicial());
        }
        private void ToolbarItem_Cadastro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TelaCadastro());
        }
        private void ToolbarItem_Ultimas(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TelaUltimasBuscas());
        }
    }
}