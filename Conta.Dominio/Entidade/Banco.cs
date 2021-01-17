using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Conta.Dominio.Entidade
{
    public class Banco
    {

        [Key]
        public long Id { get; protected set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string Codigo { get; protected set; }
        [Required]
        [Column(TypeName = "varchar(250)")]
        public string Descricao { get; protected set; }

        public Banco(string codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }
    }
}
