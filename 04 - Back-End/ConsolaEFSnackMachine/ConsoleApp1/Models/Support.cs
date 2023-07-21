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
    [Table("Support")]
    internal class Support
    {
        [Key]
        [DefaultValue(true)]
        public Guid IDSupport { get; set; }

        [MaxLength(255)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }

        [MaxLength(255)]
        [Column(TypeName = "varchar")]
        public string Nif { get; set; }

        [MaxLength(255)]
        [Column(TypeName = "varchar")]
        public string Tele { get; set; }

        [MaxLength(255)]
        [Column(TypeName ="varchar")]
        public string Adress { get;set; }
    }
}
