using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteToolbar.Entidades
{
    [Table("ULTIMOS_VISTOS")]
    public class Usuario
    {
        [Column("ID")]
        [PrimaryKey]
        public int Id { get; set; }

        [Column("NOME")]
        [MaxLength(150)]
        public string Nome { get; set; }

        [Column("CPF/CNPJ")]
        [MaxLength(20)]
        public string Cpf { get; set; }

        [Column("ENDERECO")]
        [MaxLength(200)]
        public string Endereco { get; set; }

        [Column("CELULAR")]
        [MaxLength(20)]
        public string Celular { get; set; }

        [Column("TELEFONE")]
        [MaxLength(20)]
        public string Telefone { get; set; }

        [Column("TEL.COMERCIAL")]
        [MaxLength(20)]
        public string TelComercia { get; set; }

        [Column("EMAIL")]
        [MaxLength(50)]
        public string Email { get; set; }

        [Column("AVALIACAO")]
        [MaxLength(20)]
        public string Avaliacao { get; set; }


    }
}
