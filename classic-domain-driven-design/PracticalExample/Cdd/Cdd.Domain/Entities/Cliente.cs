using Cdd.Domain.Validations.Cliente;
using DomainValidation.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cdd.Domain.Entities
{
	public class Cliente
	{
		public Cliente()
		{
			ClienteId = Guid.NewGuid();
		}

		public Guid ClienteId { get; set; }
		public string Nome { get; set; }
		public string Email { get; set; }
		public string CPF { get; set; }
		public DateTime DataNascimento { get; set; }
		public DateTime DataCadastro { get; set; }
		public bool Ativo { get; set; }
		public ValidationResult ValidationResult { get; set; }

		public bool IsValid()
		{
			ValidationResult = new ClienteEstaConsistenteValidation().Validate(this);
			return ValidationResult.IsValid;
		}
	}
}
