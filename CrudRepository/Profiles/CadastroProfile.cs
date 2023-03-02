using AutoMapper;
using CrudDomain.Dtos;
using CrudRepository.Dtos;
using CrudTreinoApi.Models;

namespace CrudRepository.Profiles
{
    public class CadastroProfile : Profile
    {
        public CadastroProfile()
        {
            //Fonte -> Alvo
            CreateMap<Cadastro, CadastroReadDto>();
            CreateMap<CadastroCreateDto, Cadastro>();
            CreateMap<CadastroUpdateDto, Cadastro>();

        }
    }
}
