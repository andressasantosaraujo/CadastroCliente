using ProjetoDemo.Data.EntityConfig;
using System.Collections.Generic;

namespace ProjetoDemo.Application.Interface
{
    public interface IProdutoAppService: IAppServiceBase<Produto>
    {

        IEnumerable<Produto> BuscaPorNome(string nome);
    }
}
