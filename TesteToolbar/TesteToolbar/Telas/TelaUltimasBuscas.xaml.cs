using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesteToolbar.Telas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelaUltimasBuscas : ContentPage
    {
        public TelaUltimasBuscas()
        {
            InitializeComponent();
        }

        void OnUsuarioClicado(object sender, ItemTappedEventsArgs e)
        {
            Navigation.PushAsync(new TelaExibeUsuario()); 
        }

        void ToolbarItem_Busca(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TelaInicial());
        }
        void ToolbarItem_Cadastro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TelaCadastro());
        }
        void ToolbarItem_Login(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TelaLogin());
        }
    }
}