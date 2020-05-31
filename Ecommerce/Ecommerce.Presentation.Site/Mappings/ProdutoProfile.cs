using AutoMapper;
using Ecommerce.Domain.Entities;
using Ecommerce.Presentation.Site.ViewModels;

namespace Ecommerce.Presentation.Site.Mappings
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile()
        {
            CreateMap<Produto, ProdutoViewModel>();
            CreateMap<ProdutoViewModel, Produto>();
        }
    }
}
