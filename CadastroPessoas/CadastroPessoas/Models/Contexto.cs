using Microsoft.EntityFrameworkCore;

namespace CadastroPessoas.Models
{
    public class Contexto : DbContext

    {//aqui é uma funçaõ construtora
        public Contexto(DbContextOptions<Contexto> options): base (options)
        { }
        //Aqui é de onde ela vai tirar o exemplo pra usar de 'Contexto"
        public DbSet<Pessoas> Pessoas { get; set; }
    }
}
