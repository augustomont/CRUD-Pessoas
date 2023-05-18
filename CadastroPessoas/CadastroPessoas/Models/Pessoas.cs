using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroPessoas.Models
{
    //Essa é a Tabela/Formulario
    [Table("Pessoas")]
    public class Pessoas
    {
    //Aqui eu defino o nome e quantidade das colunas
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("Telefone")]
        [Display(Name = "Telefone")]
        public int Telefone { get; set; }

        [Column("Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
