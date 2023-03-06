
using Microsoft.EntityFrameworkCore;
using TesteAutoGlassPersistencia.Interface;
using TesteAutoGlassPersistencia.Model;

namespace TesteAutoGlassPersistencia.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly IPadraoDB _padraoDB;
        public ProdutoRepository(IPadraoDB padraoDB) 
        {
            _padraoDB = padraoDB;
        }

        public async Task<Produto> GetProdutoByCodigo(int codigo) 
        {
            Produto produto = await _padraoDB.Obter<Produto>(codigo);
            if (produto == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                return produto;
            }
        }

        public async Task<Produto> Salvar(Produto produto)
        {
            Produto retorno = await _padraoDB.Salvar(produto);
            return retorno;
        }

        public async Task<string> Excluir(int codigo)
        {
            Produto produto = await _padraoDB.Obter<Produto>(codigo);
            produto.Situacao = false;
            var retorno = await _padraoDB.Atualizar(produto);
            if(retorno != null)
            {
                return "Excluido com sucesso";
            }
            else
            {
                return "Erro ao excluir";
            }
        }

        public async Task<Produto> Atualizar(Produto produto)
        {
            Produto retorno = await _padraoDB.Atualizar(produto);
            return retorno;
        }

        public async Task<IQueryable<Produto>> ObterTodos()
        {
            IQueryable<Produto> produtos =  _padraoDB.ObterTodos<Produto>().Include("Fornecedor");
            return produtos;
        }
    }
}
