using System;
using System.Collections.Generic;
using System.Text;

namespace Conta.Common.ViewModel.Entrada
{
    class ContaBancariaEntrada
    {
        public long Id { get; set; }

        public long BancoId { get; set; }

        public string BancoCodigo { get; set; }

        public string BancoDescricao { get; set; }

        public string NumeroConta { get; set; }

        public string NumeroAgencia { get; set; }

        public string Cpf { get; set; }

        public string Cnpj { get;  set; }

        public string Nome { get; set; }

        public string RazaoSocial { get; set; }

        public DateTime DataAbertura { get; set; }

        public bool Status { get; set; }

        public ContaBancariaEntrada()
        {

        }

    }
}
