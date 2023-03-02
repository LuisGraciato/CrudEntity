using CrudDomain.Data;
using CrudTreinoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudTreinoApi.Repository;

public class CadastroRepository : ICadastroRepository
{
    private readonly CadastroContext _context;

    public CadastroRepository(CadastroContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Cadastro>> BuscaCadastrosAsync()
    {
        return await _context.Cadastros.ToListAsync();
    }
    public async Task<Cadastro?> BuscaCadastroAsync(int contactId)
    {
        return await _context.Cadastros.FirstOrDefaultAsync(c => c.ContactID == contactId);
        
    }
    public async Task AdicionaAsync(Cadastro cadastro)
    {
        if (cadastro == null)
        {
            throw new ArgumentNullException(nameof(cadastro));
        }
        await _context.Cadastros.AddAsync(cadastro);
        await _context.SaveChangesAsync();

    }

    public async Task AtualizarAsync(Cadastro cadastro)
    {
        _context.Update(cadastro);

        await _context.SaveChangesAsync();
    }

    public async Task DeletarAsync(Cadastro cadastro)
    {
        _context.Cadastros.Remove(cadastro);
        await _context.SaveChangesAsync();
    }
}


