using Cdd.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Cdd.Infra.Data.Repository
{
	public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
	{
		protected DevContext Db;
		protected DbSet<TEntity> DbSet;

		public Repository(DevContext context)
		{
			Db = context;
			DbSet = Db.Set<TEntity>();
		}

		public virtual void Adicionar(TEntity obj)
		{
			var objreturn = DbSet.Add(obj);
			//return objreturn;
		}

		public virtual TEntity ObterPorId(Guid id)
		{
			return DbSet.Find(id);
		}

		public virtual IEnumerable<TEntity> ObterTodos()//(int s, int t)
		{
			return DbSet.ToList(); //Take(t).Skip(s).ToList();
		}

		public virtual TEntity Atualizar(TEntity obj)
		{
			var entry = Db.Entry(obj);
			DbSet.Attach(obj);
			entry.State = EntityState.Modified;

			return obj;
		}

		public virtual void Remover(Guid id)
		{
			DbSet.Remove(DbSet.Find(id));
		}

		public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
		{
			return DbSet.Where(predicate);
		}

		public int SaveChanges()
		{
			return Db.SaveChanges();
		}

		public void Dispose()
		{
			Db.Dispose();
			GC.SuppressFinalize(this);
		}
	}
}
