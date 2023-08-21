using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebApiSnackMachine.Models
{
    [Table("Orders")]
    public class Orders
    {
        [Key]
        [DefaultValue(true)]
        public Guid IDOrders { get; set; }
        [Column(TypeName="varchar")]
        [MaxLength(255)]
        public string? Name { get; set; }
        [Column(TypeName ="varchar")]
        [MaxLength(255)]
        public string? Description { get; set; }
        public DateTime? Date { get; set; }
        [Precision(10,3)]
        public decimal? Cost { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(255)]
        public string? NameTecnical { get; set; }
        public string? Location { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? LastUpdateAt { get; set; }
        public DateTime? DeleteAt { get; set; }
        public bool IsDeleted { get; set; }
        public Customer? Customer { get; set; }
        public IList<Machine>? Machine { get; set; }
        public IList<Support>? Support { get; set; }
    }
}