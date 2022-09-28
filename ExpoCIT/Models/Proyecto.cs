namespace ExpoCIT.Models
{
    enum TipoProyecto
    {
        ExpoIngenieria,
        ExpoJovem
    }

    public class Proyecto : Auditable
    {
        string NumStand { get; set; }
        string nombre { get; set; }
        string integrantes { get; set; }
        TipoProyecto TipoProyecto { get; set; }
    }
}
