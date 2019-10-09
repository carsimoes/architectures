using Cdd.Domain.DTO;
using Cdd.Domain.Entities;

namespace Cdd.Infra.Data.Repository
{
	public interface IClienteRepository : IRepository<Cliente>
	{
		Cliente ObterPorCpf(string cpf);

		Cliente ObterPorEmail(string email);

		Paged<Cliente> ObterTodos(string nome, int pageSize, int pageNumber);
	}
}
