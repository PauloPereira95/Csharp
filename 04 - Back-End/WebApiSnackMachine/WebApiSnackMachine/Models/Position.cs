using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSnackMachine.Models
{
    [Table("Position")]
    public class Position
    {
        [Key]
        [DefaultValue(true)]
        public Guid IDPosition { get; set; }
        [MaxLength(255)]
        [Column(TypeName = "varchar")]
        public string? Description { get; set; }
        public IList<Product>? Product { get; set; }
        public IList<Machine>? Machine { get; set; }
    }
    
}

