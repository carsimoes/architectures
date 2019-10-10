using Cdd.Infra.CrossCutting.IoC;
using Microsoft.AspNetCore.Builder;
using SimpleInjector;
using SimpleInjector.Integration.AspNetCore;
using SimpleInjector.Lifestyles;
using System.Reflection;

namespace Cdd.UI
{
	public static class SimpleInjectorInitializer
	{
		public static void Initialize()
		{
			var container = new Container();
			//container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
			container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

			InitializeContainer(container);

			//container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

			container.Verify();

			//FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters, container);

			//DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
		}

		private static void InitializeContainer(Container container)
		{
			BootStrapper.RegisterServices(container);
		}
	}
}
