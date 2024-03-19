using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcProducto.Models
{
    public enum Cargo
    {
        Staff,
        Coordinador,
        Jefe,
        Gerente,
        Director,
        Presidente
    }
    
    public class Empleado
    {
        public Empleado()
        {
            Nombre = Apellidos = Email = Cedula = "";
            Departamento =new Departamento();
        }

        public Empleado(int DepartamentoId, string nombre)
        {
            Nombre = Apellidos = Email = Cedula = "";
            Departamento =new Departamento(DepartamentoId, nombre);
        }
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Los apellidos son obligatorio.")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "La cedula es obligatoria.")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "El campo de correo electrónico es obligatorio.")]
        [EmailAddress(ErrorMessage = "El correo electrónico no es válido.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Debe escoger un cargo.")]
        public Cargo Cargo { get; set; }

        public int? DepartamentoId { get; set; }
        
        [ForeignKey("DepartamentoId")]
        public Departamento Departamento { get; set; }
        
    }
}