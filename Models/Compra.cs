using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace APIBotas.Models
{
    public class Compra
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime DataCompra { get; set; }


        [ForeignKey("DoceId")]
        public Guid DoceId { get; set; }
        [ForeignKey("ClienteId")]
        public Guid ClienteId { get; set; }

        public Doce? Doce { get; set; }
        public Cliente? Cliente { get; set; }
    }
}
