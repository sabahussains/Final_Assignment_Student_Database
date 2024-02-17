using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstMvcProject
{
    using FirstMvcProject.Models;
    using System.Data.Entity;
    using Microsoft.EntityFrameworkCore;

    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Replace "YourConnectionString" with your actual SQL Server connection string
            optionsBuilder.UseSqlServer("YourConnectionString");
        }
    }

}