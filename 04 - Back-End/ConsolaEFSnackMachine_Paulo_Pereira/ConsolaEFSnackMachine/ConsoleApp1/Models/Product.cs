﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnackMachine.Models
{
    [Table("Product")]
    internal class Product
    {
        [Key]
        [DefaultValue(true)]
        public Guid IDProduct { get; set; }

        [MaxLength(255)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }

        [Column(TypeName = "decimal(10,3)")]
        public decimal Price { get; set; }
        public int Stock { get; set; }
        [MaxLength(500)]
        [Column(TypeName ="varchar")]
        public string Ingredients { get; set; }
        public DateTime ExpDate { get; set; }
        [ForeignKey("IDPosition")]
        public IList<Position> Position { get; set; }
        [ForeignKey("IDMachine")]

        public IList<Machine> Machine { get; set; }
        [ForeignKey("IDSupplier")]

        public IList<Supplier> Supplier { get; set; }

        public Orders Order { get; set; }


    }
}