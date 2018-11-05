using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //Anotaciones para propiedades de los campos
using System.ComponentModel.DataAnnotations.Schema;//Ver Anotaciones de datos en Entity Framework

namespace Sistema.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        [Required (ErrorMessage = "Campo Requerido")]
        [StringLength(50, MinimumLength = 3,ErrorMessage = "El nombre debe tener de 3 a 50 caracteres")]
        public string Nombre { get; set; }
        [StringLength(256,ErrorMessage = "La Descripciòn no debe exceder los 256 caracteres")]
        [Display(Name = "Descripciòn")]
        public string Descripcion { get; set; }
        public Boolean Estado { get; set; } = true;
    }
}
