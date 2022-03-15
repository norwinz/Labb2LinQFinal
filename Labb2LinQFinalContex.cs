using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Labb2LinQFinal
{
    public class Labb2LinQFinalContex : DbContext
    {
        public DbSet<Lärare> Lärare { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Ämne> Ämne { get; set; }
        public DbSet<Kurs> Kurs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-HMA3C5T\\TESTSERVER;Initial Catalog = LINQFINAL;Integrated Security = True;");
        }
    }
}
