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

        // FK
        public IList<Product>? Product { get; set; }
        // FK
        public Costumer? Costumer { get; set; }
       

    }
}
