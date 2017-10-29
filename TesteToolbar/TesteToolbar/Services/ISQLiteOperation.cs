using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteToolbar.Entidades;

namespace TesteToolbar.DataService
{
    interface ISQLiteOperation
    {
        void Salvar(Usuario usuario);
        void Excluir(Usuario usuario);
        void Atualizar(Usuario usuario);

        IList<Usuario> Select();
    }
}
