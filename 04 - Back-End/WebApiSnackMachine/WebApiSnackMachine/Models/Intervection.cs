using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSnackMachine.Models
{
    [Table("Intervection")]
    public class Intervection
    {
        [Key]
        [DefaultValue(true)]
        public Guid IDIntervection { get; set; }

        [MaxLength(255)]
        [Column(TypeName = "varchar")]
        public string? Name { get; set; }

        [MaxLength(255)]
        [Column(TypeName = "varchar")]
        public string? Description { get; set; }

        [MaxLength(255)]
        [Column(TypeName = "varchar")]
        public string? NameTecnical { get; set; }

        public DateTime? CreateAt { get; set; }
        public DateTime? LastUpdateAt { get; set; }
        public DateTime? DeleteAt { get; set; }
        public bool IsDeleted { get; set; }

        public IList<Machine>? Machine { get; set; }
        public IList<Support>? Support { get; set; }

    }
}
