using Cdd.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cdd.Infra.Data.UoW
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly DevContext _context;
		private bool _disposed;

		public UnitOfWork(DevContext context)
		{
			_context = context;
		}

		public void BeginTransaction()
		{
			_disposed = false;
		}

		public void Commit()
		{
			_context.SaveChanges();
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!_disposed)
			{
				if (disposing)
				{
					_context.Dispose();
				}
			}
			_disposed = true;
		}
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
