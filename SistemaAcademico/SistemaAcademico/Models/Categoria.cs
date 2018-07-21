using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sistema.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre de 3 a 50 caracteres")]
        public string Nombre { get; set; }
        [StringLength(256, ErrorMessage = "La Descripción no debe exeder de 256 caracteres")]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        public Boolean Estado { get; set; }
    }
}
