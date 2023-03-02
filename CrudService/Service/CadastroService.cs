using AutoMapper;
using CrudDomain.Dtos;
using CrudRepository.Dtos;
using CrudTreinoApi.Models;
using CrudTreinoApi.Repository;
using CrudTreinoApi.Service;

namespace CrudService.Service
{
    public class CadastroService : ICadastroService
    {
        private readonly ICadastroRepository _repository;
        private readonly IMapper _mapper;

        public CadastroService(ICadastroRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task AdicionaAsync(CadastroCreateDto cadastroCreateDto)
        {
            var cadastroModel = _mapper.Map<Cadastro>(cadastroCreateDto);
            await _repository.AdicionaAsync(cadastroModel);

        }

        public async Task AtualizarAsync(CadastroUpdateDto cadastroUpdateDto)
        {
            var cadastroModel = _mapper.Map<Cadastro>(cadastroUpdateDto);
            await _repository.AtualizarAsync(cadastroModel);
        }

        public async Task<CadastroReadDto?> BuscaCadastroAsync(int contactid)
        {

            var cadastroModel = await _repository.BuscaCadastroAsync(contactid);
            if (cadastroModel != null)
            {
                return _mapper.Map<CadastroReadDto>(cadastroModel);
            }
            return null;
        }

        public async Task<IEnumerable<CadastroReadDto>> BuscaCadastrosAsync()
        {
            var cadastroModel = await _repository.BuscaCadastrosAsync();
            return _mapper.Map<IEnumerable<CadastroReadDto>>(cadastroModel);
           
        }

        public async Task DeletarAsync(int contactid)
        {
            var cadastroModel = await _repository.BuscaCadastroAsync(contactid);
            
            if (cadastroModel != null)
            {
               await _repository.DeletarAsync(cadastroModel);
            }
            

        }
    }
}
