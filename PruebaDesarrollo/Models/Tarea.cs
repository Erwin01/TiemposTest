using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace PruebaDesarrollo.Models
{
    public class Tarea
    {
        public int Id { get; set; }
        public string DescripcionTarea { get; set; }

    }

    class TareasDbContext : DbContext
    {
        public DbSet<Tarea> Tareas { get; set; }

    }
}