using System;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace StudentProj_EntityFramework
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=StudentsDB;Trusted_Connection=True;");
        }
    }
}