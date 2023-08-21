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
    [Table("Supplier")]
    internal class Supplier
    {
        [Key] // ID
        [DefaultValue(true)] // Cria automaticamente
        public Guid IDSupplier { get; set; }

        [MaxLength(255)] // Comprimento : 255
        [Column(TypeName = "varchar")] // Tipo Varchar
        public string Name { get; set; }

        [MaxLength(255)] 
        [Column(TypeName = "varchar")] 
        public string NIF { get; set; }

        [MaxLength(255)]
        [Column(TypeName = "varchar")]
        public string Tele { get; set; }

        [MaxLength(255)]
        [Column(TypeName = "varchar")]
        public string Adrress { get; set; }
        [ForeignKey("IDProduct")]

        public IList<Product> Product { get; set; }


    }
}
