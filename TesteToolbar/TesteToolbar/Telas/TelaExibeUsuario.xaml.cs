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
    public partial class TelaExibeUsuario : ContentPage
    {
        private Usuario usuario;
        private UsuarioDataService userDataService;

        public TelaExibeUsuario()
        {
            InitializeComponent();
            usuario = new Usuario();
            
        }

        public TelaExibeUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            
            CarregaUsuario(usuario);


            try
            {
                userDataService.Salvar(usuario);
                DisplayAlert("Aviso", "Incluída na tela de últimas buscas", "Ok");
            }
            catch (Exception)
            {
                DisplayAlert("Aviso", "Não incluído na tela de últimas buscas", "Ok");
            }

        }

        private void CarregaUsuario(Usuario usuario)
        {
            lblNome.Text = usuario.Nome;
            lblCpfCnpj.Text = usuario.Cpf;
            lblEndereco.Text = usuario.Endereco;
            lblCelular.Text = usuario.Celular;
            lblTelefone.Text = usuario.Telefone;
            lblTelComercial.Text = usuario.TelComercia;
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
        private void ToolbarItem_Login(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TelaLogin());
        }
    }
}