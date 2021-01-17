using Conta.Dados.Intefarce;
using Conta.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conta.Dados.Repositorio
{
    public class BancoRepositorio : BaseRepositorio<Banco>, IBancoRepositorio
    {
        public BancoRepositorio(ContaContexto _contaContexto) : base(_contaContexto)
        {

        }
    }
}
