#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AidCare2.Models;

    public class AidCare2Context : DbContext
    {
        public AidCare2Context (DbContextOptions<AidCare2Context> options)
            : base(options)
        {
        }

        public DbSet<AidCare2.Models.members> members { get; set; }

        public DbSet<AidCare2.Models.donations> donations { get; set; }

        public DbSet<AidCare2.Models.events> events { get; set; }
    }
