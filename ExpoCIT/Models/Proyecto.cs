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
        string Nombre { get; set; }
        string Integrantes { get; set; }
        TipoProyecto TipoProyecto { get; set; }
        Juez? Juez { get; set; }
        RPEI? RPEI { get; set; }
        RTEEI? RTEEI { get; set; }
        RPEJ? RPEJ { get; set; }
    }
}
