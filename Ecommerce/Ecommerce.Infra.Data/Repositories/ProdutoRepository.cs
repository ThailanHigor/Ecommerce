using Ecommerce.Domain.Entities;
using Ecommerce.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Ecommerce.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> FindByName(string name)
        {
            return db.Produtos.Where(x => x.Name.ToLower().Contains(name.ToLower()));
        }

        public override IEnumerable<Produto> GetAll()
        {
            return db.Produtos.Where(x=>!x.Deleted);
        }
    }
}
