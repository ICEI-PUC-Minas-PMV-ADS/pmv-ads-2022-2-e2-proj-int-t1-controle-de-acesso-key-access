using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace KeyAcess01.Models
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) //construtor da classe da classe "ApplicationDbContext" - ele recebe como config. as opções de banco de dados
        { // isso é a injeção de dependência. Esta mandando uma config que ta vindo da classe Application... e passa para a classe mãe (a DbContext)
        }

        public DbSet<Apartamento> Apartamentos { get; set; }
        public DbSet<Residente> Residentes { get; set; }
        public DbSet<Visitante> Visitantes { get; set; }
    }  
}
