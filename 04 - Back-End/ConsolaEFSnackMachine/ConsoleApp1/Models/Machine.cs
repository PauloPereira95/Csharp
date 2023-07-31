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
    [Table("Machine")]
    internal class Machine
    {
        [Key]
        [DefaultValue(true)]
        public Guid IDMachine { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Size { get; set; }
        [MaxLength(255)]
        [Column(TypeName ="varchar")]
        public string Location { get; set; }
        // FK

        public IList<Intervetion>? Intervetion { get; set; }
        // FK

        public IList<Position>? Position { get; set; }
        // FK

        public IList<Product>? Product { get; set; }
        // FK

        public IList<Support>? Support { get; set; }


    }
}
