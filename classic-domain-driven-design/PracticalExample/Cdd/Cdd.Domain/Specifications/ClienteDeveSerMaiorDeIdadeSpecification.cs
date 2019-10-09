using Cdd.Domain.Entities;
using DomainValidation.Interfaces.Specification;
using System;

namespace Cdd.Domain.Specifications
{
	public class ClienteDeveSerMaiorDeIdadeSpecification : ISpecification<Cliente>
	{
		public bool IsSatisfiedBy(Cliente cliente)
		{
			return DateTime.Now.Year - cliente.DataNascimento.Year >= 18;
		}
	}
}
