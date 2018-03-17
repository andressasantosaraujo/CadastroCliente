using System.Collections.Generic;
using ProjetoDemo.Data.EntityConfig;
using ProjetoDemo.Domain.Entities;
using ProjetoDemo.Domain.Interfaces;
using ProjetoDemo.Domain.Interfaces.Services;

namespace ProjetoDemo.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
            :base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoRepository.BuscarPorNome(nome);
        }
    }
}
