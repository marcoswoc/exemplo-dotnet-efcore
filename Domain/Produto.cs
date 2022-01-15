using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace exemplo_dotnet_efcore.Domain
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName="varchar(200)")]
        public string Nome { get; set; }

        [Column(TypeName="varchar(200)")]      
        public string Descricao { get; set; }

        [Required]
        public decimal Valor { get; set; }
    }
}