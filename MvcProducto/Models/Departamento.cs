using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProducto.Models
{
    public class Departamento
    {
        public Departamento()
        {
            Nombre = "";
            
        }
        public Departamento(int id, string nombre)
        {
            Nombre = nombre;
            Id = id;
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string? Responsable { get; set; }

        public Empleado? Empleado { get; set; }
    }
}