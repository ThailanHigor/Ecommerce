using Ecommerce.Domain.Entities;
using System.Collections.Generic;

namespace Ecommerce.Application.Interfaces
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> FindByName(string name);
    }
}
