using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Conta.Dominio.Entidade
{
    public class ContaBancaria
    {
        [Key]
        public long Id { get; protected set; }

        [Required]
        public Banco Banco { get; protected set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public string NumeroConta { get; protected set; }

        [Required]
        [Column(TypeName = "varchar(16)")]
        public string NumeroAgencia { get; protected set; }

        [Column(TypeName = "varchar(16)")]
        public string Cpf { get; protected set; }

        [Column(TypeName = "varchar(16)")]
        public string Cnpj { get; protected set; }

        [Column(TypeName = "varchar(150)")]
        public string Nome { get; protected set; }

        [Column(TypeName = "varchar(150)")]
        public string RazaoSocial { get; protected set; }

        [Required]
        public DateTime DataAbertura { get; protected set; }

        public ContaBancaria()
        {

        }

        public ContaBancaria CriarContaPessoaFisica(Banco banco, string numeroConta, string numeroAgencia, string cpf, string nome, DateTime dataAbertura)
        {
            Banco = banco;
            NumeroConta = numeroConta;
            NumeroAgencia = numeroAgencia;
            Cpf = cpf;
            Nome = nome;
            DataAbertura = dataAbertura;

            return this;
        }

        public ContaBancaria CriarContaPessoaJuridica(Banco banco, string numeroConta, string numeroAgencia, string cnpj, string razaoSocial, DateTime dataAbertura)
        {
            Banco = banco;
            NumeroConta = numeroConta;
            NumeroAgencia = numeroAgencia;
            Cnpj = cnpj;
            RazaoSocial = razaoSocial;
            DataAbertura = dataAbertura;

            return this;
        }

    }

}
