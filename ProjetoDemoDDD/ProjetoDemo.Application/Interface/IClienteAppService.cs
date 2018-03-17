using ProjetoDemo.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoDemo.Application.Interface
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais();
    }
}
