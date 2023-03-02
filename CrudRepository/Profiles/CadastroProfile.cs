using AutoMapper;
using CrudDomain.Dtos;
using CrudTreinoApi.Models;

namespace CrudRepository.Profiles
{
    public class CadastroProfile : Profile
    {
        public CadastroProfile()
        {
            CreateMap<Cadastro, CadastroReadDto>();
            CreateMap<CadastroCreateDto, Cadastro>();
        }
    }
}
