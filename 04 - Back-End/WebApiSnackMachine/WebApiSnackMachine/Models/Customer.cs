using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace WebApiSnackMachine.Models
{
    [Table("Customer")]
    public class Customer
    {

        [Key]
        [DefaultValue(true)]

        public Guid IDCostumer { get; set; }
        [MaxLength(255)]
        [Column(TypeName = "varchar")]
        public string? Name { get; set; }

        [MaxLength(255)]
        [Column(TypeName = "varchar")]
        public string? Adress { get; set; }
        [MaxLength(255)]
        [Column(TypeName = "varchar")]
        public string? Nif { get; set; }

        [MaxLength(255)]
        [Column(TypeName = "varchar")]
        public string? Tele { get; set; }

        public DateTime? CreateAt { get; set; }
        public DateTime? LastUpdateAt { get; set; }
        public DateTime? DeleteAt { get; set; }
        public bool IsDeleted { get; set; }
        public List<Money>? Money { get; set; }

    }
}
