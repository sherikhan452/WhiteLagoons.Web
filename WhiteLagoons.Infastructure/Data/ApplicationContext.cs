﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhiteLagoons.Domain.Entities;

namespace WhiteLagoons.Infastructure.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }


        public DbSet<Villa> Villas { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<VillaNumber> VillaNumbers { get; set; }

    }
    }

