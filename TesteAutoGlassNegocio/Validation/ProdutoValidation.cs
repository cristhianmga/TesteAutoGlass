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
        public ProdutoValidation() 
        {
            ValidaDataFabricacaoMenorValidade();
        }

        public void ValidaDataFabricacaoMenorValidade()
        {
            RuleFor(produto => produto.DataFabricacao).LessThan(produto => produto.DataValidade).WithMessage("Data de Fabricação maior ou igual que a de validade");
        }
    }
}
