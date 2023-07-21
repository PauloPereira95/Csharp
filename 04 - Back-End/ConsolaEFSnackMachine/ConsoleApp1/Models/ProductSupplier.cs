﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnackMachine.Models
{
    [Table("ProductSupplier")]
    internal class ProductSupplier
    {
        [Required]
        [ForeignKey("IDProduct")]
        public IList<Product> Products { get; set; }

        [Required]
        [ForeignKey("IDSupplier")]
        public IList<Supplier> Supplier { get; set; }
    }
}
