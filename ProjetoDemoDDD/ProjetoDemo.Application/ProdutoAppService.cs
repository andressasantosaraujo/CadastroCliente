using ProjetoDemo.Application.Interface;
using ProjetoDemo.Data.EntityConfig;
using ProjetoDemo.Domain.Entities;
using ProjetoDemo.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace ProjetoDemo.Application
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService)
            : base(produtoService)
        {
            _produtoService = produtoService;
        }

        public IEnumerable<Produto> BuscaPorNome(string nome)
        {
            return _produtoService.BuscarPorNome(nome);
        }

    }
}
