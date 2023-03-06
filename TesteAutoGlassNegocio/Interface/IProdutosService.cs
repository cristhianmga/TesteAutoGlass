using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAutoGlassNegocio.DTO;
using TesteAutoGlassNegocio.DTO.Ext;

namespace TesteAutoGlassNegocio.Interface
{
    public interface IProdutosService
    {
        Task<ProdutoDTO> SalvarAsync(ProdutoDTO produto);
        Task<ProdutoDTO> AtualizarAsync(ProdutoDTO produto);
        Task<string> ExcluirAsync(int codigo);
        Task<ProdutoDTO> ObterAsync(int codigo);
        Task<PaginacaoDTO<ProdutoDTO>> ObterTodosPaginadoAsync(ProdutoFilterDTO filtro, PaginacaoConfigDTO config);
    }
}
