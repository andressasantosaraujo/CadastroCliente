using AutoMapper;
using ProjetoDemo.Data.EntityConfig;
using ProjetoDemo.Domain.Entities;
using ProjetoDemo.MVC.ViewModels;

namespace ProjetoDemo.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelDomainMappings"; }
        }

        //protected override void Configure()
        //{
        //    Mapper.CreateMap<ClienteViewModelo, Cliente>();
        //    Mapper.CreateMap<ProdutoViewModel, Produto>();
        //}
    }
}