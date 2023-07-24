using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnackMachine.Models
{
    [Table("MachinePosition")]
    internal class MachinePosition
    {

        [ForeignKey("IDMachine")]
        public IList<Machine> Machine { get; set; }

        [ForeignKey("IDPosition")]

        public IList<Position> Position { get; set; }
    }
}
