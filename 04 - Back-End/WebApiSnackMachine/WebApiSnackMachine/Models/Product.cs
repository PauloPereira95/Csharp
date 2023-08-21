using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebApiSnackMachine.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [DefaultValue(true)]
        public Guid IDProduct { get; set; }
        [MaxLength(255)]
        [Column(TypeName = "varchar")]
        public string? Name { get; set; }
        [Precision(10,3)]
        public decimal?Price { get; set; }
        public int Stock { get; set; }
        [MaxLength(500)]
        [Column(TypeName ="varchar")]
        public string? Ingredients { get; set; }
        public DateTime ExpDate { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? LastUpdateAt { get; set; }
        public DateTime? DeleteAt { get; set; }
        public bool IsDeleted { get; set; }
        // ---- FK'S ---------
        public IList<Position>? Position { get; set; }
        public IList<Machine>? Machine { get; set; }
        public IList<Supplier>? Supplier { get;set; }
        [JsonIgnore]
        public Orders? Order { get; set; }

    }
}
