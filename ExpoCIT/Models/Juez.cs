using System.ComponentModel.DataAnnotations;

namespace ExpoCIT.Models
{
    class Juez : Auditable
    {
        [Required(ErrorMessage = "Porfavor ingresar la cedula.")]
        [RegularExpression(@"^[1-9]-\d{4}-\d{4}", ErrorMessage = "Formato de cedula debe ser x-xxxx-xxxx")]
        string Cedula { get; set; }

        [Required(ErrorMessage = "Porfavor ingresar la contraseña.")]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        string Contrasena { get; set; }

        string Nombre { get; set; }

        [Display(Name = "Primer Apellido")]
        string PrimerApellido { get; set; }

        [Display(Name = "Segundo Apellido")]
        string SegundoApellido { get; set; }

        List<Proyecto> Proyectos { get; set; }
    }
}
