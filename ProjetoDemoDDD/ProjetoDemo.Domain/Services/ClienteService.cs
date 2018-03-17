using System.Collections.Generic;
using System.Linq;
using ProjetoDemo.Domain.Entities;
using ProjetoDemo.Domain.Interfaces;
using ProjetoDemo.Domain.Interfaces.Services;

namespace ProjetoDemo.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
            :base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes)
        {
            return clientes.Where(c => c.ClienteEspecial(c));
        }
    }
}
