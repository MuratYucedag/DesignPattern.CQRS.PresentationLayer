using DesignPattern.CQRS.PresentationLayer.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.CQRS.PresentationLayer.DAL.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-07T8MF2\\MSSQLSERVER01;initial catalog=CQRSDb;integrated security=true");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<University> Universities { get; set; }
    }
}
