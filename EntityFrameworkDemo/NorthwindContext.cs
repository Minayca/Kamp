using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo
{
    class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //@ koymamızın sebebi \'ı kullanabilmektir.
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Personel> Personels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //Veri tabanını modelliyor.
        {
            //modelBuilder.HasDefaultSchema("admin"); //Default schema'yı bu şekilde verebiliriz.
            //modelBuilder.Entity<Personel>().ToTable("Employees", "dbo"); //Normalde default schema dbo'dur.

            //Personel isimli class'ı Employess isimli tabloya bağlıyoruz.
            modelBuilder.Entity<Personel>().ToTable("Employees");

            //Fluent Mapping
            //Alanları veriyoruz.
            modelBuilder.Entity<Personel>().Property(p => p.Id).HasColumnName("EmployeeID");
            modelBuilder.Entity<Personel>().Property(p => p.Name).HasColumnName("FirstName");
            modelBuilder.Entity<Personel>().Property(p => p.Surname).HasColumnName("LastName");
        }
    }
}
