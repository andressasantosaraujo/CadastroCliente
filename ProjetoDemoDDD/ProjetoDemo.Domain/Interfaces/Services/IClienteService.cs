using ProjetoDemo.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoDemo.Domain.Interfaces.Services
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes);
    }
}
