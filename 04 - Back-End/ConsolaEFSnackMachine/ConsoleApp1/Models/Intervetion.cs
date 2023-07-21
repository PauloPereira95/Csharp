using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    [Table("Intervetion")]
    internal class Intervetion
    {
        [Key]
        [DefaultValue(true)]
        public Guid IDIntervetion { get; set; }
        [Column(TypeName="varchar")]
        [MaxLength(255)]
        public string Name { get; set; }

        [Column(TypeName= "varchar")]
        [MaxLength(255)]
        public string Description { get; set; }
        public DateTime Date { get; set; }

        [Column(TypeName= "decimal(10,2)")]
        public string Cost { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(255)]
        public string NameTecnical { get; set; }


    }
}
