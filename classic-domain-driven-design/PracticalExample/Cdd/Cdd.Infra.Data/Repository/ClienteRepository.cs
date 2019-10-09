using Cdd.Domain.DTO;
using Cdd.Domain.Entities;
using Cdd.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cdd.Infra.Data.Repository
{
	public class ClienteRepository : Repository<Cliente>, IClienteRepository
	{

		public ClienteRepository(DevContext context)
				: base(context)
		{

		}

		public Cliente ObterPorCpf(string cpf)
		{
			//return Db.Clientes.FirstOrDefault(c => c.CPF == cpf);
			return Buscar(c => c.CPF == cpf).FirstOrDefault();
		}

		public Cliente ObterPorEmail(string email)
		{
			return Buscar(c => c.Email == email).FirstOrDefault();
		}

		public Paged<Cliente> ObterTodos(string nome, int pageSize, int pageNumber)
		{
			var cn = ""; //todo //Db.Database.Connection;

			var sql = @"SELECT * FROM Clientes " +
								"WHERE (@Nome IS NULL OR Nome LIKE @Nome + '%') " +
								"ORDER BY [Nome] " +
								"OFFSET " + pageSize * (pageNumber - 1) + " ROWS " +
								"FETCH NEXT " + pageSize + " ROWS ONLY " +
								" " +
								"SELECT COUNT(ClienteId) FROM Clientes " +
								"WHERE (@Nome IS NULL OR Nome LIKE @Nome + '%') ";

			//TODO
			//var multi = cn.QueryMultiple(sql, new { Nome = nome });
			//var clientes = multi.Read<Cliente>();
			//var total = multi.Read<int>().FirstOrDefault();

			var pagedList = new Paged<Cliente>()
			{
				List = new List<Cliente>(),//clientes,
				Count = 1 //total
			};

			return pagedList;
		}

		public override Cliente ObterPorId(Guid id)
		{
			var cn = ""; //TODO //Db.Database.Connection;
			var sql = @"SELECT * FROM Clientes c " +
								 "LEFT JOIN Enderecos e " +
								 "ON c.ClienteId = e.ClienteId " +
								 "WHERE c.ClienteId = @sid";

			var cliente = new List<Cliente>();

			//TODO
			//cn.Query<Cliente, Cliente>(sql,
			//		(c, e) =>
			//		{
			//			cliente.Add(c);
			//			if (e != null)
			//				cliente[0].Enderecos.Add(e);

			//			return cliente.FirstOrDefault();
			//		}, new { sid = id }, splitOn: "ClienteId, EnderecoId");

			//throw new Exception("MORTE!!!");

			return cliente.FirstOrDefault();
		}
	}
}
