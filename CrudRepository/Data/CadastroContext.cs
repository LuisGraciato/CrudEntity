using CrudTreinoApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CrudDomain.Data
{
    public class CadastroContext : DbContext
    {
        public CadastroContext()
        {
        }
        public CadastroContext(DbContextOptions<CadastroContext> opt) : base(opt)
        {

        }
        public DbSet<Cadastro> Cadastros { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                    => optionsBuilder
                    .UseSqlServer("Data Source=MAGNATI-10863-F\\SQLEXPRESS;Initial Catalog=EntityCrud;Integrated Security=True; Connect Timeout=30; Encrypt=False; TrustServerCertificate=False; ApplicationIntent=ReadWrite; MultiSubnetFailover=False;");

        //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
    }
}
