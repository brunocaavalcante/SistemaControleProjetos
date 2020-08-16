using AutoMapper;
using Business.Models.Conta;
using Web.ViewModels;

namespace Web.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ContaModel, ContaViewModel>().ReverseMap();
            CreateMap<OperacaoModel, OperacaoViewModel>().ReverseMap();
        }
    }
}
