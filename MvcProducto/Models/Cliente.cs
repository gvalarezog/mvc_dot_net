using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MvcProducto.Models
{
    public class Cliente
    {
        public Cliente()
        {
            Nombre = Apellidos = Email = Cedula = "";
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
    }
}