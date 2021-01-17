using Conta.Dados.Intefarce;
using Conta.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conta.Dados.Repositorio
{
    public class ContaBancariaRepositorio : BaseRepositorio<ContaBancaria>, IContaBancariaRepositorio
    {
        public ContaBancariaRepositorio(ContaContexto _contaContexto) : base(_contaContexto)
        {

        }
    }
}
