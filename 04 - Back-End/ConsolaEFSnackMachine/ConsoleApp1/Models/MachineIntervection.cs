using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnackMachine.Models
{
    [Table("MachineIntervetion")]
    internal class MachineIntervection
    {

        [Required]
        [ForeignKey("IDMachine")]
        public IList<Machine> Machine { get; set; }

        [Required]
        [ForeignKey("IDIntervetion")]
        public IList<Intervetion> Intervetion { get; set; }
    }
}
