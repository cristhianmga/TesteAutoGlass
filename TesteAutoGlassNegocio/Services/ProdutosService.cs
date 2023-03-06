using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using TesteAutoGlassNegocio.DTO;
using TesteAutoGlassNegocio.DTO.Ext;
using TesteAutoGlassNegocio.Filter;
using TesteAutoGlassNegocio.Interface;
using TesteAutoGlassNegocio.Util;
using TesteAutoGlassPersistencia.Interface;
using TesteAutoGlassPersistencia.Model;

namespace TesteAutoGlassNegocio.Services
{
    public class ProdutosService : IProdutosService
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;
        private IValidator<ProdutoDTO> _validator;
        public ProdutosService(IProdutoRepository produtoRepository, IMapper mapper, IValidator<ProdutoDTO> validator) 
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
            _validator = validator;
        }

        public async Task<ProdutoDTO> SalvarAsync(ProdutoDTO produto)
        {
            ValidationResult validation = await _validator.ValidateAsync(produto);
            if(validation.IsValid)
            {
                Produto retorno = await _produtoRepository.Salvar(_mapper.Map<Produto>(produto));
                return _mapper.Map<ProdutoDTO>(retorno);
            }
            else
            {
                throw new Exception(validation.ToString());
            }
        }

        public async Task<ProdutoDTO> AtualizarAsync(ProdutoDTO produto)
        {
            ValidationResult validation = await _validator.ValidateAsync(produto);
            if (validation.IsValid)
            {
                Produto retorno = await _produtoRepository.Atualizar(_mapper.Map<Produto>(produto));
            return _mapper.Map<ProdutoDTO>(retorno);
            }
            else
            {
                throw new Exception(validation.ToString());
            }
        }

        public async Task<string> ExcluirAsync(int codigo)
        {
            string retorno = await _produtoRepository.Excluir(codigo);
            return retorno;
        }

        public async Task<ProdutoDTO> ObterAsync(int codigo)
        {
            Produto produto = await _produtoRepository.GetProdutoByCodigo(codigo);
            return _mapper.Map<ProdutoDTO>(produto);
        }
        
        public async Task<PaginacaoDTO<ProdutoDTO>> ObterTodosPaginadoAsync(ProdutoFilterDTO filtro, PaginacaoConfigDTO config)
        {
            IQueryable<Produto> lista = await _produtoRepository.ObterTodos();
            PaginacaoDTO<ProdutoDTO> listaPaginada = lista.ProdutoFiltro(filtro).AsPaginado<ProdutoDTO>(config, _mapper);
            return listaPaginada;
        }

    }
}
