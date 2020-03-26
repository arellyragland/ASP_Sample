using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Database_Lab
{
        class SakilaContext : DbContext
        {

            public DbSet<Film> Film { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder options)
            {
                options.UseSqlServer(@"Server=LAPTOP-GCR864HL\SQLEXPRESS;Database=sakila;Trusted_Connection=True;")
    ;
            }
        }
    
}
