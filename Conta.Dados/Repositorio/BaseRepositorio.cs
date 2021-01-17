using Conta.Dados.Intefarce;
using System.Collections.Generic;
using System.Linq;

namespace Conta.Dados.Repositorio
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly ContaContexto contaContexto;
        public BaseRepositorio(ContaContexto _contaContexto)
        {
            contaContexto = _contaContexto;
        }
        public void Adicionar(TEntity entity)
        {
            contaContexto.Set<TEntity>().Add(entity);
            contaContexto.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            contaContexto.Set<TEntity>().Update(entity);
            contaContexto.SaveChanges();
        }

        public TEntity ObterPorId(long id)
        {
            return contaContexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return contaContexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            contaContexto.Remove(entity);
            contaContexto.SaveChanges();
        }
        public void Dispose()
        {
            contaContexto.Dispose();
        }
    }
}
