using Microsoft.AspNetCore.Mvc;
using TesteAutoGlassNegocio.DTO;
using TesteAutoGlassNegocio.DTO.Ext;
using TesteAutoGlassNegocio.Interface;

namespace TesteAutoGlass.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutosService _produtosService;
        public ProdutoController(IProdutosService produtosService) 
        {
            _produtosService = produtosService;
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Salvar(ProdutoDTO produto)
        {
            try
            {
                return Ok(await _produtosService.SalvarAsync(produto));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        [Route("")]
        public async Task<IActionResult> Atualizar(ProdutoDTO produto)
        {
            try
            {
                return Ok(await _produtosService.AtualizarAsync(produto));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        [Route("")]
        public async Task<IActionResult> Excluir(int codigo)
        {
            try
            {
                return Ok(await _produtosService.ExcluirAsync(codigo));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("{codigo}")]
        public async Task<IActionResult> Obter(int codigo)
        {
            try
            {
                return Ok(await _produtosService.ObterAsync(codigo));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> ObterTodos([FromQuery]PaginacaoProdutosDTO paginacaoProdutos)
        {
            try
            {
                return Ok(await _produtosService.ObterTodosPaginadoAsync(paginacaoProdutos.FilterDTO, paginacaoProdutos.PaginacaoDTO));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
