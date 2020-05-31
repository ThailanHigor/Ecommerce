using Ecommerce.Domain.Entities;
using Ecommerce.Domain.Interfaces.Repositories;
using Ecommerce.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Ecommerce.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository) : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        public IEnumerable<Produto> FindByName(string name)
        {
            return _produtoRepository.FindByName(name);
        }
    }
}
