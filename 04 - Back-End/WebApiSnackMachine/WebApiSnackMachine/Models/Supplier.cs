using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSnackMachine.Models
{
    [Table("Supplier")]
    public class Supplier
    {
        [Key]
        [DefaultValue(true)]
        public Guid IDSupplier { get; set; }
        [MaxLength(255)]
        [Column(TypeName = "varchar")]
        public string? Name { get; set; }
        [MaxLength(255)]
        [Column(TypeName = "varchar")]
        public string? Nif { get; set; }
        [MaxLength(255)]
        [Column(TypeName = "varchar")]
        public string? Email { get; set; }

        [MaxLength(255)]
        [Column(TypeName = "varchar")]
        public string? Tele { get;set; }

        [MaxLength(255)]
        [Column(TypeName = "varchar")]
        public string? Address { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? LastUpdateAt { get; set; }
        public DateTime? DeleteAt { get; set; }
        public bool IsDeleted { get; set; }
        // ---- Fk's
        public IList<Product>? Product { get; set; }

    }
}
