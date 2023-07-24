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
        [ForeignKey("IDMachine")]
        public IList<Machine> Machine { get; set;}

        [ForeignKey("IDSupport")]
        public IList<Support> Support { get; set;}
    }
}
