using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WordFish.Models
{
    
        public class Context : DbContext
        {
            public DbSet<Fish> Fish{ get; set; }

            

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=Cursomvc;Integrated Security=True");
            }
        }

    }

