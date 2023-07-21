using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnackMachine.Models
{
    [Table("MachineSupport")]
    internal class MachineSupport
    {
        [Required]
        [ForeignKey("IDMachine")]
        public IList<Machine> Machines { get; set;}

        [Required]
        [ForeignKey("IDSupport")]

        public IList<Support> Support { get; set;}
    }
}
