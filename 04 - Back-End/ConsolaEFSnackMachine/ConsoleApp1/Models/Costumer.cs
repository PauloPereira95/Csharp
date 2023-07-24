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
    [Table("Costumer")]
    internal class Costumer
    {
        [Key]
        [DefaultValue(true)]
        public Guid IDCostumer { get; set; }

        [MaxLength(255)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }

        [MaxLength(255)]
        [Column(TypeName ="varchar")]
        public string Adress { get; set; }

        [MaxLength (255)]
        [Column(TypeName ="varchar")]
        public string Tele { get; set; }
        [ForeignKey("IDMoney")]
        public IList<Money> Money { get; set; }



    }
}
