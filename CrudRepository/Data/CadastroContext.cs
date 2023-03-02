using CrudTreinoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudDomain.Data
{
    public class CadastroContext : DbContext
    {
        public CadastroContext(DbContextOptions<CadastroContext> opt) : base(opt)
        {

        }
        public DbSet<Cadastro> Cadastros { get; set; }


    }
}
