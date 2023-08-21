using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSnackMachine.Models
{
    [Table("Machine")]
    public class Machine
    {
        [Key]
        [DefaultValue(true)]
        public Guid IDMachine { get; set; }
        [Precision(10,3)]
        public decimal Size { get; set; }
        [MaxLength(255)]
        [Column(TypeName ="varchar")] 
        public string? Location { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? LastUpdateAt { get; set; }
        public DateTime? DeleteAt { get; set; }
        public bool IsDeleted { get; set; }
        public IList<Intervection>? Interaction { get; set; }
        public IList<Support>? Support { get; set; }
        public IList<Product>? Product { get; set; }
        public IList<Position>? Position { get; set; }

    }
}
