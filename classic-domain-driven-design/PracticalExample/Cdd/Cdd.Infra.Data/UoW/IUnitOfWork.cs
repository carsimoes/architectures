using System;
using System.Collections.Generic;
using System.Text;

namespace Cdd.Infra.Data.UoW
{
	public interface IUnitOfWork
	{
		void BeginTransaction();
		void Commit();
	}
}
