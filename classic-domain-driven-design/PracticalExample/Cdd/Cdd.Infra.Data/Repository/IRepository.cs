using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Cdd.Infra.Data.Repository
{
	public interface IRepository<TEntity> : IDisposable where TEntity : class
	{
		void Adicionar(TEntity obj);

		TEntity ObterPorId(Guid id);

		IEnumerable<TEntity> ObterTodos();

		TEntity Atualizar(TEntity obj);

		void Remover(Guid id);

		IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate);

		//int SaveChanges();
	}
}
