using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAutoGlassNegocio.DTO;
using TesteAutoGlassPersistencia.Model;

namespace TesteAutoGlassNegocio.Filter
{
    public static class ProdutoFilter
    {
        public static IQueryable<Produto> ProdutoFiltro(this IQueryable<Produto> query, ProdutoFilterDTO dto)
        {
            if(dto.Codigo != null)
            {
                query.Where(produto => produto.Codigo == dto.Codigo);
            }
            if (!string.IsNullOrEmpty(dto.Descricao))
            {
                query.Where(produto => produto.Descricao == dto.Descricao);
            }
            if (dto.Situacao != null)
            {
                query.Where(produto => produto.Situacao == dto.Situacao);
            }
            if (dto.DataFabricacao != null)
            {
                query.Where(produto => produto.DataFabricacao == dto.DataFabricacao);
            }
            if (dto.DataValidade != null)
            {
                query.Where(produto => produto.DataValidade == dto.DataValidade);
            }
            if(dto.CodigoFornecedor != null)
            {
                query.Where(produto => produto.Fornecedor.Codigo == dto.CodigoFornecedor);
            }
            if (dto.DescricaoFornecedor != null)
            {
                query.Where(produto => produto.Fornecedor.Descricao == dto.DescricaoFornecedor);
            }
            if (dto.CNPJFornecedor != null)
            {
                query.Where(produto => produto.Fornecedor.CNPJ == dto.CNPJFornecedor);
            }

            return query;
        }
    }
}
