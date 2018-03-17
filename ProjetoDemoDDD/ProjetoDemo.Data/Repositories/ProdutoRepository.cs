using System.Collections.Generic;
using System.Linq;
using ProjetoDemo.Data.EntityConfig;
using ProjetoDemo.Domain.Interfaces;

namespace ProjetoDemo.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return Db.Produtos.Where(p => p.Nome == nome);
        }
    }
}
