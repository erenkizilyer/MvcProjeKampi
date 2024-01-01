﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryID { get; set; }

        [StringLength(50)]
        public string CategoryName { get; set; }

        [StringLength(200)]
        public string CategoryDescription { get; set; }


        public bool CategoryStatus { get; set; }


        public ICollection<Heading> Headings { get; set; }
    }
}
