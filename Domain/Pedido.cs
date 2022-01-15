using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace exemplo_dotnet_efcore.Domain
{
    [Table("Pedidos")]
    public class Pedido
    {
        [Key]
        public int Id { get; set; }
        public ICollection<ItemPedido> Itens { get; set;}
    }
}