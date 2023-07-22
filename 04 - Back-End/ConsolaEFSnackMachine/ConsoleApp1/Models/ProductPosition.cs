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
        
        [ForeignKey("IDProduct")]
        public Product Products { get; set; }
        [ForeignKey("IDPosition")]
        public Position Positions { get; set; }


    }
}
