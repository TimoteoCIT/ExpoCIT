namespace ExpoCIT.Models
{
    public abstract class Auditable
    {
        public DateTime FechaCreado { get; set; }
        public DateTime? FechaModificado { get; set; }
    }
}
