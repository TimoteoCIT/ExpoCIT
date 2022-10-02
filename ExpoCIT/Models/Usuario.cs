using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ExpoCIT.Models
{
    public class Usuario : Auditable
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Porfavor ingresar el username.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Porfavor ingresar la contraseña.")]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string Contrasena { get; set; }

        public string Nombre { get; set; }

        [Display(Name = "Primer Apellido")]
        public string PrimerApellido { get; set; }

        [Display(Name = "Segundo Apellido")]
        public string SegundoApellido { get; set; }
    }
}
