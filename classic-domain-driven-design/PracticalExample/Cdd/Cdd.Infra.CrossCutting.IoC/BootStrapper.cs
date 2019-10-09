using Cdd.Application.Services;
using Cdd.Domain.Services;
using Cdd.Infra.Data.Context;
using Cdd.Infra.Data.Repository;
using Cdd.Infra.Data.UoW;
using SimpleInjector;

namespace Cdd.Infra.CrossCutting.IoC
{
	public class BootStrapper
	{
		public static void RegisterServices(Container container)
		{
			// Lifestyle.Transient => Uma instancia para cada solicitacao;
			// Lifestyle.Singleton => Uma instancia unica para a classe
			// Lifestyle.Scoped => Uma instancia unica para o request

			// App
			container.Register<IClienteAppService, ClienteAppService>(Lifestyle.Scoped);

			// Domain
			container.Register<IClienteService, ClienteService>(Lifestyle.Scoped);

			// Infra Dados
			container.Register<IClienteRepository, ClienteRepository>(Lifestyle.Scoped);
			container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
			container.Register<DevContext>(Lifestyle.Scoped);
			//container.Register(typeof (IRepository<>), typeof (Repository<>));

			// Logging
			//container.Register<ILogAuditoria, LogAuditoriaHelper>(Lifestyle.Scoped);
			//container.Register<LogginContext>(Lifestyle.Scoped);
		}
	}
}
