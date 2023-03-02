using CrudDomain.Dtos;

namespace CrudTreinoApi.Service;

public interface ICadastroService
    {
        Task<IEnumerable<CadastroReadDto>> BuscaCadastrosAsync();
        Task<CadastroReadDto> BuscaCadastroAsync(int contactid);
        Task<bool> AdicionaAsync(CadastroCreateDto request);
        Task<bool> AtualizarAsync(CadastroCreateDto request, int contactid);
        Task<bool> DeletarAsync(int contactid);
    }

