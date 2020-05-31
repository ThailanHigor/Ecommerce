using Ecommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Domain.Interfaces.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        IEnumerable<Produto> FindByName(string name);
    }
}
