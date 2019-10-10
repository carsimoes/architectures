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
		//protected DbSet<TEntity> DbSet;
		private DbSet<TEntity> _dbSet => Db.Set<TEntity>();

		public Repository(DevContext context)
		{
			Db = context;
			//DbSet = Db.Set<TEntity>();
		}

		public virtual void Adicionar(TEntity obj)
		{
			//var objreturn = DbSet.Add(obj);
			//return objreturn;
			_dbSet.Add(obj);
		}

		public virtual TEntity ObterPorId(Guid id)
		{
			//return DbSet.Find(id);
			return _dbSet.Find(id);
		}

		public virtual IEnumerable<TEntity> ObterTodos()//(int s, int t)
		{
			//return DbSet.ToList(); //Take(t).Skip(s).ToList();
			return _dbSet.ToList();
		}

		public virtual TEntity Atualizar(TEntity obj)
		{
			//var entry = Db.Entry(obj);
			//DbSet.Attach(obj);
			//entry.State = EntityState.Modified;

			_dbSet.Update(obj);

			return obj;
		}

		public virtual void Remover(Guid id)
		{
			//DbSet.Remove(DbSet.Find(id));

			_dbSet.Remove(_dbSet.Find(id));
		}

		public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
		{
			//return DbSet.Where(predicate);

			return _dbSet.Where(predicate);
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		//public int SaveChanges()
		//{
		//	return Db.SaveChanges();
		//}

		//public void Dispose()
		//{
		//	Db.Dispose();
		//	GC.SuppressFinalize(this);
		//}
	}
}
