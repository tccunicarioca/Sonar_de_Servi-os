using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteToolbar.Entidades;
using Xamarin.Forms;

namespace TesteToolbar.DataService
{
    public class UsuarioDataService: ISQLiteOperation
    {
        private SQLiteConnection _conexao;

        public UsuarioDataService()
        {
            _conexao = DependencyService.Get<ISQLite>().GetConnection();
            _conexao.CreateTable<Usuario>();
        }
        public void Salvar(Usuario usuario)
        {
            _conexao.Insert(usuario);
        }

        public IList<Usuario> Select()
        {
            return _conexao.Table<Usuario>().ToList();
        }

        internal Task<List<Usuario>> GetListUsuario()
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Usuario usuario)
        {
            _conexao.Update(usuario);
        }
        public void Excluir(Usuario usuario)
        {
            _conexao.Delete(usuario);
        }
               
    }
}
