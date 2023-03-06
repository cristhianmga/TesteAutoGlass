using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAutoGlassNegocio.DTO;

namespace TesteAutoGlassNegocio.Validation
{
    public class ProdutoValidation : AbstractValidator<ProdutoDTO>
    {
        ProdutoValidation() 
        {
            ValidaDataFabricacaoMenorValidade();
        }

        public void ValidaDataFabricacaoMenorValidade()
        {
            RuleFor(produto => produto.DataFabricacao).LessThanOrEqualTo(produto => produto.DataValidade).WithMessage("Data de Fabricação maior que a de validade");
        }
    }
}
