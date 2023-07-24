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
    [Table("Position")]
    internal class Position
    {
        [Key]
        [DefaultValue(true)]
        public Guid IDPosition { get; set; }

        [MaxLength(255)]
        [Column(TypeName ="varchar")]
        public string Descripiton { get; set; }
        [ForeignKey("IDProduct")]

        public IList<Product> Product { get; set; }
        [ForeignKey("IDMachine")]

        public IList<Machine> Machine { get; set; }


    }
}
