using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CancionesWebApi.Models
{
    public class Cancion
    {
        [Key]
        [Required]
        public string Nombre { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Introduzca el autor")]
        public string Autor { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Escriba la letra")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "La letra debe ser de un minimo de 10 palabras y maximo 200")]
        public string Letra { get; set; }
        [Required]
        [Url]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "La letra debe ser de un minimo de 10 caracteres y maximo 100")]
        public string Enlace { get; set; }
    }
}
