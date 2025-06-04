﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteLagoons.Domain.Entities
{
    public class VillaNumber
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public  int VillaNum { get; set; }

        [ForeignKey("Villa")]
        public int VillaID { get; set; }

        public Villa Villa { get; set; }
        public string? VillaDetails { get; set; }
    }
}
