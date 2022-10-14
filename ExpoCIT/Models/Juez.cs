using System.ComponentModel.DataAnnotations;

namespace ExpoCIT.Models
{
    public class Juez : Auditable
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Porfavor ingresar la cédula.")]
        [RegularExpression(@"^[1-9]-\d{4}-\d{4}", ErrorMessage = "Formato de cédula debe ser x-xxxx-xxxx")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "Porfavor ingresar la contraseña.")]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string Contrasena { get; set; }

        public string Nombre { get; set; }

        [Display(Name = "Primer Apellido")]
        public string PrimerApellido { get; set; }

        [Display(Name = "Segundo Apellido")]
        public string SegundoApellido { get; set; }

        public List<Proyecto> Proyectos { get; set; }
    }
}
