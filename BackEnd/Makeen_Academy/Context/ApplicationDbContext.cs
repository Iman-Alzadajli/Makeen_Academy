using Makeen_Academy.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makeen_Academy.Context
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ZADJALI\\MSSQLSERVER02; database = Makeen_Academy ; Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");

        }

        overr

        //Debset

        public DbSet<Batch> Batches { get; set; }
        public DbSet<Book> Books { get; set; }

        public DbSet<Consultation> Consultations { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Purchase> Purchases { get; set; }

        public DbSet<Trainer> Trainers { get; set; }





    }
}
