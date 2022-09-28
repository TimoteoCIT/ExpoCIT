using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ExpoCIT.Models
{
    public class Usuario : Auditable
    {
        [Required(ErrorMessage = "Porfavor ingresar el username.")]
        string Username { get; set; }

        [Required(ErrorMessage = "Porfavor ingresar la contraseña.")]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        string Contrasena { get; set; }

        string Nombre { get; set; }

        [Display(Name = "Primer Apellido")]
        string PrimerApellido { get; set; }

        [Display(Name = "Segundo Apellido")]
        string SegundoApellido { get; set; }
    }
}
