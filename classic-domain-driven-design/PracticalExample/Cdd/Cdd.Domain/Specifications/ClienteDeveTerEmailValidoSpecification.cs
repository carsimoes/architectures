using Cdd.Domain.Entities;
using Cdd.Domain.Validations.Documentos;
using DomainValidation.Interfaces.Specification;

namespace Cdd.Domain.Specifications
{
	public class ClienteDeveTerEmailValidoSpecification : ISpecification<Cliente>
	{
		public bool IsSatisfiedBy(Cliente cliente)
		{
			return EmailValidation.Validate(cliente.Email);
		}
	}
}
