using System;
using System.Collections.Generic;
using System.Linq;
using MetalBroxstarChaos.Modelos;
using Microsoft.EntityFrameworkCore;

namespace MetalBroxstarChaos.Datos
{
    public class BroxstarContext : DbContext
    {

        public DbSet<Personaje> Personajes { get; set; }

        public DbSet<Habilidad> Habilidades { get; set; }

        public DbSet<Clase> Clases { get; set; }

        public BroxstarContext()
        {
            //luego de haber creado la base de datos se utiliza
            Database.EnsureCreated();
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Broxstars.db");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clase>().HasData(
                new Clase { idClase = 1, nombreClase = "Guerrero"},
                new Clase { idClase = 2, nombreClase = "Mago"},
                new Clase { idClase = 3, nombreClase = "Paladín"},
                new Clase { idClase = 4, nombreClase = "Pícaro" }
                );

        }

        
    }
}