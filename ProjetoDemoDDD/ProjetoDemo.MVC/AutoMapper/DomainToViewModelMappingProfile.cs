using AutoMapper;

namespace ProjetoDemo.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMapping"; }
        }

        //protected override void Configure()
        //{
        //    Mapper.CreateMap<Cliente, ClienteViewModelo>();
        //    Mapper.CreateMap<Produto, ProdutoViewModel>();
        //}
    }
}