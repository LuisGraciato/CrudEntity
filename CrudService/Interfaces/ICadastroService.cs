using CrudDomain.Dtos;
using CrudRepository.Dtos;

namespace CrudTreinoApi.Service;

public interface ICadastroService
    {
        Task<IEnumerable<CadastroReadDto>> BuscaCadastrosAsync();
        Task<CadastroReadDto> BuscaCadastroAsync(int contactid);
        Task AdicionaAsync(CadastroCreateDto cadastro);
        Task AtualizarAsync(CadastroUpdateDto cadastro);
        Task DeletarAsync(int contactid);
    }

