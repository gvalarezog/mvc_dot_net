using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcProducto.Models;

namespace MvcProducto.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        :base(options)
        {

        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cliente> Clientes { get; set; } = default!;
        public DbSet<Empleado> Empleados { get; set; } = default!;
        public DbSet<Departamento> Departamentos { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleado>()
            .HasOne(e => e.Departamento)
            .WithOne(d => d.Empleado)
            .HasForeignKey<Empleado>(e => e.DepartamentoId);
        }
    }
}