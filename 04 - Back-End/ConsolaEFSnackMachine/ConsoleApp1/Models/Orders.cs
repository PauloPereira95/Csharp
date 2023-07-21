using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnackMachine.Models
{
    [Table("Orders")]
    internal class Orders
    {
        [Key]
        [DefaultValue(true)]
        public Guid IDOrder { get; set; }

        [MaxLength(255)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [ForeignKey("IDPorduto")]
        public IList<Produto> Product { get; set; }
        [Required]
        [ForeignKey("IDCostumer")]
        public IList<Costumer> Costumer { get; set; }
    }
}
