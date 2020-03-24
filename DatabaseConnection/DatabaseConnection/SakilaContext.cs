using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace DatabaseConnection
{
    class SakilaContext : DbContext
    {
        public DbSet<Actor> Actor { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-GCR864HL\SQLEXPRESS;Database=sakila;Trusted_Connection=True;");
        }
    }
}
