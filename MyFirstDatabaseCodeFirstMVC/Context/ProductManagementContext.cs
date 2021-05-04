using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MyFirstDatabaseCodeFirstMVC.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MyFirstDatabaseCodeFirstMVC.Context
{
    public class ProductManagementContext:DbContext
    {
        public ProductManagementContext() : base("ProductManagementContextDB") { }

        public DbSet<Mahasiswa> Mahasiswas { get; set; }
        public DbSet<MataKuliah> MataKuliahs { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Nilai> Nilais { get; set; }

       

    }
}