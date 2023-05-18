using Microsoft.EntityFrameworkCore;

namespace CadastroPessoas.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options): base (options)
        { }
        public DbSet<Pessoas> Pessoas { get; set; }
    }
}
