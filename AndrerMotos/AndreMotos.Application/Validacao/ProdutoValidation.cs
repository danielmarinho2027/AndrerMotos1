using AndreMotos.Dominio.EstoqueRoot;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreMotos.Application.Validacao
{
   public class ProdutoValidation : AbstractValidator<Produto>
    {
        public ProdutoValidation()
        {
            RuleFor(a => a.NomeProduto)
                .NotEmpty().WithMessage("O compo {PropertyName} é obrigatório.")
                .Length(2, 150).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres.");

            RuleFor(a => a.Descricao)
                .NotEmpty().WithMessage("O compo {PropertyName} é obrigatório.")
                .Length(2, 150).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres.");

    
        }
    }
}
