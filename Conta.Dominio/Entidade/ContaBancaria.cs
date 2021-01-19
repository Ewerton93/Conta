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
        public Banco Banco { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public string NumeroConta { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public string NumeroAgencia { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Cpf { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Cnpj { get; set; }

        [Column(TypeName = "varchar(150)")]
        public string Nome { get;  set; }

        [Column(TypeName = "varchar(150)")]
        public string RazaoSocial { get;  set; }

        [Required]
        public DateTime DataAbertura { get; set; }

        [Required]
        public bool Status { get; set; }

        public ContaBancaria()
        {

        }

        public ContaBancaria(Banco banco, string numeroConta, string numeroAgencia, string cpf, string nome, string cnpj, string razaoSocial, DateTime dataAbertura)
        {
            Banco = banco;
            NumeroConta = numeroConta;
            NumeroAgencia = numeroAgencia;
            Cpf = cpf;
            Nome = nome;
            Cnpj = cnpj;
            RazaoSocial = razaoSocial;
            DataAbertura = dataAbertura;
        }

        public void Atualizar(Banco banco, string numeroConta, string numeroAgencia, string cpf, string nome, string cnpj, string razaoSocial)
        {
            Banco = banco;
            NumeroConta = numeroConta;
            NumeroAgencia = numeroAgencia;
            Cpf = cpf;
            Nome = nome;
            Cnpj = cnpj;
            RazaoSocial = razaoSocial;
        }

        public void SetAtivar() => Status = true;

        public void SetInativar() => Status = false;
    }

}
