using ProjetoDemo.Data.EntityConfig;
using System.Collections.Generic;

namespace ProjetoDemo.Domain.Interfaces.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);

    }
}
