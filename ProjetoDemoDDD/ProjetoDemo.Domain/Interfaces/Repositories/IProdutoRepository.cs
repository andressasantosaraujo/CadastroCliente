using ProjetoDemo.Data.EntityConfig;
using System.Collections.Generic;

namespace ProjetoDemo.Domain.Interfaces
{
    public interface IProdutoRepository: IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
