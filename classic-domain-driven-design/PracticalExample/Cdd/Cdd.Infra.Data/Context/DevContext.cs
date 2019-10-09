using Cdd.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Cdd.Infra.Data.Context
{
	public class DevContext : DbContext
	{
		public DevContext() /*: base("DefaultConnection")*/
		{

		}

		public DbSet<Cliente> Clientes { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			//modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
			//modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

			//// General Custom Context Properties
			//modelBuilder.Properties()
			//		.Where(p => p.Name == p.ReflectedType.Name + "Id")
			//		.Configure(p => p.IsKey());

			//modelBuilder.Properties<string>()
			//		.Configure(p => p.HasColumnType("varchar"));

			//modelBuilder.Properties<string>()
			//		.Configure(p => p.HasMaxLength(100));

			//modelBuilder.Configurations.Add(new ClienteConfig());
			//modelBuilder.Configurations.Add(new EnderecoConfig());

			base.OnModelCreating(modelBuilder);
		}

		public override int SaveChanges()
		{
			foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
			{
				if (entry.State == EntityState.Added)
				{
					entry.Property("DataCadastro").CurrentValue = DateTime.Now;
				}

				if (entry.State == EntityState.Modified)
				{
					entry.Property("DataCadastro").IsModified = false;
				}
			}
			return base.SaveChanges();
		}
	}

	// Classe para trocar a ConnectionString do EF em tempo de execução.
	public static class ChangeDb
	{
		public static void ChangeConnection(this DevContext context, string cn)
		{
			//context.Database.Connection.ConnectionString = cn;
		}
	}
}
