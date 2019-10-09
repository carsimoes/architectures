using Cdd.Domain.Specifications;
using DomainValidation.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cdd.Domain.Validations.Cliente
{
	public class ClienteEstaConsistenteValidation : Validator<Entities.Cliente>
	{
		public ClienteEstaConsistenteValidation()
		{
			var CPFCliente = new ClienteDeveTerCpfValidoSpecification();
			var clienteEmail = new ClienteDeveTerEmailValidoSpecification();
			var clienteMaioridade = new ClienteDeveSerMaiorDeIdadeSpecification();

			base.Add("CPFCliente", new Rule<Entities.Cliente>(CPFCliente, "Cliente informou um CPF inválido."));
			base.Add("clienteEmail", new Rule<Entities.Cliente>(clienteEmail, "Cliente informou um e-mail inválido."));
			base.Add("clienteMaioridade", new Rule<Entities.Cliente>(clienteMaioridade, "Cliente não tem maioridade para cadastro."));
		}
	}
}
