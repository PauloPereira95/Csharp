using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnackMachine.Models
{
    [Table("ProductPosition")]
    internal class ProductPosition
    {
        [Required]
        [ForeignKey("IDProduct")]
        public Product Product { get; set; }
        [Required]

        [ForeignKey("IDPosition")]
        public Position Position { get; set; }


    }
}
