using CrudTreinoApi.Models;

namespace CrudTreinoApi.Repository;

public interface ICadastroRepository
{
    Task<IEnumerable<Cadastro>> BuscaCadastrosAsync();
    Task<Cadastro> BuscaCadastroAsync(int contactId);
    Task AdicionaAsync(Cadastro cadastro);
    Task AtualizarAsync(Cadastro cadastro);
    Task DeletarAsync(Cadastro cadastro);
}

