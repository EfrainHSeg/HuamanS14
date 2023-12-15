using HuamanS14.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HuamanS14.DataContext
{
    public class AppDbContext : DbContext
    {
        string DbPath = string.Empty;


        //Tablas de base de datos
        public DbSet<Compra> Compra { get; set; }

        public AppDbContext(string dbPath)
        {
            this.DbPath = dbPath;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={DbPath}");
        }
    }
}
