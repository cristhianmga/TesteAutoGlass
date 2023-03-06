using TesteAutoGlassPersistencia.Model;

namespace TesteAutoGlassPersistencia.Interface
{
    public interface IProdutoRepository
    {
        Task<Produto> GetProdutoByCodigo(int codigo);
        Task<Produto> Salvar(Produto produto);
        Task<string> Excluir(int codigo);
        Task<Produto> Atualizar(Produto produto);
        Task<IQueryable<Produto>> ObterTodos();
    }
}
