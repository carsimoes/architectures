using Cdd.Domain.Entities;
using Cdd.Domain.Validations.Documentos;
using DomainValidation.Interfaces.Specification;

namespace Cdd.Domain.Specifications
{
	public class ClienteDeveTerCpfValidoSpecification : ISpecification<Cliente>
	{
		public bool IsSatisfiedBy(Cliente cliente)
		{
			return CPFValidation.Validar(cliente.CPF);
		}
	}
}
