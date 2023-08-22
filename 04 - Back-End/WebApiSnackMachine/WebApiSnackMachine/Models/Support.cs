using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSnackMachine.Models
{
    [Table("Support")]
    public class Support
    {
        [Key]
        [DefaultValue(true)]
        public Guid IDSupport { get; set; }
        [MaxLength(255)]
        [Column(TypeName = "varchar")]
        public string? Name { get; set; }
        [MaxLength(255)]
        [Column(TypeName = "varchar")]
        public string? Nif { get; set; }
        [MaxLength(255)]
        [Column(TypeName = "varchar")]
        public string? Tele { get; set; }
        [MaxLength(255)]
        [Column(TypeName = "varchar")]
        public string? Adress { get; set; }
        [MaxLength(255)]
        [Column(TypeName = "varchar")]
        public string? Email { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? LastUpdateAt { get; set; }
        public DateTime? DeleteAt { get; set; }
        public bool IsDeleted { get; set; }
        public IList<Machine>? Machine { get; set; }
        public IList<Intervection>? Intervection { get; set; }
    }
}
