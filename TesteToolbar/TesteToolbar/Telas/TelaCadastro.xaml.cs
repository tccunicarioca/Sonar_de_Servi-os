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
    public partial class TelaCadastro : ContentPage
    {
        //Essa é a tela CadastroViewPage
        private Usuario usuario;
        //Esse dataServie não vai servier
        private UsuarioDataService dataService;

        public TelaCadastro()
        {
            InitializeComponent();
            usuario = new Usuario();
        }

        void OnCadastrar(object sender, EventArgs args)
        {
            OnValidar();

            usuario.Nome = entNome.Text;
            usuario.Cpf = entCpf.Text;
            usuario.Endereco = entEndereco.Text;
            usuario.Celular = entCelular.Text;
            usuario.Telefone = entTel.Text;
            usuario.Telefone = entComercial.Text;
            usuario.Email = entEmail.Text;


        }
        void OnLimpar()
        {
            entNome.Text = "";
            entCpf.Text = "";
            entEndereco.Text = "";
            entCelular.Text = "";
            entTel.Text = "";
            entComercial.Text = "";
            entEmail.Text = "";
        }


        void OnValidar()
        {
            if (string.IsNullOrEmpty(entNome.Text))
            {
                DisplayAlert("Error", "Campo Nome vazio", "Ok");
                return;
            }
            if (string.IsNullOrEmpty(entCpf.Text))
            {
                DisplayAlert("Error", "Campo Cpf/Cnpj vazio", "Ok");
                return;
            }
            if (string.IsNullOrEmpty(entEndereco.Text))
            {
                DisplayAlert("Error", "Campo Endereço vazio", "Ok");
                return;
            }
            if (string.IsNullOrEmpty(entEmail.Text))
            {
                DisplayAlert("Error", "Campo Email vazio", "Ok");
                return;
            }
        }

        private void ToolbarItem_Busca(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TelaInicial());
        }
        private void ToolbarItem_Login(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TelaLogin());
        }
        private void ToolbarItem_Ultimas(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TelaUltimasBuscas());
        }
    }
}