using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Final.Models
{
    public class DbApplication:DbContext
    {
        public DbSet<Clientes>  Cliente { get; set; }
        public DbSet<Empleados> Empleado { get; set; }
        public DbSet<Productos> Producto { get; set; }
        public DbSet<Ventas> Ventas { get; set; }




    }
}