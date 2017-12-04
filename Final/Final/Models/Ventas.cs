using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final.Models
{
    public class Ventas
    {
        public int Id { get; set; }

        public int No_Factura { get; set; }

        public int ClienteId { get; set; }
        public Clientes Cliente { get; set; }

        public int EmpleadoId { get; set; }
        public Empleados Empleado { get; set; }

        public int ProductoId { get; set; }
        public Productos Producto { get; set; }
    }
}